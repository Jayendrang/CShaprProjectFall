using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentCompanyProject.com.app.dataobjects
{
    //the class holds user table data objects
    class UserInformationProperties : VendorProperties
    {
        public string Name { get; protected set; }
        public string Contact { get; protected set; }
        public string Address { get; protected set; }
        public string UserId { get; protected set; }
        public string Password { get; protected set; }
        public string Role { get; protected set; }
        public bool IsVendor { get; protected set; }
        public string UserStatus { get;protected set;}
            
    }
}
