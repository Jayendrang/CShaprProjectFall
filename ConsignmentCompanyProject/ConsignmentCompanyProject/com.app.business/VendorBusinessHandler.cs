using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsignmentCompanyProject.com.app.dataobjects;
using ConsignmentCompanyProject.com.app.model;
namespace ConsignmentCompanyProject.com.app.business
{
    class VendorBusinessHandler
    {
        private static VendorDBProcessHandler vendorDbProcessHandler = new VendorDBProcessHandler();

        public void VendorDBProcessHandler(){

        }
        public static List<VendorProperties> getVendorsList(string status)
        {
            return vendorDbProcessHandler.getMultipleVendorInfo(status);

        }
        public static bool addNewVendor(VendorProperties vendor, string currentUserId)
        {
           return vendorDbProcessHandler.addVendorInfo(vendor, currentUserId);
        }

    }
}
