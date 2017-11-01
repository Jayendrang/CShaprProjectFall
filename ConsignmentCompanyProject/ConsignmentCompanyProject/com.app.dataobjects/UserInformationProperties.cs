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

    //this class holds logged in user information for mainitaining user session
    class UserInformationProperties : VendorProperties
    {
        public string Name { get;  set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string UserMailId { get; set; }
        public string UserId { get;  set; }
        public string Password { get;  set; }
        public string Role { get; set; }
        public bool IsVendor { get; set; }
        public string UserStatus { get;set;}
        

            
    }
}
