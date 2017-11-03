using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsignmentCompanyProject.com.app.dataobjects;
using ConsignmentCompanyProject.com.app.model;
namespace ConsignmentCompanyProject.com.app.business
{
    class UserInformationHandler
    {
        
        public static UserInformationProperties userSessionData = new UserInformationProperties();

        public static UserInformationProperties validateUser(LoginProperties loginData)
        {
            try
            {
                //tempstubvariables
                UserDBProcessHandler dbProcess = new UserDBProcessHandler();
                userSessionData = dbProcess.validateUserLogin(loginData);
                if (userSessionData != null)
                {
                   if((loginData.Username.Equals(userSessionData.User_Id)) && (loginData.Password.Equals(userSessionData.Password)))
                    {
                        return userSessionData;
                    }
                    else
                    {
                        return userSessionData = null; 
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.StackTrace);
            }

            return userSessionData;
        }


    }
}
