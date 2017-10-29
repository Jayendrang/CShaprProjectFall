using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsignmentCompanyProject.com.app.dataobjects;

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


        public bool validateUser(string username, string password)
        {
            try
            {
                //tempstubvariables
                tempString[0, 0] = "Jayendran";
                tempString[0, 1] = "password";
                tempString[1, 0] = "Jubril";
                tempString[1, 1] = "password";
                tempString[2, 0] = "Ankit";
                tempString[2, 1] = "password";

                for (int i = 0; i < tempString.Length; i++)
                {
                    if ((tempString[i, 0].Equals(username)) && (tempString[i, 1].Equals(password)))
                    {
                        ManagerMainWindow managermainwindow = new ManagerMainWindow();
                        managermainwindow.Visible = true;
                        managermainwindow.Enabled = true;
                        managermainwindow.loadFormData(username);
                        return true;
                    }

                }
            }
            catch (Exception) { }
                return false;
            
            }
    }
}
