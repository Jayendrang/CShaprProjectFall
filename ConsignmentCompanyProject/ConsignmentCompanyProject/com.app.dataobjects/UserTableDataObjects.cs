using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentCompanyProject.com.app.dataobjects
{
    //the class holds user table data objects
    class UserTableDataObjects : VendorDataObjects
    {
        public string name { get; set; }
        public string contact { get; set; }
        public string address { get; set; }
        public string userId { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public bool isVendor { get; set; }
        public string userStatus { get;set;}

        

        
        
    }
}
