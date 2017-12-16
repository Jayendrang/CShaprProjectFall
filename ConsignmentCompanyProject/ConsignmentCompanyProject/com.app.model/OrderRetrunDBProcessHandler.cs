using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ConsignmentCompanyProject.com.app.interfaces;
using ConsignmentCompanyProject.com.app.dataobjects;
namespace ConsignmentCompanyProject.com.app.model
{
    /**
     *  CREATED BY ANKEET PATNAIK
     * */
    class OrderRetrunDBProcessHandler : IAppReturnOrder<OrderReturnProperties>
    {
      
        //CANCEL THE ACTIVE ORDER
        public bool cancelOrderReturn(OrderReturnProperties cancelOrderReturnInfo)
        {
            string updateQueryString = "UPDATE RETURN_ORDER SET RETURN_STATUS='CANCELLED' WHERE RETURN_ORDER_ID=@RETURN_ORDER_ID";
            List<KeyValuePair<string, string>> tableQueryData = new List<KeyValuePair<string, string>>();
            bool result = false;
                tableQueryData.Add(new KeyValuePair<string, string>("@RETURN_ORDER_ID", cancelOrderReturnInfo.Return_Order_Id));
                result = DatabaseConnectionHandler.executeUpdateQuery(updateQueryString, tableQueryData);

            return result ;
        }

        //RETRIEVE MULTIPLE ORDER BASED ON STATUS
        public List<OrderReturnProperties> getMultipleReturnOrderInfo(string status)
        {
            DataSet dataset = new DataSet();
            String selectQueryString = "SELECT RETURN_ORDER_ID,ORDER_ID,VENDOR_ID,USER_ID,PRODUCT_ID,PRODUCT_TYPE,COUNT,PRICE_PER_UNIT,RETURN_DESCRIPTION,RETURN_STATUS,CREATED_BY FROM RETURN_ORDER WHERE RETURN_STATUS=@RETURN_STATUS;";
            List<OrderReturnProperties> orderReturnsList = new List<OrderReturnProperties>();
            List<KeyValuePair<string, string>> queryParameter = new List<KeyValuePair<string, string>>();
            queryParameter.Add(new KeyValuePair<string, string>("@RETURN_STATUS", status));
            dataset = DatabaseConnectionHandler.executeSelectQuery(selectQueryString, queryParameter);

            if (dataset != null)
            {
                foreach(DataRow row in dataset.Tables[0].Rows)
                {
                    OrderReturnProperties returnOrders = new OrderReturnProperties();
                    returnOrders.Return_Order_Id = row["Return_Order_ID"].ToString();
                    returnOrders.Order_Id = row["Order_Id"].ToString();
                    returnOrders.Vendor_Id = row["Vendor_Id"].ToString();
                    returnOrders.User_Id = row["User_Id"].ToString();
                    returnOrders.Product_Id = row["Product_Id"].ToString();
                    returnOrders.Product_Type = row["Product_Type"].ToString();
                    returnOrders.Count = Convert.ToInt16(row["Count"].ToString());
                    returnOrders.Price_Per_Unit = Convert.ToDouble(row["Price_Per_Unit"].ToString());
                    returnOrders.Return_Description = row["Return_Description"].ToString();
                    returnOrders.Return_Status = row["Return_status"].ToString();
                    returnOrders.Created_By = row["Created_By"].ToString();
                    orderReturnsList.Add(returnOrders);
                }
            }
            return orderReturnsList;
        }

     
        //SUBMIT THE ORDER 
        public bool submitOrderReturn(OrderReturnProperties saveOrderReturnInfo)
        {
            string insertQueryString = "INSERT INTO RETURN_ORDER(RETURN_ORDER_ID,ORDER_ID,VENDOR_ID,USER_ID,PRODUCT_ID,PRODUCT_TYPE,COUNT,PRICE_PER_UNIT,RETURN_DESCRIPTION,RETURN_STATUS,CREATED_BY,CREATED_DATE,MODIFIED_BY,MODIFIED_DATE) VALUES(@RETURN_ORDER_ID,@ORDER_ID,@VENDOR_ID,@USER_ID,@PRODUCT_ID,@PRODUCT_TYPE,@COUNT,@PRICE_PER_UNIT,@RETURN_DESCRIPTION,@RETURN_STATUS,@CREATED_BY,@CREATED_DATE,@MODIFIED_BY,@MODIFIED_DATE)";
            List<KeyValuePair<string, string>> queryParameter = new List<KeyValuePair<string, string>>();
            queryParameter.Add(new KeyValuePair<string, string>("@RETURN_ORDER_ID",saveOrderReturnInfo.Return_Order_Id));
            queryParameter.Add(new KeyValuePair<string, string>("@ORDER_ID",saveOrderReturnInfo.Order_Id));
            queryParameter.Add(new KeyValuePair<string, string>("@USER_ID",saveOrderReturnInfo.User_Id));
            queryParameter.Add(new KeyValuePair<string, string>("@VENDOR_ID", saveOrderReturnInfo.Vendor_Id));
            queryParameter.Add(new KeyValuePair<string, string>("@PRODUCT_ID",saveOrderReturnInfo.Product_Id));
            queryParameter.Add(new KeyValuePair<string, string>("@PRODUCT_TYPE",saveOrderReturnInfo.Product_Type));
            queryParameter.Add(new KeyValuePair<string, string>("@COUNT",saveOrderReturnInfo.Count.ToString()));
            queryParameter.Add(new KeyValuePair<string, string>("@PRICE_PER_UNIT",saveOrderReturnInfo.Price_Per_Unit.ToString()));
            queryParameter.Add(new KeyValuePair<string, string>("@RETURN_DESCRIPTION",saveOrderReturnInfo.Return_Description));
            queryParameter.Add(new KeyValuePair<string, string>("@RETURN_STATUS",saveOrderReturnInfo.Return_Status));
            queryParameter.Add(new KeyValuePair<string, string>("@CREATED_BY",saveOrderReturnInfo.Created_By));
            queryParameter.Add(new KeyValuePair<string, string>("@CREATED_DATE",com.app.utlitiy.BusinessUtlities.getCurrentDateTime));
            queryParameter.Add(new KeyValuePair<string, string>("@MODIFIED_BY",saveOrderReturnInfo.Created_By));
            queryParameter.Add(new KeyValuePair<string, string>("@MODIFIED_DATE",com.app.utlitiy.BusinessUtlities.getCurrentDateTime));
            return DatabaseConnectionHandler.executeInsertDbQuery(insertQueryString, queryParameter);
        }

