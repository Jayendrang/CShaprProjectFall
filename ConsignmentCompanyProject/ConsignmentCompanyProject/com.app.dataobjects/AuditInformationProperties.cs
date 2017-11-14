using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentCompanyProject.com.app.dataobjects
{


    // This data object used for auditing purpose
    /*
     * created by Jayendran Gurumoorthy
     * */
    class AuditInformationProperties
    {
        public string createdBy {  set; get; }
        public string createdOn { set; get; }
        public string modifiedBy { set; get; }
        public string modifiedOn { set; get; }
        
    }
}
