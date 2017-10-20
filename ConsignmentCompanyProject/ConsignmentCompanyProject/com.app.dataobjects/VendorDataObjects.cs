using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentCompanyProject.com.app.dataobjects
{
    class VendorDataObjects : DiscountDataObjects
    {
        public string vendorName { get; set; }
        public string vendorId { get; set; }
        public string vendorAddress { get;set;}
        public string vendorContact { get; set;}
        public string vendorMailId { get; set; }
        public string vendorStatus { get; set; }
        public double balanceAmount { get; set; }


    }
}
