using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsignmentCompanyProject.com.app.dataobjects;
using ConsignmentCompanyProject.com.app.model;
namespace ConsignmentCompanyProject.com.app.business
{
    class CustomerInformationHandler
    {
        private static CustomerDBProcessHandler vendorDbProcessHandler = new CustomerDBProcessHandler();

        public void VendorDBProcessHandler(){

        }
        public static List<CustomerProperties> getVendorsList(string status)
        {
            return vendorDbProcessHandler.getMultipleCustomerInfo(status);

        }
        public static bool addNewVendor(CustomerProperties vendor, string currentUserId)
        {
           return vendorDbProcessHandler.addCustomerInfo(vendor, currentUserId);
        }
        
        public static bool vendorInformationUpdate(CustomerProperties vendorinfo, string currentUserId)
        {
            return vendorDbProcessHandler.modifyCustomerInfo(vendorinfo, currentUserId);

        }
        public static CustomerProperties searchVendor(string vendorId)
        {
            CustomerProperties vendorInfo = new CustomerProperties();
            return  vendorInfo = vendorDbProcessHandler.getSingleCustomerInfo(vendorId);
             
            
        }
        public static DiscountProperties getVendorDiscountInfo(string vendorId)
        {
            DiscountProperties discountInfo = new DiscountProperties();
            return discountInfo = DiscountDBProcessHandler.getDiscountOfCustomer(vendorId);

        }

        public static bool deactivateVendor(CustomerProperties vendor, string userId)
        {
            bool result = false;
            result=vendorDbProcessHandler.removeCustomerInfo(vendor, userId);
            if (result)
            {
                UserDBProcessHandler removeVendorUser = new UserDBProcessHandler();
                removeVendorUser.removeMultipleCustomerUsers(vendor.Vendor_Id);
            }
            return result;
        }

    }
}
