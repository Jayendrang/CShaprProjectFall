using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ConsignmentCompanyProject.com.app.interfaces;
using ConsignmentCompanyProject.com.app.dataobjects;
using ConsignmentCompanyProject.com.app.model;
namespace ConsignmentCompanyProject.com.app.model
{
    class InventoryDBProcessHandler : IAppInventory<ProductProperties>
    {
        public static Dictionary<string, List<ProductProperties>> INVENTORY_LIST = new Dictionary<string, List<ProductProperties>>();
        public static List<string> PRODUCT_TYPE = new List<string>();
        

        public List<ManufacturerProperties> getManufacturersList()
        {
            throw new NotImplementedException();
        }

        public List<ProductProperties> getManufacturersProductsList(ManufacturerProperties manufacturer)
        {
            DataSet resultDataset;
            List<ProductProperties> manufacturerProducts = new List<ProductProperties>();
            string selectQueryString = "SELECT PRODUCT.PRODUCT_ID,PRODUCT_TYPE,PRODUCT.PRODUCT_NAME,PRODUCT.PRODUCT_CURRENT_COUNT,PRODUCT.PRICE_PER_UNIT,PRODUCT.MINIMUM_COUNT,MANUFACTURER.MANUFACTURER_ID, MANUFACTURER.MANUFACTURER_NAME,MANUFACTURER_DETAIL FROM PRODUCT INNER JOIN MANUFACTURER ON PRODUCT.MANUFACTURER_ID = MANUFACTURER.MANUFACTURER_ID WHERE MANUFACTURER.MANUFACTURER_ID = @MANFACTURERID ORDER BY MANUFACTURER.MANUFACTURER_NAME;";
            List<KeyValuePair<string, string>> tableQueryData = new List<KeyValuePair<string, string>>();
            tableQueryData.Add(new KeyValuePair<string, string>("@MANFACTURERID", manufacturer.Manufacturer_Id));
            resultDataset = DatabaseConnectionHandler.executeSelectQuery(selectQueryString,  tableQueryData);
            return manufacturerProducts;
        }

        public Dictionary<string, List<ProductProperties>> getProducts()
        {
            DataSet resultDataset;
            Dictionary<string, List<ProductProperties>> productCollection = new Dictionary<string, List<ProductProperties>>();
            
            List<ProductProperties> productList = new List<ProductProperties>();
            string selectQueryString = "SELECT PRODUCT.PRODUCT_ID,PRODUCT_TYPE,PRODUCT.PRODUCT_NAME,PRODUCT.MINIMUM_COUNT,PRODUCT.PRODUCT_CURRENT_COUNT,PRODUCT.PRICE_PER_UNIT,MANUFACTURER.MANUFACTURER_ID, MANUFACTURER.MANUFACTURER_NAME,MANUFACTURER_DETAIL FROM PRODUCT INNER JOIN MANUFACTURER ON PRODUCT.MANUFACTURER_ID = MANUFACTURER.MANUFACTURER_ID ORDER BY MANUFACTURER.MANUFACTURER_NAME;";
            resultDataset = DatabaseConnectionHandler.executeSelectQuery(selectQueryString, null);
            if (resultDataset != null)
            {

                foreach(DataRow resultrow in resultDataset.Tables[0].Rows)
                {
                    ProductProperties productProperties = new ProductProperties();
                    productProperties.Product_Id = resultrow["Product_id"].ToString();
                    productProperties.Product_Type = resultrow["Product_type"].ToString();
                    productProperties.Product_Name = resultrow["Product_name"].ToString();
                    productProperties.Minimum_Count = int.Parse(resultrow["Minimum_count"].ToString());
                    productProperties.Product_Current_Count = int.Parse(resultrow["Product_Current_Count"].ToString());
                    productProperties.Price_Per_Unit = double.Parse(resultrow["Price_per_unit"].ToString());
                    productProperties.Manufacturer_Id = resultrow["Manufacturer_id"].ToString();
                    productProperties.Manufacturer_Name = resultrow["Manufacturer_Name"].ToString();
                    productProperties.Manufacturer_Detail = resultrow["Manufacturer_detail"].ToString();
                    productList.Add(productProperties);
                    PRODUCT_TYPE.Add(productProperties.Product_Type);           
                }
            }else
            {
                productList = null;
            }

            List<string> manufacturer_id = (from manId in productList select manId.Manufacturer_Id).Distinct().ToList();
            
            
            foreach(string manf_id in manufacturer_id)
            {
                List<ProductProperties> tempProductList = new List<ProductProperties>();
                foreach(ProductProperties props in productList)
                {

                     if (manf_id.Equals(props.Manufacturer_Id))
                    {
                        tempProductList.Add(props);
                        
                    }

                }

             
                productCollection.Add(manf_id, tempProductList);
              }
            
            INVENTORY_LIST = productCollection;
            return productCollection;
        }

       

      

