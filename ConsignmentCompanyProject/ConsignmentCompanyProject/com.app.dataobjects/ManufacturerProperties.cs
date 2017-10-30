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

    // This class holds manufacturer information for inventory managament and order module

    class ManufacturerProperties : ProductProperties
    {
        public string ManufacturerId { get; protected set; }
        public string ManufacturerName { get; protected set; }
        public string ManufacturerDescription { private set; get; }

        public List<ManufacturerProperties> ListOfProducts { get; protected set; }
        
    }
}
