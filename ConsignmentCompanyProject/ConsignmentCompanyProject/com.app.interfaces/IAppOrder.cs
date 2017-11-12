﻿using System.Collections.Generic;
using ConsignmentCompanyProject.com.app.dataobjects;

namespace ConsignmentCompanyProject.com.app.interfaces
{
    /*
     * created by Jayendran Gurumoorthy
     * */

    interface IAppOrder<T> where T : OrderProperties
    {

       // T getSingleOrderInfo(string orderId);
        List<T> getMultipleOrdersInfo(string vendorInfo,string orderStatus);
        void submitOrder(List<T> saveorderInfo);
        bool cancelOrder(T cancelorderInfo);
        bool updateOrderStatus(T updateorderInfo);
        
    }
    interface IAppReturnOrder<T> where T : OrderReturnProperties
    {
       // T getSingleReturnOrderInfo(string orderReturnId);
        List<T> getMultipleReturnOrderInfo(T vendorInfo);
        bool submitOrderReturn(T saveOrderReturnInfo);
        bool cancelOrderReturn(T cancelOrderReturnInfo);
        bool updateOrderReturn(T updateOrderCancelInfo);
       // void addProdcutToReturnCart(T productReturnInfo);

    }
}