        ProductProperties IAppInventory<ProductProperties>.searchProduct(string ProductName)
        {
            throw new NotImplementedException();
        }

        List<ProductProperties> IAppInventory<ProductProperties>.getManufacturersList()
        {
            throw new NotImplementedException();
        }

        ProductProperties IAppInventory<ProductProperties>.searchManufacturer(string manufacturerName)
        {
            throw new NotImplementedException();
        }

        ProductProperties IAppInventory<ProductProperties>.addNewProduct(ProductProperties productInfo, UserInformationProperties userInfo)
        {
            string insertNewProductQuery = "INSERT INTO PRODUCT (PRODUCT_ID,PRODUCT_NAME,PRODUCT_TYPE,MANUFACTURER_ID,PRODUCT_CURRENT_COUNT,MINIMUM_COUNT,PRICE_PER_UNIT,CREATED_BY,CREATED_DATE,MODIFIED_BY,MODIFIED_DATE) VALUES(@PRODUCT_ID,@PRODUCT_NAME,@PRODUCT_TYPE,@MANUFACTURER_ID,@PRODUCT_CURRENT_COUNT,@MINIMUM_COUNT,@PRICE_PER_UNIT,@CREATED_BY,@CREATED_DATE,@MODIFIED_BY,@MODIFIED_DATE)";
            
            List<KeyValuePair<string, string>> tableParamsValues = new List<KeyValuePair<string, string>>();
            tableParamsValues.Add(new KeyValuePair<string, string>("@PRODUCT_ID",productInfo.Product_Id));
            tableParamsValues.Add(new KeyValuePair<string, string>("@PRODUCT_NAME", productInfo.Product_Name));
            tableParamsValues.Add(new KeyValuePair<string, string>("@PRODUCT_TYPE", productInfo.Product_Type));
            tableParamsValues.Add(new KeyValuePair<string, string>("@MANUFACTURER_ID", productInfo.Manufacturer_Id));
            tableParamsValues.Add(new KeyValuePair<string, string>("@PRODUCT_CURRENT_COUNT", Convert.ToString(productInfo.Product_Current_Count)));
            tableParamsValues.Add(new KeyValuePair<string, string>("@MINIMUM_COUNT",Convert.ToString(productInfo.Minimum_Count)));
            tableParamsValues.Add(new KeyValuePair<string, string>("@PRICE_PER_UNIT", Convert.ToString(productInfo.Price_Per_Unit)));
            tableParamsValues.Add(new KeyValuePair<string, string>("@CREATED_BY", userInfo.User_Id));
            tableParamsValues.Add(new KeyValuePair<string, string>("@CREATED_DATE", com.app.utlitiy.BusinessUtlities.getCurrentDateTime));
            tableParamsValues.Add(new KeyValuePair<string, string>("@MODIFIED_BY", userInfo.User_Id));
            tableParamsValues.Add(new KeyValuePair<string, string>("@MODIFIED_DATE", com.app.utlitiy.BusinessUtlities.getCurrentDateTime));
            DatabaseConnectionHandler.executeInsertDbQuery(insertNewProductQuery, tableParamsValues);
            

            return null;
        }
        
