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
        public string createdBy { protected set; get; }
        public string createdOn { protected set; get; }
        public string modifiedBy { protected set; get; }
        public string modifiedOn { protected set; get; }
    }
}
