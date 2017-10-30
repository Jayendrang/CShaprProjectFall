using System.Collections.Generic;
using ConsignmentCompanyProject.com.app.dataobjects;

namespace ConsignmentCompanyProject.com.app.interfaces
{
    /*
     * created by Jayendran Gurumoorthy
     * */

    interface IAppOrder<T> where T : OrderProperties
    {

        T getSingleOrderInfo(string orderId);
        List<List<T>> getMultipleOrdersInfo(string vendorInfo);
        T saveOrder(T saveorderInfo);
        string cancelOrder(T cancelorderInfo);
        T updateOrderStatus(T updateorderInfo);
        void addProdcutToCart(T productInfo);

    }
    interface IAppReturnOrder<T> where T : OrderReturnProperties
    {
        T getSingleReturnOrderInfo(string orderReturnId);
        List<T> getMultipleReturnOrderInfo(string vendorInfo);
        T saveOrderReturn(T saveOrderReturnInfo);
        string cancelOrderReturn(T cancelOrderReturnInfo);
        T updateOrderReturn(T updateOrderCancelInfo);
        void addProdcutToReturnCart(T productReturnInfo);

    }
}
