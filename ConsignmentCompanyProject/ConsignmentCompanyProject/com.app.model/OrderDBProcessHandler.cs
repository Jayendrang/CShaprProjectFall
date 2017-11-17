using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsignmentCompanyProject.com.app.interfaces;
using ConsignmentCompanyProject.com.app.dataobjects;
using ConsignmentCompanyProject.com.app.utlitiy;
using System.Data;
namespace ConsignmentCompanyProject.com.app.model
{
    /*
     * Craeted by Jayendran Gurumoorthy
     * 
     */ 
    class OrderDBProcessHandler : IAppOrder<OrderProperties>
    {
        public bool cancelOrder(OrderProperties cancelorderInfo)
        {
            string deleteQueryString = "UPDATE SALES_ORDER SET ORDER_STATUS='CANCELLED',DESCRIPTION=@DESCRIPTION,MODIFY_BY=@MODIFIED_BY,MODIFY_DATE=@MODIFIED_DATE WHERE ORDER_ID=@ORDER_ID AND VENDOR_ID=@VENDOR_ID AND ORDER_STATUS=@ORDER_STATUS;";
            List<KeyValuePair<string, string>> queryParameter = new List<KeyValuePair<string, string>>();
            queryParameter.Add(new KeyValuePair<string, string>("@ORDER_ID",cancelorderInfo.Order_Id.ToString()));
            queryParameter.Add(new KeyValuePair<string, string>("@VENDOR_ID", cancelorderInfo.Vendor_Id.ToString()));
            queryParameter.Add(new KeyValuePair<string, string>("@DESCRIPTION", cancelorderInfo.Description.ToString()));
            queryParameter.Add(new KeyValuePair<string, string>("@ORDER_STATUS", cancelorderInfo.Order_Status));
            queryParameter.Add(new KeyValuePair<string, string>("@MODIFIED_BY", cancelorderInfo.User_ID));
            queryParameter.Add(new KeyValuePair<string, string>("@MODIFIED_DATE", utlitiy.BusinessUtlities.getCurrentDateTime.ToString()));
            bool result = DatabaseConnectionHandler.executeUpdateQuery(deleteQueryString, queryParameter);
            return result; 
        }

        public List<OrderProperties> getMultipleOrdersInfo(string vendorInfo,string orderStatus)
        {
            DataSet dataset = new DataSet();

            string selectQueryString = null;
            if (orderStatus == null)
            {
                selectQueryString = "SELECT ORDER_ID,VENDOR_ID,MANUFACTURER_NAME,PRODUCT_ID,PRODUCT_TYPE,PRODUCT_NAME,COUNT,PRICE_PER_UNIT,TOTAL_PRICE,PAID_AMOUNT,BALANCE_AMOUNT,DISCOUNT_RATE,ORDER_STATUS,DESCRIPTION,CREATED_DATE FROM SALES_ORDER  WHERE VENDOR_ID=@VENDOR_ID ORDER BY ORDER_ID";
                List<KeyValuePair<string, string>> queryParameter = new List<KeyValuePair<string, string>>();
                queryParameter.Add(new KeyValuePair<string, string>("@VENDOR_ID", vendorInfo.ToString()));
                dataset = DatabaseConnectionHandler.executeSelectQuery(selectQueryString, queryParameter);
            }else if (orderStatus.Equals("CANCELLED"))
            {
                selectQueryString = "SELECT ORDER_ID,VENDOR_ID,MANUFACTURER_NAME,PRODUCT_ID,PRODUCT_TYPE,PRODUCT_NAME,COUNT,PRICE_PER_UNIT,TOTAL_PRICE,PAID_AMOUNT,BALANCE_AMOUNT,DISCOUNT_RATE,ORDER_STATUS,DESCRIPTION,CREATED_DATE FROM SALES_ORDER  WHERE VENDOR_ID=@VENDOR_ID AND ORDER_STATUS=@ORDER_STATUS ORDER BY ORDER_ID";
                List<KeyValuePair<string, string>> queryParameter = new List<KeyValuePair<string, string>>();
                queryParameter.Add(new KeyValuePair<string, string>("@VENDOR_ID", vendorInfo.ToString()));
                queryParameter.Add(new KeyValuePair<string, string>("@ORDER_STATUS", orderStatus));
                dataset = DatabaseConnectionHandler.executeSelectQuery(selectQueryString, queryParameter);
            }
            else
            {
                selectQueryString = "SELECT ORDER_ID,VENDOR_ID,MANUFACTURER_NAME,PRODUCT_ID,PRODUCT_TYPE,PRODUCT_NAME,COUNT,PRICE_PER_UNIT,TOTAL_PRICE,PAID_AMOUNT,BALANCE_AMOUNT,DISCOUNT_RATE,ORDER_STATUS,DESCRIPTION,CREATED_DATE FROM SALES_ORDER WHERE VENDOR_ID=@VENDOR_ID AND ORDER_STATUS=@ORDER_STATUS ORDER BY ORDER_ID";
                List<KeyValuePair<string, string>> queryParameter = new List<KeyValuePair<string, string>>();
                queryParameter.Add(new KeyValuePair<string, string>("@VENDOR_ID", vendorInfo.ToString()));
                queryParameter.Add(new KeyValuePair<string, string>("@ORDER_STATUS", orderStatus.ToString()));
                dataset = DatabaseConnectionHandler.executeSelectQuery(selectQueryString, queryParameter);
            }
                 List<OrderProperties> listOfOrders = new List<OrderProperties>();

            if (dataset != null)
                {
                    foreach (DataRow row in dataset.Tables[0].Rows)
                    {
                        OrderProperties orderPropereties = new OrderProperties();
                        orderPropereties.Order_Id = row["Order_Id"].ToString();
                        orderPropereties.Vendor_Id = row["Vendor_Id"].ToString();
                        orderPropereties.Manufacturer_Name = row["Manufacturer_Name"].ToString();
                        orderPropereties.Product_Id = row["Product_Id"].ToString();
                        orderPropereties.Product_Name = row["Product_Name"].ToString();
                        orderPropereties.Product_Type = row["Product_Type"].ToString();
                        orderPropereties.Count =Convert.ToInt16(row["Count"].ToString());
                        orderPropereties.Price_Per_Unit = Convert.ToDouble(row["Price_Per_Unit"].ToString());
                        orderPropereties.Total_Price = Convert.ToDouble(row["Total_Price"].ToString());
                        orderPropereties.Paid_Amount = Convert.ToDouble(row["Paid_Amount"].ToString());
                        orderPropereties.Balance_Amount = Convert.ToDouble(row["Balance_Amount"].ToString());
                        orderPropereties.Description = row["Description"].ToString();
                        orderPropereties.Order_Status = row["Order_Status"].ToString();
                        orderPropereties.OrderDate = row["Created_Date"].ToString().Substring(0, 11);
                        orderPropereties.Discount_Rate = row["Discount_Rate"].ToString();
                        listOfOrders.Add(orderPropereties);
                        }
                   
               }
            return listOfOrders;
        }

