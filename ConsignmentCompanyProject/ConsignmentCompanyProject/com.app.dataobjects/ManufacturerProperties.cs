using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentCompanyProject.com.app.dataobjects
{
    class ManufacturerProperties
    {
        public string ManufacturerId { get; protected set; }
        public string ManufacturerName { get;protected set;}
        public string ManufacturerDescription { private set; get; }

    }
}
