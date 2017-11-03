﻿using System;
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
            List<KeyValuePair<string,string>> tableQueryData = new List<KeyValuePair<string, string>>();

            var userinfo  = new UserInformationProperties();
            
            try
            {
                    string queryString = "SELECT NAME,CONTACT,ADDRESS,EMAIL_ID,USER_ID,PASSWORD,ROLE,IS_VENDOR,VENDOR_ID,VENDOR_NAME,STATUS FROM USER_TABLE WHERE USER_ID=@USERID AND PASSWORD=@PASSWORD";
                    tableQueryData.Add(new KeyValuePair<string, string>("@USERID", userCreds.Username));
                    tableQueryData.Add(new KeyValuePair<string, string>("@PASSWORD", userCreds.Password));
                    List<object> result =  DatabaseConnectionHandler.executeSelectDbQuery(queryString, tableQueryData,userinfo);
                    
                foreach(UserInformationProperties results in result)
                {   userinfo =(UserInformationProperties) results;
                    Console.WriteLine(" List Value : {0}", results);
                }
                    

            }
            catch (Exception ex) {Console.WriteLine("Login issue occured",ex.StackTrace); }

            return userinfo;
        }
    }
}