        public bool submitOrder(List<OrderProperties> purchaseOrderInfo)
        {
            int numberOfRowsInserted = 0;
            bool result = false;
            string insertQueryString = "INSERT INTO SALES_ORDER(ORDER_ID,VENDOR_ID,USER_ID,MANUFACTURER_NAME,PRODUCT_ID,PRODUCT_TYPE,PRODUCT_NAME,COUNT,PRICE_PER_UNIT,TOTAL_PRICE,PAID_AMOUNT,BALANCE_AMOUNT,DISCOUNT_RATE,ORDER_STATUS,DESCRIPTION,CREATED_BY,CREATED_DATE,MODIFY_BY,MODIFY_DATE) VALUES(@ORDER_ID,@VENDOR_ID,@USER_ID,@MANUFACTURER_NAME,@PRODUCT_ID,@PRODUCT_TYPE,@PRODUCT_NAME,@COUNT,@PRICE_PER_UNIT,@TOTAL_PRICE,@PAID_AMOUNT,@BALANCE_AMOUNT,@DISCOUNT_RATE,@ORDER_STATUS,@DESCRIPTION,@CREATED_BY,@CREATED_DATE,@MODIFY_BY,@MODIFY_DATE);";
            List<ProductProperties> reduceProductCountList = new List<ProductProperties>();
            foreach (OrderProperties orderdetail in purchaseOrderInfo)
            {
                ProductProperties productList = new ProductProperties();

                List<KeyValuePair<string, string>> queryParameter = new List<KeyValuePair<string, string>>();
                queryParameter.Add(new KeyValuePair<string, string>("@ORDER_ID",orderdetail.Order_Id));
                queryParameter.Add(new KeyValuePair<string, string>("@VENDOR_ID", orderdetail.Vendor_Id));
                queryParameter.Add(new KeyValuePair<string, string>("@USER_ID", orderdetail.User_ID));
                queryParameter.Add(new KeyValuePair<string, string>("@MANUFACTURER_NAME", orderdetail.Manufacturer_Name));
                queryParameter.Add(new KeyValuePair<string, string>("@PRODUCT_ID", orderdetail.Product_Id));
                queryParameter.Add(new KeyValuePair<string, string>("@PRODUCT_TYPE", orderdetail.Product_Type));
                queryParameter.Add(new KeyValuePair<string, string>("@PRODUCT_NAME", orderdetail.Product_Name));
                queryParameter.Add(new KeyValuePair<string, string>("@COUNT", Convert.ToString(orderdetail.Count)));
                queryParameter.Add(new KeyValuePair<string, string>("@PRICE_PER_UNIT", Convert.ToString(orderdetail.Price_Per_Unit)));
                queryParameter.Add(new KeyValuePair<string, string>("@TOTAL_PRICE", Convert.ToString(orderdetail.Total_Price)));
                queryParameter.Add(new KeyValuePair<string, string>("@PAID_AMOUNT", Convert.ToString(orderdetail.Paid_Amount)));
                queryParameter.Add(new KeyValuePair<string, string>("@BALANCE_AMOUNT", Convert.ToString(orderdetail.Balance_Amount)));
                queryParameter.Add(new KeyValuePair<string, string>("@DISCOUNT_RATE", orderdetail.Discount_Rate));
                queryParameter.Add(new KeyValuePair<string, string>("@ORDER_STATUS", orderdetail.Order_Status));
                queryParameter.Add(new KeyValuePair<string, string>("@DESCRIPTION", orderdetail.Description));
                queryParameter.Add(new KeyValuePair<string, string>("@CREATED_BY", orderdetail.User_ID));
                queryParameter.Add(new KeyValuePair<string, string>("@CREATED_DATE", BusinessUtlities.getCurrentDateTime));
                queryParameter.Add(new KeyValuePair<string, string>("@MODIFY_BY", orderdetail.User_ID));
                queryParameter.Add(new KeyValuePair<string, string>("@MODIFY_DATE", BusinessUtlities.getCurrentDateTime));

                productList.Product_Id = orderdetail.Product_Id;
                productList.Product_Current_Count = orderdetail.Count;
                reduceProductCountList.Add(productList);
               result= DatabaseConnectionHandler.executeInsertDbQuery(insertQueryString, queryParameter);
                if (result == true) {
                    ++numberOfRowsInserted;
                }
            }
            if (numberOfRowsInserted.Equals(purchaseOrderInfo.Count()))
            {
                InventoryDBProcessHandler reduceProductCount = new InventoryDBProcessHandler();
                reduceProductCount.reduceProductCount(reduceProductCountList);
                Console.WriteLine("Order placed sucessfully");
                result = true;

            }else
            {
                Console.WriteLine("Order submission failed");
                result = false;
            }
            return result;
        }

