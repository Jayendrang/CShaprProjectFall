using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentCompanyProject.com.app.dataobjects
{

    class VendorProperties : DiscountProperties
    {
        public string VendorName { get; set; }
        public string VendorId { get; set; }
        public string VendorAddress { get;set;}
        public string VendorContact { get; set;}
        public string VendorMailId { get; set; }
        public string VendorStatus { get; set; }
        public double BalanceAmount { get; set; }

    }
}
