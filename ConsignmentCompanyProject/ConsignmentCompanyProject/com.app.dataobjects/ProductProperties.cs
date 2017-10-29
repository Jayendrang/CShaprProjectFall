using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentCompanyProject.com.app.dataobjects
{
    class ProductProperties:ManufacturerProperties
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
