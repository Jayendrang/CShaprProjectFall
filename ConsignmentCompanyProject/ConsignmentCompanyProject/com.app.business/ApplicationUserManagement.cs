using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsignmentCompanyProject.com.app.dataobjects;
using ConsignmentCompanyProject.com.app.model;
namespace ConsignmentCompanyProject.com.app.manager
{
    class LoginHandler
    {
        
        public LoginHandler(LoginProperties logindata)
        {
            this.logindata = logindata;

        }

        private string[,] tempString = new string[3,2];
        private LoginProperties logindata;
        public static UserInformationProperties userData;

        public bool validateUser()
        {
            bool result=false;
            try
            {
                //tempstubvariables
                UserDBProcessHandler dbProcess = new UserDBProcessHandler();
                userData = dbProcess.validateUserLogin(logindata);
                result = userData == null ? false : true;
            }
            catch (Exception) { }
                return result;
            
            }

    }
}
