using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentCompanyProject.com.app.dataobjects
{
    //This class holds vendor information with their respective discount properties
    class VendorProperties : DiscountProperties
    {
        public string VendorName { get; set; }
        public string VendorId { get; set; }
        public string VendorAddress { get;set;}
        public string VendorContact { get; set;}
        public string VendorMailId { get; set; }
        public string VendorStatus { get; set; }
        public double VendorPaidAmount { get; set;}
        public double BalanceAmount {get; set;}


    }
}
