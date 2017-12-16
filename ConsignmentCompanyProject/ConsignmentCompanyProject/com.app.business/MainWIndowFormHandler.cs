using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsignmentCompanyProject.com.app.dataobjects;
using ConsignmentCompanyProject.com.app.model;
namespace ConsignmentCompanyProject.com.app.business
{
    class MainWIndowFormHandler
    {
   /*
    * created by Jayendran Gurumoorthy
    * */
        private OrderDBProcessHandler orderProcessHandler = new OrderDBProcessHandler();
        private OrderRetrunDBProcessHandler orderReturnHandler = new OrderRetrunDBProcessHandler();
        public List<OrderProperties> getOrders(string orderStatus)
        {
           
           return orderProcessHandler.getMultipleOrdersInfo(null, orderStatus);
          
        }

        public List<OrderReturnProperties> getReturnOrders(string status)
        {
            return orderReturnHandler.getMultipleReturnOrderInfo(status);

        }
 
    }
}
