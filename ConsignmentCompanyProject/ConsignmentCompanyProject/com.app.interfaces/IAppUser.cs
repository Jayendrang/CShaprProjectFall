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
        bool addUser(T userData,string currentUserId);
        bool deactivateUser(string userId);
        bool updateUserInfo(T userInfo);
        T getSingleUserInfo(string userId);
        List<T> getMultipleUserInfo(string UserStatus);
        
    }
}
