using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsignmentCompanyProject.com.app.interfaces;
using ConsignmentCompanyProject.com.app.dataobjects;
namespace ConsignmentCompanyProject.com.app.business
{
    class OrderHandler : IAppOrder<OrderProperties>
    {
        public void addProdcutToCart(OrderProperties productInfo)
        {
            throw new NotImplementedException();
        }

        public string cancelOrder(OrderProperties cancelorderInfo)
        {
            throw new NotImplementedException();
        }

        public List<List<OrderProperties>> getMultipleOrdersInfo(string vendorInfo)
        {
            throw new NotImplementedException();
        }

        public OrderProperties getSingleOrderInfo(string orderId)
        {
            throw new NotImplementedException();
        }

        public OrderProperties saveOrder(OrderProperties saveorderInfo)
        {
            throw new NotImplementedException();
        }

        public OrderProperties updateOrderStatus(OrderProperties updateorderInfo)
        {
            throw new NotImplementedException();
        }
    }
}
