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


    interface IAppVendor<T> where T : VendorProperties
    {
        T getSingleVendorInfo(string vendorId);
        List<T> getMultipleVendorInfo(string vendorStatus);
        bool addVendorInfo(T newVendorInfo, string userInfo);
        bool removeVendorInfo(T oldVendorInfo, string userInfo);
        bool modifyVendorInfo(T existingVendorInfo, string userInfo);

    }
}
