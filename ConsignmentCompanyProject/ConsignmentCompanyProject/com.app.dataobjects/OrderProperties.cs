using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentCompanyProject.com.app.dataobjects
{
    /*
     * created by Jayendran Gurumoorthy
     * */

    // class holds order informatioin and used for order transaction data persistance
    class OrderProperties 
    {
        public int Order_Id { set; get; }
        public string Vendor_Id { set; get; }
        public string User_ID { set; get; }
        public string OrderDate { set; get; }
        public string Manufacturer_Name { set; get; }
        public string Product_Id { set; get; }
        public string Product_Name { set;  get; }
        public string Product_Type { set; get; }
        public int Count { set; get; }
        public double Price_Per_Unit { set; get; }
        public double Paid_Amount { set; get; }
        public double Total_Price { set; get; }
        public double Balance_Amount { set; get;}
        public string Discount_Rate { set; get; }
        public string Order_Status { set; get;}
        public string Description { set; get;}
        public List<OrderProperties> Order_Details { set; get; }

    }
}
