﻿using System;
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
    /*
     * Created by Jayendran Gurumoorthy
     * This class contains datbaase queries that related to Inventory Management
     */

    class InventoryDBProcessHandler : IAppInventory<ProductProperties>
    {
        //static fields to hold the product list and product from inventory
        public static Dictionary<string, List<ProductProperties>> _inventory_list = new Dictionary<string, List<ProductProperties>>();
        public static List<string> _product_type = new List<string>();
        public static List<ProductProperties> _product_list = new List<ProductProperties>();
        
        //retrive Product details from database 
        public Dictionary<string, List<ProductProperties>> getProducts()
        {

            DataSet resultDataset;
            Dictionary<string, List<ProductProperties>> productCollection = new Dictionary<string, List<ProductProperties>>();
            try { 
            List<ProductProperties> productList = new List<ProductProperties>();
            string selectQueryString = "SELECT PRODUCT.PRODUCT_ID,PRODUCT_TYPE,PRODUCT.PRODUCT_NAME,PRODUCT.MINIMUM_COUNT,PRODUCT.PRODUCT_CURRENT_COUNT,PRODUCT.PRICE_PER_UNIT,MANUFACTURER.MANUFACTURER_ID, MANUFACTURER.MANUFACTURER_NAME FROM PRODUCT INNER JOIN MANUFACTURER ON PRODUCT.MANUFACTURER_ID = MANUFACTURER.MANUFACTURER_ID WHERE MANUFACTURER.MANUFACTURER_STATUS='ACTIVE' ORDER BY MANUFACTURER.MANUFACTURER_NAME;";
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
                    productList.Add(productProperties);
                    _product_type.Add(productProperties.Product_Type);
                    _product_list.Add(productProperties);
                }
            }else
            {
                productList = null;
            }

            //LINQ query to get the distict string value of manufacturers in List collection type
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
            
            _inventory_list = productCollection;
            }catch(Exception exp)
            {
                Console.WriteLine(exp.StackTrace);
            }
            return productCollection;
        }

       

      

        // Retrieve manufactures list from database
       public List<ManufacturerProperties> getManufacturersList(string status)
        {
            ManufacturerProperties manufacturerProperties;
            List<ManufacturerProperties> manufacturersList = new List<ManufacturerProperties>();
            DataSet resultDataset;
            try { 
            string selectQueryString = "SELECT MANUFACTURER_ID, MANUFACTURER_NAME, MANUFACTURER_DETAIL, MANUFACTURER_STATUS FROM MANUFACTURER WHERE MANUFACTURER_STATUS=@STATUS";
            List<KeyValuePair<string, string>> tableParamsValues = new List<KeyValuePair<string, string>>();
                tableParamsValues.Add(new KeyValuePair<string, string>("@STATUS",status));
                resultDataset = DatabaseConnectionHandler.executeSelectQuery(selectQueryString, tableParamsValues);
            if (resultDataset != null)
            {
                foreach (DataRow resultrow in resultDataset.Tables[0].Rows)
                {
                    manufacturerProperties = new ManufacturerProperties();
                    manufacturerProperties.Manufacturer_Id = resultrow["Manufacturer_Id"].ToString();
                    manufacturerProperties.Manufacturer_Name = resultrow["Manufacturer_Name"].ToString();
                    manufacturerProperties.Manufacturer_Detail = resultrow["Manufacturer_Detail"].ToString();
                    manufacturerProperties.Manufacturer_Status = resultrow["manufacturer_Status"].ToString();
                    manufacturersList.Add(manufacturerProperties);
                }
            }
            }catch(Exception exp) { Console.WriteLine(exp.StackTrace); }
            return manufacturersList;
        }

        
        // Adding new product in Inventory

        public bool addNewProduct(ProductProperties productInfo, string userInfo)
        {
            string insertNewProductQuery = "INSERT INTO PRODUCT (PRODUCT_ID,PRODUCT_NAME,PRODUCT_TYPE,MANUFACTURER_ID,PRODUCT_CURRENT_COUNT,MINIMUM_COUNT,PRICE_PER_UNIT,CREATED_BY,CREATED_DATE,MODIFIED_BY,MODIFIED_DATE) VALUES(@PRODUCT_ID,@PRODUCT_NAME,@PRODUCT_TYPE,@MANUFACTURER_ID,@PRODUCT_CURRENT_COUNT,@MINIMUM_COUNT,@PRICE_PER_UNIT,@CREATED_BY,@CREATED_DATE,@MODIFIED_BY,@MODIFIED_DATE)";
            bool resultStatus = false;
            List<KeyValuePair<string, string>> tableParamsValues = new List<KeyValuePair<string, string>>();
            tableParamsValues.Add(new KeyValuePair<string, string>("@PRODUCT_ID",productInfo.Product_Id));
            tableParamsValues.Add(new KeyValuePair<string, string>("@PRODUCT_NAME", productInfo.Product_Name));
            tableParamsValues.Add(new KeyValuePair<string, string>("@PRODUCT_TYPE", productInfo.Product_Type));
            tableParamsValues.Add(new KeyValuePair<string, string>("@MANUFACTURER_ID", productInfo.Manufacturer_Id));
            tableParamsValues.Add(new KeyValuePair<string, string>("@PRODUCT_CURRENT_COUNT", Convert.ToString(productInfo.Product_Current_Count)));
            tableParamsValues.Add(new KeyValuePair<string, string>("@MINIMUM_COUNT",Convert.ToString(productInfo.Minimum_Count)));
            tableParamsValues.Add(new KeyValuePair<string, string>("@PRICE_PER_UNIT", Convert.ToString(productInfo.Price_Per_Unit)));
            tableParamsValues.Add(new KeyValuePair<string, string>("@CREATED_BY", userInfo));
            tableParamsValues.Add(new KeyValuePair<string, string>("@CREATED_DATE", com.app.utlitiy.BusinessUtlities.getCurrentDateTime));
            tableParamsValues.Add(new KeyValuePair<string, string>("@MODIFIED_BY", userInfo));
            tableParamsValues.Add(new KeyValuePair<string, string>("@MODIFIED_DATE", com.app.utlitiy.BusinessUtlities.getCurrentDateTime));
            resultStatus=DatabaseConnectionHandler.executeInsertDbQuery(insertNewProductQuery, tableParamsValues);
            

            return resultStatus;
        }
        
        //reduce product count based on order item count when customer submitting the order
       public  bool reduceProductCount(List<ProductProperties> productInfo)
        {

            string updateQueryString = "UPDATE PRODUCT SET PRODUCT_CURRENT_COUNT=PRODUCT_CURRENT_COUNT-@ORDER_COUNT WHERE PRODUCT_ID=@PRODUCTID";
            bool result = false;
            foreach (ProductProperties props in productInfo)
            {
                List<KeyValuePair<string, string>> tableQueryData = new List<KeyValuePair<string, string>>();
                string key = props.Product_Id;
                int value = props.Product_Current_Count;
                tableQueryData.Add(new KeyValuePair<string, string>("@ORDER_COUNT", value.ToString()));
                tableQueryData.Add(new KeyValuePair<string, string>("@PRODUCTID", key.ToString()));
                result = DatabaseConnectionHandler.executeUpdateQuery(updateQueryString, tableQueryData);
            }
            return result;
        }

        //add product count based on order item count when customer submitting the order
      public  bool updateProduct(ProductProperties productInfo,string userInfo)
        {
           
            string updateQueryString = "UPDATE PRODUCT SET PRODUCT_CURRENT_COUNT=PRODUCT_CURRENT_COUNT+@NEW_PRODUCT_COUNT, PRICE_PER_UNIT=@PRICE_PER_UNIT WHERE PRODUCT_ID=@PRODUCTID";
            List<KeyValuePair<string, string>> tableQueryData = new List<KeyValuePair<string, string>>();
            bool result = false;
            tableQueryData.Add(new KeyValuePair<string, string>("@NEW_PRODUCT_COUNT",productInfo.Product_Current_Count.ToString()));
            tableQueryData.Add(new KeyValuePair<string, string>("@PRICE_PER_UNIT", productInfo.Price_Per_Unit.ToString()));
            tableQueryData.Add(new KeyValuePair<string, string>("@PRODUCTID", productInfo.Product_Id));
            result = DatabaseConnectionHandler.executeUpdateQuery(updateQueryString, tableQueryData);
            return result;
        }
        //Remove product from inventory
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

        

        
        //Add new manufacturer in inventory 
        public  bool addNewManufacturer(ManufacturerProperties manufacturerInfo,string userInfo)
        {
            bool result = false;
            try { 
            string insertNewManufacturerQuery = "INSERT INTO MANUFACTURER(MANUFACTURER_ID,MANUFACTURER_NAME,MANUFACTURER_DETAIL,CREATED_BY,CREATED_DATE,MODIFIED_BY,MODIFIED_DATE,MANUFACTURER_STATUS) VALUES(@MANUFACTURER_ID,@MANUFACTURER_NAME,@MANUFACTURER_DETAIL,@CREATED_BY,@CREATED_DATE,@MODIFIED_BY,@MODIFIED_DATE,@MANUFACTURER_STATUS)";
            List<KeyValuePair<string, string>> tableQueryData = new List<KeyValuePair<string, string>>();
            tableQueryData.Add(new KeyValuePair<string, string>("@MANUFACTURER_ID", manufacturerInfo.Manufacturer_Id));
            tableQueryData.Add(new KeyValuePair<string, string>("@MANUFACTURER_NAME", manufacturerInfo.Manufacturer_Name));
            tableQueryData.Add(new KeyValuePair<string, string>("@MANUFACTURER_DETAIL", manufacturerInfo.Manufacturer_Detail));
            tableQueryData.Add(new KeyValuePair<string, string>("@CREATED_BY", userInfo));
            tableQueryData.Add(new KeyValuePair<string, string>("@CREATED_DATE", com.app.utlitiy.BusinessUtlities.getCurrentDateTime));
            tableQueryData.Add(new KeyValuePair<string, string>("@MODIFIED_BY", userInfo));
            tableQueryData.Add(new KeyValuePair<string, string>("@MODIFIED_DATE", com.app.utlitiy.BusinessUtlities.getCurrentDateTime));
                tableQueryData.Add(new KeyValuePair<string, string>("@MANUFACTURER_STATUS", manufacturerInfo.Manufacturer_Status));
                result =DatabaseConnectionHandler.executeInsertDbQuery(insertNewManufacturerQuery, tableQueryData);
            }catch(Exception ex) { Console.WriteLine(ex.StackTrace); }
            return result;
        }

        //retrieve products of a manufacturer from database
        public List<ProductProperties> getManufacturerProductsList(ProductProperties manufacturer)
        {
            DataSet resultDataset;
            List<ProductProperties> manufacturerProducts = new List<ProductProperties>();
            try { 
            string selectQueryString = "SELECT PRODUCT.PRODUCT_ID,PRODUCT_TYPE,PRODUCT.PRODUCT_NAME,PRODUCT.PRODUCT_CURRENT_COUNT,PRODUCT.PRICE_PER_UNIT,PRODUCT.MINIMUM_COUNT,MANUFACTURER.MANUFACTURER_ID, MANUFACTURER.MANUFACTURER_NAME,MANUFACTURER_DETAIL FROM PRODUCT INNER JOIN MANUFACTURER ON PRODUCT.MANUFACTURER_ID = MANUFACTURER.MANUFACTURER_ID WHERE MANUFACTURER.MANUFACTURER_ID = @MANFACTURERID ORDER BY MANUFACTURER.MANUFACTURER_NAME;";
            List<KeyValuePair<string, string>> tableQueryData = new List<KeyValuePair<string, string>>();
            tableQueryData.Add(new KeyValuePair<string, string>("@MANFACTURERID", manufacturer.Manufacturer_Id));
            resultDataset = DatabaseConnectionHandler.executeSelectQuery(selectQueryString, tableQueryData);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
                return manufacturerProducts;
        }

        //deactive/remove the manufacturer from database
        public bool deActivateManufacturer(ManufacturerProperties manufacturerProperties, string userInfo)
        {
            bool result = false;
            try { 
            string updateQueryString = "UPDATE MANUFACTURER SET MANUFACTURER_STATUS=@STATUS,MODIFIED_BY=@MODIFIED_BY,MODIFIED_DATE=@MODIFIED_DATE WHERE MANUFACTURER_ID=@MANUFACTURER_ID";
            List<KeyValuePair<string, string>> tableQueryData = new List<KeyValuePair<string, string>>();
            tableQueryData.Add(new KeyValuePair<string, string>("@STATUS", manufacturerProperties.Manufacturer_Status));
            tableQueryData.Add(new KeyValuePair<string, string>("@MANUFACTURER_ID", manufacturerProperties.Manufacturer_Id));
            tableQueryData.Add(new KeyValuePair<string, string>("@MODIFIED_BY", userInfo));
            tableQueryData.Add(new KeyValuePair<string, string>("@MODIFIED_DATE", com.app.utlitiy.BusinessUtlities.getCurrentDateTime));
            result = DatabaseConnectionHandler.executeUpdateQuery(updateQueryString, tableQueryData);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            return result;
        }

        
    }
}
