using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ConsignmentCompanyProject.com.app.interfaces;
using ConsignmentCompanyProject.com.app.dataobjects;
namespace ConsignmentCompanyProject.com.app.model
{
    /*
     * Created by Jubril Bakare
     * */
    class CustomerDBProcessHandler : IAppCustomer<CustomerProperties>
    {
        //Add new vendor in Vendor table
        public bool addCustomerInfo(CustomerProperties newVendorInfo, string userInfo)
        {
            bool result = false;
            string insertQueryString = "INSERT INTO VENDOR(VENDOR_NAME,VENDOR_ID,VENDOR_ADDRESS,VENDOR_CONTACT,VENDOR_EMAIL_ID,VENDOR_STATUS,VENDOR_DISCOUNT_ID,VENDOR_BALANCE_AMOUNT,CREATED_BY,CREATED_DATE,MODIFIED_BY,MODIFIED_DATE) VALUES (@VENDOR_NAME,@VENDOR_ID,@VENDOR_ADDRESS,@VENDOR_CONTACT,@VENDOR_EMAIL_ID,@VENDOR_STATUS,@VENDOR_DISCOUNT_ID,@VENDOR_BALANCE_AMOUNT,@CREATED_BY,@CREATED_DATE,@MODIFIED_BY,@MODIFIED_DATE)";
                       
            List<KeyValuePair<string, string>> tableParameter = new List<KeyValuePair<string, string>>();
            tableParameter.Add(new KeyValuePair<string, string>("@VENDOR_NAME",newVendorInfo.Vendor_Name));
            tableParameter.Add(new KeyValuePair<string, string>("@VENDOR_ID", newVendorInfo.Vendor_Id));
            tableParameter.Add(new KeyValuePair<string, string>("@VENDOR_ADDRESS", newVendorInfo.Vendor_Address));
            tableParameter.Add(new KeyValuePair<string, string>("@VENDOR_CONTACT", newVendorInfo.Vendor_Contact));
            tableParameter.Add(new KeyValuePair<string, string>("@VENDOR_EMAIL_ID", newVendorInfo.Vendor_EMail_Id));
            tableParameter.Add(new KeyValuePair<string, string>("@VENDOR_STATUS", newVendorInfo.Vendor_Status));
            tableParameter.Add(new KeyValuePair<string, string>("@VENDOR_DISCOUNT_ID", newVendorInfo.Vendor_Discount_ID));
            tableParameter.Add(new KeyValuePair<string, string>("@VENDOR_BALANCE_AMOUNT", newVendorInfo.Vendor_Balance_Amount.ToString()));
            tableParameter.Add(new KeyValuePair<string, string>("@CREATED_BY", userInfo));
            tableParameter.Add(new KeyValuePair<string, string>("@CREATED_DATE", com.app.utlitiy.BusinessUtlities.getCurrentDateTime));
            tableParameter.Add(new KeyValuePair<string, string>("@MODIFIED_BY", userInfo));
            tableParameter.Add(new KeyValuePair<string, string>("@MODIFIED_DATE", com.app.utlitiy.BusinessUtlities.getCurrentDateTime));
           result= DatabaseConnectionHandler.executeInsertDbQuery(insertQueryString, tableParameter);
            return result;
        }

        //retrieving multiple vendor profile information from vendor table
        public List<CustomerProperties> getMultipleCustomerInfo(string vendorStatus)
        {
            DataSet dataset = new DataSet();
            List<CustomerProperties> customerList = new List<CustomerProperties>();
            string selectQueryString = null;
            if (vendorStatus.Equals("ALL"))
            {
                selectQueryString = "SELECT VENDOR_NAME,VENDOR_ID,VENDOR_ADDRESS,VENDOR_CONTACT,VENDOR_EMAIL_ID,VENDOR_STATUS,VENDOR_DISCOUNT_ID,VENDOR_BALANCE_AMOUNT FROM VENDOR";
                dataset = DatabaseConnectionHandler.executeSelectQuery(selectQueryString, null);

            }
            else
            {
                selectQueryString = "SELECT VENDOR_NAME,VENDOR_ID,VENDOR_ADDRESS,VENDOR_CONTACT,VENDOR_EMAIL_ID,VENDOR_STATUS,VENDOR_DISCOUNT_ID,VENDOR_BALANCE_AMOUNT FROM VENDOR WHERE VENDOR_STATUS=@STATUS";
                List<KeyValuePair<string, string>> tableQueryData = new List<KeyValuePair<string, string>>();
                tableQueryData.Add(new KeyValuePair<string, string>("@STATUS", vendorStatus));
                dataset = DatabaseConnectionHandler.executeSelectQuery(selectQueryString, tableQueryData);

            }
            if (dataset != null)
            {
                foreach (DataRow row in dataset.Tables[0].Rows)
                {
                    CustomerProperties vendorInfo = new CustomerProperties();
                    vendorInfo.Vendor_Name = row["Vendor_Name"].ToString();
                    vendorInfo.Vendor_Id = row["Vendor_Id"].ToString();
                    vendorInfo.Vendor_Address = row["Vendor_Address"].ToString();
                    vendorInfo.Vendor_Contact = row["Vendor_Contact"].ToString();
                    vendorInfo.Vendor_EMail_Id = row["Vendor_Email_Id"].ToString();
                    vendorInfo.Vendor_Status = row["Vendor_Status"].ToString();
                    vendorInfo.Vendor_Discount_ID = row["Vendor_Discount_ID"].ToString();
                    vendorInfo.Vendor_Balance_Amount =Convert.ToDouble(row["Vendor_Balance_Amount"].ToString());
                    customerList.Add(vendorInfo);

                }
            }

            return customerList;
                }


