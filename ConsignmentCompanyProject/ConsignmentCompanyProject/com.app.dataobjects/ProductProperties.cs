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
    class ProductProperties 
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public string ProductDescription { get; set; }
        public int ProductCurrentCount { get; set; }
        public int MinimumCount { get; set; }
        public double PricePerUnit { get; set; }
        
    }
    
}
