using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsignmentCompanyProject.com.app.utlitiy
{
    class BusinessUtlities
    {
        
        public static string getCurrentDateTime
        {
            get
            {
                string tempDateTime = DateTime.Now.ToString("MM/dd/yyyy");
                return tempDateTime;
            }

        }



        


    }
    
}