        //retrieving single vendor profile information from vendor table
        public CustomerProperties getSingleCustomerInfo(string vendorId)
        {
            DataSet dataset = new DataSet();
            CustomerProperties vendorInfo = new CustomerProperties();
            string selectQueryString = "SELECT VENDOR_NAME,VENDOR_ID,VENDOR_ADDRESS,VENDOR_CONTACT,VENDOR_EMAIL_ID,VENDOR_STATUS,VENDOR_DISCOUNT_ID,VENDOR_BALANCE_AMOUNT FROM VENDOR WHERE VENDOR_ID=@VENDOR_ID";
            List<KeyValuePair<string, string>> tableQueryData = new List<KeyValuePair<string, string>>();
            tableQueryData.Add(new KeyValuePair<string, string>("@VENDOR_ID", vendorId));
            dataset = DatabaseConnectionHandler.executeSelectQuery(selectQueryString, tableQueryData);
            if (dataset != null)
            {
                foreach (DataRow row in dataset.Tables[0].Rows)
                {
                    vendorInfo.Vendor_Name = row["Vendor_Name"].ToString();
                    vendorInfo.Vendor_Id = row["Vendor_Id"].ToString();
                    vendorInfo.Vendor_Address = row["Vendor_Address"].ToString();
                    vendorInfo.Vendor_Contact = row["Vendor_Contact"].ToString();
                    vendorInfo.Vendor_EMail_Id = row["Vendor_Email_Id"].ToString();
                    vendorInfo.Vendor_Status = row["Vendor_Status"].ToString();
                    vendorInfo.Vendor_Discount_ID = row["Vendor_Discount_ID"].ToString();
                    vendorInfo.Vendor_Balance_Amount = Convert.ToDouble(row["Vendor_Balance_Amount"].ToString());
                  
                }
            }
            return vendorInfo;
        }

        //updating information in vendor profile
        public bool modifyCustomerInfo(CustomerProperties existingVendorInfo, string userInfo)
        {
            string updateQueryString = null;
            bool result = false;
            List<KeyValuePair<string, string>> tableParameters = new List<KeyValuePair<string, string>>();
            if ((existingVendorInfo.Vendor_Address != null) && (existingVendorInfo.Vendor_Contact != null) && (existingVendorInfo.Vendor_EMail_Id != null) )
            {
                updateQueryString = "UPDATE VENDOR SET VENDOR_ADDRESS=@VENDOR_ADDRESS,VENDOR_CONTACT=@VENDOR_CONTACT,VENDOR_EMAIL_ID=@VENDOR_EMAIL_ID,MODIFIED_BY=@MODIFIED_BY,MODIFIED_DATE=@MODIFIED_DATE,VENDOR_STATUS=@VENDOR_STATUS WHERE VENDOR_ID=@VENDOR_ID;";
                tableParameters.Add(new KeyValuePair<string, string>("@VENDOR_ADDRESS", existingVendorInfo.Vendor_Address));
                tableParameters.Add(new KeyValuePair<string, string>("@VENDOR_CONTACT", existingVendorInfo.Vendor_Contact));
                tableParameters.Add(new KeyValuePair<string, string>("@VENDOR_EMAIL_ID", existingVendorInfo.Vendor_EMail_Id));
                tableParameters.Add(new KeyValuePair<string, string>("@MODIFIED_BY", userInfo));
                tableParameters.Add(new KeyValuePair<string, string>("@MODIFIED_DATE", com.app.utlitiy.BusinessUtlities.getCurrentDateTime));
                tableParameters.Add(new KeyValuePair<string, string>("@VENDOR_ID",existingVendorInfo.Vendor_Id));
                tableParameters.Add(new KeyValuePair<string, string>("@VENDOR_STATUS", existingVendorInfo.Vendor_Status));
                result = DatabaseConnectionHandler.executeUpdateQuery(updateQueryString, tableParameters);

                
            }
            return result;
        }

        //Deactivating vendor from vendor table, with this method respective vendor users profile also deactivated
        public bool removeCustomerInfo(CustomerProperties oldVendorInfo,string userInfo)
        {
            string updateQueryString = null;
            bool result = false;
            if (oldVendorInfo.Vendor_Id != null)
            {
                updateQueryString = "UPDATE VENDOR SET VENDOR_STATUS='INACTIVE',MODIFIED_BY=@MODIFIED_BY,MODIFIED_DATE=@MODIFIED_DATE WHERE VENDOR_ID=@VENDOR_ID;";
                List<KeyValuePair<string, string>> tableParameters = new List<KeyValuePair<string, string>>();
                tableParameters.Add(new KeyValuePair<string, string>("@VENDOR_ID", oldVendorInfo.Vendor_Id));
                tableParameters.Add(new KeyValuePair<string, string>("@MODIFIED_BY", userInfo));
                tableParameters.Add(new KeyValuePair<string, string>("@MODIFIED_DATE", com.app.utlitiy.BusinessUtlities.getCurrentDateTime));
                result = DatabaseConnectionHandler.executeUpdateQuery(updateQueryString, tableParameters);
            }
            return result;
        }
    }
}