        //UPDATE THE ORDER  RETURN
        public bool updateOrderReturn(OrderReturnProperties updateOrderStatusInfo, string userInfo)
        {
            string updateQueryString = "UPDATE RETURN_ORDER SET RETURN_STATUS=@STATUS,RETURN_DESCRITPION=@RETURN_DESCRIPTION,MODIFIED_BY=@MODIFIED_BY,MODIFIED_DATE=@MODIFIED_DATE WHERE RETURN_ORDER_ID=@RETURN_ORDER_ID";
            List<KeyValuePair<string, string>> tableQueryData = new List<KeyValuePair<string, string>>();
            bool result = false;
            tableQueryData.Add(new KeyValuePair<string, string>("@RETURN_ORDER_ID", updateOrderStatusInfo.Return_Order_Id));
            tableQueryData.Add(new KeyValuePair<string, string>("@STATUS", updateOrderStatusInfo.Return_Status));
            tableQueryData.Add(new KeyValuePair<string, string>("@RETURN_DESCRIPTION", updateOrderStatusInfo.Return_Description));
            tableQueryData.Add(new KeyValuePair<string, string>("@MODIFIED_BY", updateOrderStatusInfo.User_Id));
            tableQueryData.Add(new KeyValuePair<string, string>("@MODIFIED_DATE", com.app.utlitiy.BusinessUtlities.getCurrentDateTime));
            result = DatabaseConnectionHandler.executeUpdateQuery(updateQueryString, tableQueryData);

            return result;
        }
    }
}