        bool IAppInventory<ProductProperties>.reduceProductCount(ProductProperties[] productInfo)
        {

            string updateQueryString = "UPDATE PRODUCT SET PRODUCT_CURRENT_COUNT=PRODUCT_CURRENT_COUNT-@ORDER_COUNT WHERE PRODUCT_ID=@PRODUCTID";
            List<KeyValuePair<string, string>> tableQueryData = new List<KeyValuePair<string, string>>();
            bool result = false;
            foreach (ProductProperties props in productInfo)
            {
                string key = props.Product_Id;
                int value = props.Product_Current_Count;
                tableQueryData.Add(new KeyValuePair<string, string>(key, value.ToString()));
                result = DatabaseConnectionHandler.executeUpdateQuery(updateQueryString, tableQueryData);
            }
            return result;
        }

        public bool removeProduct(ProductProperties productId)
        {
            bool result = false;

            try { 
            string deleteQueryString = "DELETE FROM PRODUCT WHERE PRODUCT_ID=@PRODUCTID";
            List< KeyValuePair < string, string>> tableQueryData = new List<KeyValuePair<string, string>>();
            tableQueryData.Add(new KeyValuePair<string, string>("@PRODUCTID", productId.Product_Id));
            result = DatabaseConnectionHandler.executeDeleteQuery(deleteQueryString, tableQueryData);
            } catch(Exception ex) { Console.WriteLine(ex.StackTrace); }
            return result;
        }

        public List<ProductProperties> getManufacturersProductsList(ProductProperties manufacturer)
        {
            throw new NotImplementedException();
        }

        public bool removeProduct(ProductProperties productId, UserInformationProperties userinfo)
        {
            throw new NotImplementedException();
        }

        public  void addNewManufacturer(ManufacturerProperties manufacturerInfo,UserInformationProperties userInfo)
        {
            string insertNewManufacturerQuery = "INSERT INTO MANUFACTURER(MANUFACTURER_ID,MANUFACTURER_NAME,MANUFACTURER_DETAIL,CREATED_BY,CREATED_DATE,MODIFIED_BY,MODIFIED_DATE) VALUES(@MANUFACTURER_ID,@MANUFACTURER_NAME,@MANUFACTURER_DETAIL,@CREATED_BY,@CREATED_DATE,@MODIFIED_BY,@MODIFIED_DATE)";
            List<KeyValuePair<string, string>> tableQueryData = new List<KeyValuePair<string, string>>();
            tableQueryData.Add(new KeyValuePair<string, string>("@MANUFACTURER_ID", manufacturerInfo.Manufacturer_Id));
            tableQueryData.Add(new KeyValuePair<string, string>("@MANUFACTURER_NAME", manufacturerInfo.Manufacturer_Name));
            tableQueryData.Add(new KeyValuePair<string, string>("@MANUFACTURER_DETAIL", manufacturerInfo.Manufacturer_Detail));
            tableQueryData.Add(new KeyValuePair<string, string>("@CREATED_BY", userInfo.User_Id));
            tableQueryData.Add(new KeyValuePair<string, string>("@CREATED_DATE", com.app.utlitiy.BusinessUtlities.getCurrentDateTime));
            tableQueryData.Add(new KeyValuePair<string, string>("@MODIFIED_BY", userInfo.User_Id));
            tableQueryData.Add(new KeyValuePair<string, string>("@MODIFIED_DATE", com.app.utlitiy.BusinessUtlities.getCurrentDateTime));
            DatabaseConnectionHandler.executeInsertDbQuery(insertNewManufacturerQuery, tableQueryData);
            
        }


        
    }
}
