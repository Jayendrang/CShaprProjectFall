using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentCompanyProject.com.app.dataobjects
{
    /*
     * created by Jayendran Gurumoorthy
     * */

    //this class is used as persistant object for order return 
    class OrderReturnProperties 
    {
        public string Return_Order_Id { set; get; }
        public string Order_Id { set; get; }
        public string User_Id { set; get; }
        public string Vendor_Id { set; get; }
        public string Created_By { set; get; }
        public string Product_Id { set; get; }
        public string Product_Name { set; get; }
        public string Product_Type { set; get; }
        public int Count { set; get; }
        public double Price_Per_Unit { set; get; }
        public string Return_Description { set; get; }
        public string Return_Status { set; get; }
        
    }
}
