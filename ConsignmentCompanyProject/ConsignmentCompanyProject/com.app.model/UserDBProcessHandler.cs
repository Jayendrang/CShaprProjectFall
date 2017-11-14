using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsignmentCompanyProject.com.app.dataobjects;
using ConsignmentCompanyProject.com.app.model;
using System.Data.SqlClient;
using System.Data;
using ConsignmentCompanyProject.com.app.interfaces;

namespace ConsignmentCompanyProject.com.app.model
{  /*
    Created By Jayendran Gurumoorthy
    **/


    class UserDBProcessHandler :IAppUser<UserInformationProperties> 
    {
        // Adding new user profile in database 
        public bool addUser(UserInformationProperties userData,string currentUserId)
        {
            bool result = false;
            string insertQueryString = "INSERT INTO USER_TABLE(NAME,CONTACT,ADDRESS,EMAIL_ID,USER_ID,PASSWORD,ROLE,IS_VENDOR,VENDOR_ID,VENDOR_NAME,STATUS,CREATED_BY,CREATED_DATE,MODIFIED_BY,MODIFIED_DATE) VALUES(@NAME,@CONTACT,@ADDRESS,@EMAIL_ID,@USER_ID,@PASSWORD,@ROLE,@IS_VENDOR,@VENDOR_ID,@VENDOR_NAME,@STATUS,@CREATED_BY,@CREATED_DATE,@MODIFIED_BY,@MODIFIED_DATE)";
            List<KeyValuePair<string, string>> tableQueryData = new List<KeyValuePair<string, string>>();
            try { 
            tableQueryData.Add(new KeyValuePair<string, string>("@NAME",userData.Name));
            tableQueryData.Add(new KeyValuePair<string, string>("@CONTACT", userData.Contact));
            tableQueryData.Add(new KeyValuePair<string, string>("@ADDRESS", userData.Address));
            tableQueryData.Add(new KeyValuePair<string, string>("@EMAIL_ID", userData.EMail_Id));
            tableQueryData.Add(new KeyValuePair<string, string>("@USER_ID", userData.User_Id));
            tableQueryData.Add(new KeyValuePair<string, string>("@PASSWORD", userData.Password));
            tableQueryData.Add(new KeyValuePair<string, string>("@ROLE", userData.Role));
            tableQueryData.Add(new KeyValuePair<string, string>("@IS_VENDOR", userData.Is_Vendor));
            tableQueryData.Add(new KeyValuePair<string, string>("@VENDOR_ID", userData.Vendor_ID));
            tableQueryData.Add(new KeyValuePair<string, string>("@VENDOR_NAME", userData.Vendor_Name));
            tableQueryData.Add(new KeyValuePair<string, string>("@STATUS", userData.Status));
            tableQueryData.Add(new KeyValuePair<string, string>("@CREATED_BY", currentUserId));
            tableQueryData.Add(new KeyValuePair<string, string>("@CREATED_DATE", com.app.utlitiy.BusinessUtlities.getCurrentDateTime));
            tableQueryData.Add(new KeyValuePair<string, string>("@MODIFIED_BY", currentUserId));
            tableQueryData.Add(new KeyValuePair<string, string>("@MODIFIED_DATE", com.app.utlitiy.BusinessUtlities.getCurrentDateTime));
            result = DatabaseConnectionHandler.executeInsertDbQuery(insertQueryString, tableQueryData);
            }catch(Exception ex) { Console.WriteLine(ex.StackTrace); }
             
            return result;
        }

        //Retrieve multiple user information from database
        public List<UserInformationProperties> getMultipleUserInfo(string userStatus)
        {
            DataSet dataset = new DataSet();
            List<UserInformationProperties> usersList = new List<UserInformationProperties>();
            string selectQueryString = null;
            if (userStatus.Equals("ALL")) {
                 selectQueryString = "SELECT NAME,CONTACT,ADDRESS,EMAIL_ID,USER_ID,ROLE,IS_VENDOR,VENDOR_ID,VENDOR_NAME,STATUS,CREATED_BY,CREATED_DATE,MODIFIED_BY,MODIFIED_DATE FROM USER_TABLE";
                dataset = DatabaseConnectionHandler.executeSelectQuery(selectQueryString, null);

            }
            else {
                selectQueryString = "SELECT NAME,CONTACT,ADDRESS,EMAIL_ID,ROLE,USER_ID,IS_VENDOR,VENDOR_ID,VENDOR_NAME,STATUS,CREATED_BY,CREATED_DATE,MODIFIED_BY,MODIFIED_DATE FROM USER_TABLE WHERE STATUS=@STATUS";
                List<KeyValuePair<string, string>> tableQueryData = new List<KeyValuePair<string, string>>();
                tableQueryData.Add(new KeyValuePair<string, string>("@STATUS", userStatus));
                dataset = DatabaseConnectionHandler.executeSelectQuery(selectQueryString, tableQueryData);

            }

            if (dataset != null)
            {
                foreach(DataRow row in dataset.Tables[0].Rows)
                {
                    UserInformationProperties userinformation = new UserInformationProperties();
                    userinformation.Name = row["Name"].ToString();
                    userinformation.Contact = row["Contact"].ToString();
                    userinformation.Address = row["Address"].ToString();
                    userinformation.EMail_Id = row["Email_id"].ToString();
                    userinformation.User_Id = row["User_Id"].ToString();
                    userinformation.Role = row["Role"].ToString();
                    userinformation.Is_Vendor = row["Is_Vendor"].ToString();
                    userinformation.Vendor_ID = row["Vendor_Id"].ToString();
                    userinformation.Vendor_Name = row["Vendor_Name"].ToString();
                    userinformation.Status = row["Status"].ToString();
                    userinformation.Created_By = row["Created_By"].ToString();
                    userinformation.Created_date = row["Created_date"].ToString();
                    userinformation.Modified_By = row["Modified_By"].ToString();
                    userinformation.Modified_Date = row["Modified_Date"].ToString();

                    usersList.Add(userinformation);
                }

            }
            return usersList;
        }

