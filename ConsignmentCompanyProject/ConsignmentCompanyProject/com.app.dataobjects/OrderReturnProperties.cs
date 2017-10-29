using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentCompanyProject.com.app.dataobjects
{
    class OrderReturnProperties
    {
        public string OrderReturnId { set; get; }
        public int OrderId { set; get; }
        public int OrderReturnDate { set; get; }
        public string OrderReturnVendorId { set; get; }
        public string OrderReturnVendorName { set; get; }
        public string OrderReturnCreatedBy { set; get; }
        public string OrderReturnProductId { set; get; }
        public string OrderReturnProductName { set; get; }
        public string OrderReturnProductType { set; get; }
        public int OrderReturnCount { set; get; }
        public double OrderReturnPricePerUnit { set; get; }
        public string OrderReturnDescription { set; get; }
        public string OrderReturnStatus { set; get; }
    }
}
