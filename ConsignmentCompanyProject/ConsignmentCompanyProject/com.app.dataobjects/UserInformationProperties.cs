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
    class UserInformationProperties 
    {
        public string Name { get;  set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string EMail_Id { get; set; }
        public string User_Id { get;  set; }
        public string Password { get;  set; }
        public string Role { get; set; }
        public string Is_Vendor { get; set; }
        public string Status { get;set;}
        public string Vendor_Name { get; set; }
        public string Vendor_ID { get; set; }
        public string Created_By { get; set; }
        public string Created_date { get; set; }
        public string Modified_By { get; set; }
        public string Modified_Date { get; set; }

            
    }
}