        //Get single user profile details
        public UserInformationProperties getSingleUserInfo(string userId)
        {
            DataSet dataset = new DataSet();
            UserInformationProperties userinformation = new UserInformationProperties();
            string selectQueryString = "SELECT NAME,CONTACT,ADDRESS,EMAIL_ID,USER_ID,ROLE,IS_VENDOR,VENDOR_ID,VENDOR_NAME,STATUS,CREATED_BY,CREATED_DATE,MODIFIED_BY,MODIFIED_DATE FROM USER_TABLE WHERE USER_ID=@USER_ID";
            List<KeyValuePair<string, string>> tableQueryData = new List<KeyValuePair<string, string>>();
            tableQueryData.Add(new KeyValuePair<string, string>("@USER_ID", userId));
            dataset = DatabaseConnectionHandler.executeSelectQuery(selectQueryString, tableQueryData);
            if (dataset != null)
            {
                foreach (DataRow row in dataset.Tables[0].Rows)
                {
                    userinformation.Name = row["Name"].ToString();
                    userinformation.Contact = row["Contact"].ToString();
                    userinformation.Address = row["Address"].ToString();
                    userinformation.EMail_Id = row["Email_id"].ToString();
                    userinformation.User_Id = row["User_Id"].ToString();
                    userinformation.Role = row["Role"].ToString();
                    userinformation.Is_Vendor = row["Is_Vendor"].ToString();
                    userinformation.Vendor_ID = row["Vendor_Id"].ToString();
                    userinformation.Vendor_Name = row["Vendor_Name"].ToString();
                    userinformation.Status = row["Status"].ToString();
                    userinformation.Created_By = row["Created_By"].ToString();
                    userinformation.Created_date = row["Created_date"].ToString();
                    userinformation.Modified_By = row["Modified_By"].ToString();
                    userinformation.Modified_Date = row["Modified_Date"].ToString();
                }

            }
            return userinformation;
        }

        //Modify the single user profile
        public bool modifyUser(UserInformationProperties userInfo)
        {
            string updateQueryString = null;
            bool result = false;
            List<KeyValuePair<string, string>> tableQueryData = new List<KeyValuePair<string, string>>();
            
            if ((userInfo.Address != null) && (userInfo.Contact != null) && (userInfo.EMail_Id != null))
            {
                updateQueryString = "UPDATE USER_TABLE SET ADDRESS=@ADDRESS,CONTACT=@CONTACT,EMAIL_ID=@EMAIL_ID WHERE USER_ID=@USER_ID;";
                tableQueryData.Add(new KeyValuePair<string, string>("@ADDRESS",userInfo.Address));
                tableQueryData.Add(new KeyValuePair<string, string>("@CONTACT", userInfo.Contact));
                tableQueryData.Add(new KeyValuePair<string, string>("@EMAIL_ID", userInfo.EMail_Id));
                tableQueryData.Add(new KeyValuePair<string, string>("@USER_ID", userInfo.User_Id));
                result = DatabaseConnectionHandler.executeUpdateQuery(updateQueryString, tableQueryData);
            }
            return result;
        }

        //Update the user profile status as deactivate to remove the user from system
        public bool removeUser(string userId)
        {
            string updateQueryString = null;
            bool result = false;
                List<KeyValuePair<string, string>> tableQueryData = new List<KeyValuePair<string, string>>();

                updateQueryString = "UPDATE USER_TABLE SET STATUS='DEACTIVATED' WHERE USER_ID=@USER_ID;";
                tableQueryData.Add(new KeyValuePair<string, string>("@USER_ID", userId));
                result = DatabaseConnectionHandler.executeUpdateQuery(updateQueryString, tableQueryData);
            return result;
        }

        //Method used to remove multiple users after deactivating(removing) vendor from vendor list
        public bool removeMultipleVendorUsers(string vendorID)
        {
            string updateQueryString = null;
            bool result = false;
            List<KeyValuePair<string, string>> tableQueryData = new List<KeyValuePair<string, string>>();

            updateQueryString = "UPDATE USER_TABLE SET STATUS='DEACTIVATED' WHERE VENDOR_ID=@VENDOR_ID;";
            tableQueryData.Add(new KeyValuePair<string, string>("@VENDOR_ID", vendorID));
            result = DatabaseConnectionHandler.executeUpdateQuery(updateQueryString, tableQueryData);
            return result;
        }

        //Validate user login with database
        public UserInformationProperties validateUserLogin(LoginProperties userCreds)
        {
            DataSet reader;
            List<KeyValuePair<string,string>> tableQueryData = new List<KeyValuePair<string, string>>();

            var userinfo  = new UserInformationProperties();
            try
            {
                    string queryString = "SELECT NAME,CONTACT,ADDRESS,EMAIL_ID,USER_ID,PASSWORD,ROLE,IS_VENDOR,VENDOR_ID,VENDOR_NAME,STATUS FROM USER_TABLE WHERE USER_ID=@USERID AND PASSWORD=@PASSWORD AND STATUS='ACTIVE'";
                    tableQueryData.Add(new KeyValuePair<string, string>("@USERID", userCreds.Username));
                    tableQueryData.Add(new KeyValuePair<string, string>("@PASSWORD", userCreds.Password));
                    
                    reader =  DatabaseConnectionHandler.executeSelectQuery(queryString, tableQueryData);
                


            }
            catch (Exception ex) {Console.WriteLine("Login issue occured",ex.Message); }

            return userinfo;
           }
    }

}
