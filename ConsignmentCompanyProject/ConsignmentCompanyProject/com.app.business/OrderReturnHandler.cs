using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsignmentCompanyProject.com.app.dataobjects;
using ConsignmentCompanyProject.com.app.interfaces;
namespace ConsignmentCompanyProject.com.app.business
{
    class OrderReturnHandler : IAppReturnOrder<OrderReturnProperties>
    {
        public void addProdcutToReturnCart(OrderReturnProperties productReturnInfo)
        {
            throw new NotImplementedException();
        }

        public string cancelOrderReturn(OrderReturnProperties cancelOrderReturnInfo)
        {
            throw new NotImplementedException();
        }

        public List<OrderReturnProperties> getMultipleReturnOrderInfo(string vendorInfo)
        {
            throw new NotImplementedException();
        }

        public OrderReturnProperties getSingleReturnOrderInfo(string orderReturnId)
        {
            throw new NotImplementedException();
        }

        public OrderReturnProperties saveOrderReturn(OrderReturnProperties saveOrderReturnInfo)
        {
            throw new NotImplementedException();
        }

        public OrderReturnProperties updateOrderReturn(OrderReturnProperties updateOrderCancelInfo)
        {
            throw new NotImplementedException();
        }
    }
}
