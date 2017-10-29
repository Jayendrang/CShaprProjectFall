using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentCompanyProject.com.app.dataobjects
{
    class OrderProperties
    {
        public int OrderId { set; get; }
        public string OrderVendorId { set; get; }
        public string OrderVendorName { set; get;}
        public string OrderCreatedBy { set; get; }
        public string OrderDate { set; get; }
        public string OrderProductId { set; get; }
        public string OrderProductName { set; get; }
        public string OrderProductType { set;get;}
        public int OrderProductCount { set; get; }
        public double PricePerUnit { set; get; }
        public double TotalProductAmount { set; get; }
        public double TotalOrderAmount { set; get; }
        public double BalanceAmount { set; get;}
        public string DiscountRate { set; get; }
        public string OrderStatus { set; get;}
        public string OrderDescription { set; get;}
        
    }
}