        public bool updateOrderStatus(OrderProperties updateorderInfo)
        {
            bool result = false;
            List<KeyValuePair<string, string>> queryParameter = new List<KeyValuePair<string, string>>();
            if (updateorderInfo.Description != null && updateorderInfo.Order_Status!=null) {
                string updateQueryString = "UPDATE SALES_ORDER SET ORDER_STATUS=@ORDER_STATUS,DESCRIPTION=@DESCRIPTION,MODIFIED_BY=@MODIFIED_BY,MODIFIED_DATE=@MODIFIED_DATE WHERE ORDER_ID=@ORDER_ID";
                queryParameter.Add(new KeyValuePair<string, string>("@ORDER_ID", updateorderInfo.Order_Id.ToString()));
                queryParameter.Add(new KeyValuePair<string, string>("@ORDER_STATUS", updateorderInfo.Vendor_Id.ToString()));
                queryParameter.Add(new KeyValuePair<string, string>("@DESCRIPTON", updateorderInfo.Description.ToString()));
                queryParameter.Add(new KeyValuePair<string, string>("@MODIFIED_BY", updateorderInfo.User_ID));
                queryParameter.Add(new KeyValuePair<string, string>("@MODIFIED_DATE", utlitiy.BusinessUtlities.getCurrentDateTime.ToString()));
                result = DatabaseConnectionHandler.executeUpdateQuery(updateQueryString, queryParameter);
            }else if(updateorderInfo.Order_Status!=null)
            {
                string updateQueryString = "UPDATE SALES_ORDER SET ORDER_STATUS=@ORDER_STATUS,MODIFIED_BY=@MODIFIED_BY,MODIFIED_DATE=@MODIFIED_DATE WHERE ORDER_ID=@ORDER_ID";
                queryParameter.Add(new KeyValuePair<string, string>("@ORDER_ID", updateorderInfo.Order_Id.ToString()));
                queryParameter.Add(new KeyValuePair<string, string>("@ORDER_STATUS", updateorderInfo.Vendor_Id.ToString()));
                queryParameter.Add(new KeyValuePair<string, string>("@MODIFIED_BY", updateorderInfo.User_ID));
                queryParameter.Add(new KeyValuePair<string, string>("@MODIFIED_DATE", utlitiy.BusinessUtlities.getCurrentDateTime.ToString()));
                result = DatabaseConnectionHandler.executeUpdateQuery(updateQueryString, queryParameter);
            }
            return result;
        }
    }
}
