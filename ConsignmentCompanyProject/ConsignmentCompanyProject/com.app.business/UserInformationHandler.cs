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
        
        private static List<VendorProperties> vendorLists = new List<VendorProperties>();
        public List<VendorProperties> getVendorsList()
        {
            com.app.model.VendorDBProcessHandler vendors = new VendorDBProcessHandler();
            vendorLists = vendors.getMultipleVendorInfo("ACTIVE");
            return vendorLists;
        }

        public  void addNewUser(UserInformationProperties userInformation, string currentUser)
        {
            com.app.model.UserDBProcessHandler userDbHandler = new UserDBProcessHandler();
            userDbHandler.addUser(userInformation,currentUser);
        }
        public  VendorProperties getVendorInfo(string vendorName)
        {
            VendorProperties vendorProperties = new VendorProperties();
            foreach(VendorProperties vendor in vendorLists)
            {
                if (vendor.Vendor_Name.Equals(vendorName))
                {
                    vendorProperties.Vendor_Name = vendor.Vendor_Name;
                    vendorProperties.Vendor_Id = vendor.Vendor_Id;
                }
            }
            return vendorProperties;
        }

    }
}
