using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsignmentCompanyProject.com.app.dataobjects;

namespace ConsignmentCompanyProject.com.app.interfaces
{
    /*
     * created by Jayendran Gurumoorthy
     * */


    interface IAppCustomer<T> where T : CustomerProperties
    {
        T getSingleCustomerInfo(string vendorId);
        List<T> getMultipleCustomerInfo(string vendorStatus);
        bool addCustomerInfo(T newVendorInfo, string userInfo);
        bool removeCustomerInfo(T existingVendorInfo, string userInfo);
        bool modifyCustomerInfo(T existingVendorInfo, string userInfo);

    }
}
