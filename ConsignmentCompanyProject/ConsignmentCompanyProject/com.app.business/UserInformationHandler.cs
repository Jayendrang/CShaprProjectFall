using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsignmentCompanyProject.com.app.dataobjects;
using ConsignmentCompanyProject.com.app.model;
namespace ConsignmentCompanyProject.com.app.business
{
    /*
     * Created by Jayendran Gurumoorthy and Anketh Patnaik
     *  */
    class UserInformationHandler
    {
        private static UserDBProcessHandler userDataHandler = new UserDBProcessHandler();
        private static List<CustomerProperties> vendorLists = new List<CustomerProperties>();

        public List<CustomerProperties> getCustomerList()
        {
            com.app.model.CustomerDBProcessHandler customer = new CustomerDBProcessHandler();
            vendorLists = customer.getMultipleCustomerInfo("ACTIVE");
            return vendorLists;
        }

        public  bool addNewUser(UserInformationProperties userInformation, string currentUser)
        {
            com.app.model.UserDBProcessHandler userDbHandler = new UserDBProcessHandler();
            return userDbHandler.addUser(userInformation,currentUser);
        }
        public  CustomerProperties getCustomerInfo(string vendorName)
        {
            CustomerProperties customerProperties = new CustomerProperties();
            foreach(CustomerProperties vendor in vendorLists)
            {
                if (vendor.Vendor_Name.Equals(vendorName))
                {
                    customerProperties.Vendor_Name = vendor.Vendor_Name;
                    customerProperties.Vendor_Id = vendor.Vendor_Id;
                }
            }
            return customerProperties;
        }
        public static UserInformationProperties getUserProfileInformation(string userId)
        {
            return userDataHandler.getSingleUserInfo(userId);

        }
        public static bool updateUserInformation(UserInformationProperties userInformation)
        {
            return userDataHandler.updateUserInfo(userInformation);
        }
    }
}
