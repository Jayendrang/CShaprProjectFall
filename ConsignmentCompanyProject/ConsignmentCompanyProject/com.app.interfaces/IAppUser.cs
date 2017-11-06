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

    interface IAppUser<T> where T : UserInformationProperties
    {
        bool addUser(T userData);
        bool removeUser(string userId);
        bool modifyUser(T userInfo);
        T getSingleUserInfo();
        List<T> getMultipleUserInfo();
        
    }
}
