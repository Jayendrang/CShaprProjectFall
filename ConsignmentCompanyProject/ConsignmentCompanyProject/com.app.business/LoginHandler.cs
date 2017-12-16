using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsignmentCompanyProject.com.app.dataobjects;
using ConsignmentCompanyProject.com.app.model;
namespace ConsignmentCompanyProject.com.app.business
{
    class LoginHandler
    {
        /*
    * created by Jayendran Gurumoorthy
    * */
        private UserDBProcessHandler userSessionHandler = new UserDBProcessHandler();

		public UserInformationProperties validateUserCredentials(LoginProperties loginInfo)
        {
            return userSessionHandler.validateUserLogin(loginInfo);
        }

    }
}
