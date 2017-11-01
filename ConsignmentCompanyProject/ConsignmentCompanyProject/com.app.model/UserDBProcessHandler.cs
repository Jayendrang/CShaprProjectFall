using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsignmentCompanyProject.com.app.dataobjects;
using ConsignmentCompanyProject.com.app.model;
using System.Data.SqlClient;
namespace ConsignmentCompanyProject.com.app.model
{
    class UserDBProcessHandler
    {

        public UserInformationProperties validateUserLogin(LoginProperties userCreds)
        {
            List<KeyValuePair<String,String>> tableQueryData = new List<KeyValuePair<String, String>>();
            UserInformationProperties userInfo = new UserInformationProperties();

            try
            {
                    string queryString = "SELECT * FROM USER_TABLE WHERE USER_ID=@USERID AND PASSWORD=@PASSWORD";
                    tableQueryData.Add(new KeyValuePair<string, string>("@USERID", userCreds.Username));
                    tableQueryData.Add(new KeyValuePair<string, string>("@PASSWORD", userCreds.Password));
                SqlDataReader reader = DatabaseConnectionHandler.executeSelectDbQuery(queryString, tableQueryData);
                do
                {
                    int k = 0;
                    Console.WriteLine("{0}", reader.GetValue(k));
                    ++k;
                } while (reader.HasRows);        
            }
            catch (Exception ex) {Console.WriteLine("Login issue occured",ex.StackTrace); }

            return userInfo;

        }
    }
}
