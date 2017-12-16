using System;
using System.Collections.Generic;
using System.Linq;
using ConsignmentCompanyProject.com.app.dataobjects;
using ConsignmentCompanyProject.com.app.model;
namespace ConsignmentCompanyProject.com.app.business
{
    /*
     * Created by Ankeet patnaik
     *  */
    class OrderReturnHandler 
    {
        private static Dictionary<string, List<OrderProperties>> processedOrderDictionary = new Dictionary<string, List<OrderProperties>>();
        private static OrderDBProcessHandler orderDbProcessor = new OrderDBProcessHandler();
        private static List<OrderGridFields> gridRowDataList = new List<OrderGridFields>();
        private OrderRetrunDBProcessHandler returnOrderDbProcessor = new OrderRetrunDBProcessHandler();
        public OrderReturnHandler()
        {
            
        }
        private void getProcessedOrder(string vendorInfo, string orderStatus)
        {
            List<OrderProperties> orderList = orderDbProcessor.getMultipleOrdersInfo(vendorInfo, orderStatus);
            foreach ( OrderProperties props in orderList)
            {
                if (processedOrderDictionary.Keys.Contains(props.Order_Id))
                {
                    List<OrderProperties> existingPropertiesInDictionary;
                    processedOrderDictionary.TryGetValue(props.Order_Id, out existingPropertiesInDictionary);
                    existingPropertiesInDictionary.Add(props);
                    processedOrderDictionary.Remove(props.Order_Id);
                    processedOrderDictionary.Add(props.Order_Id, existingPropertiesInDictionary);
                }else
                {
                    List<OrderProperties> newOrderProperties = new List<OrderProperties>();
                    newOrderProperties.Add(props);
                    processedOrderDictionary.Add(props.Order_Id, newOrderProperties);

                    OrderGridFields gridData = new OrderGridFields();
                    gridData.orderId = props.Order_Id;
                    gridData.balance = props.Balance_Amount.ToString("c");
                    gridData.date = props.OrderDate;
                    gridData.total = props.Total_Price.ToString("c");
                    gridRowDataList.Add(gridData);
                }
            }
            
        }
        
        public void getCustomerData(string vendorId)
        {
            //***************testing
            getProcessedOrder(vendorId, "COMPLETED");
        }
        public List<OrderGridFields> getGridData()
        {
            return gridRowDataList;
        }
        public List<OrderProperties> getOrderItinerary(string orderId)
        {
            List<OrderProperties> orderDetails;
            processedOrderDictionary.TryGetValue(orderId, out orderDetails);
            if (orderDetails != null)
            {
                return orderDetails;
            }

            return null;
        }
         
        public string generateOrderReturnNumber()
        {
            return com.app.utlitiy.BusinessUtlities.getNewUniqueID("RETURN_ORDER", "RETURN_ORDER_ID");
        }

        public bool submitOrderReturn(OrderReturnProperties returnOrder)
        {
            return returnOrderDbProcessor.submitOrderReturn(returnOrder);
        }
        
    }
    public class OrderGridFields
    {

       public  string orderId { get; set; }
       public  string date { get;set;}
       public string balance { get; set; }
        public string total { get; set; }
    }
}
