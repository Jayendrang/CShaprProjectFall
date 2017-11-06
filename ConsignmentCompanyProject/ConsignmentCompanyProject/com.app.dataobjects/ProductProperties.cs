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

    //This class holds manufacturer information and product managament; this class holds persistant data transacion persistance
    class ProductProperties : ManufacturerProperties
    {
        public string Product_Id { get; set; }
        public string Product_Name { get; set; }
        public string Product_Type { get; set; }
        public int Product_Current_Count { get; set; }
        public int Minimum_Count { get; set; }
        public double Price_Per_Unit { get; set; }
        
    }
    
}
