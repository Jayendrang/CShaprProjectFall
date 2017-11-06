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

    //Discount properties used to store and retrive vendor associated discount information
    class DiscountProperties
    {
        public string Discount_Id { set; get; }
        public string Discount_Rate { set; get; }
        public AuditInformationProperties audit_Information { set; get; }        
    }
}
