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
        public int OrderId { set; get; }
        public string OrderVendorId { set; get; }
        public string OrderVendorName { set; get;}
        public string OrderCreatedBy { set; get; }
        public string OrderDate { set; get; }

        public List<ProductProperties> ProductDetails { set; get; }

        public double PaidAmount { set; get; }
        public double TotalOrderAmount { set; get; }
        public double BalanceAmount { set; get;}
        public string DiscountRate { set; get; }
        public string OrderStatus { set; get;}
        public string OrderDescription { set; get;}
        
    }
}
