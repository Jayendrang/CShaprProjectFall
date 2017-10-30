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
        List<T> getMultipleVendorInfo();
        T addVendorInfo(T newVendorInfo);
        bool removeVendorInfo(T oldVendorInfo);
        T modifyVendorInfo(T existingVendorInfo);

    }
}
