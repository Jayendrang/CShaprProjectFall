using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsignmentCompanyProject.com.app.dataobjects;
using ConsignmentCompanyProject.com.app.model;
namespace ConsignmentCompanyProject.com.app.business
{
    class CustomerMainWindowHandler
    {
        OrderDBProcessHandler customerOrderDataHandler = new OrderDBProcessHandler();

        public List<OrderProperties> getOrders(string vendorId,string orderStatus)
        {
            
            if (orderStatus==null) {
               return customerOrderDataHandler.getMultipleOrdersInfo(vendorId, null);
            }
            else
            {
                return customerOrderDataHandler.getMultipleOrdersInfo(vendorId, orderStatus);
            }
        }

        public bool cancelExistingOrder(OrderProperties cancelOrderProperties)
        {
            return customerOrderDataHandler.cancelOrder(cancelOrderProperties);
        }
        

    }
}
