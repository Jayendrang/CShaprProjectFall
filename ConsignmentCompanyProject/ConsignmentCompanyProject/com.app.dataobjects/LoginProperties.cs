using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentCompanyProject.com.app.dataobjects
{
    class LoginProperties 
    {
       
        public string Username { get; set; }
        public string Password { get; set; }

        public UserInformationProperties getUserData { protected set; get; }
         
    }
}
