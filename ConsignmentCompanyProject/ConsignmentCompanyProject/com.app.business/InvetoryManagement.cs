using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsignmentCompanyProject.com.app.dataobjects;
using ConsignmentCompanyProject.com.app.interfaces;
namespace ConsignmentCompanyProject.com.app.business
{
    /*
     *Crated By Jayendran Gurumoorthy
     * Class contains all the inventory related activities
     */

    
    class InvetoryManagement : IAppInventory<ManufacturerProperties>
    {
        //Add product to the inventory
        public string addProduct(ProductProperties productInfo)
        {
            throw new NotImplementedException();
        }

        //Retrive manufactures list with their respective products
        public List<ManufacturerProperties> getManufacturersList()
        {
            throw new NotImplementedException();
        }

        //Retrieve multiple manfactureres information
        public List<ManufacturerProperties> getMultipleProducts(ManufacturerProperties manufacturer)
        {
            throw new NotImplementedException();
        }

        public void reduceProductCount(ProductProperties productInfo, int count)
        {
            throw new NotImplementedException();
        }

        public ManufacturerProperties removeProduct(ProductProperties productId)
        {
            throw new NotImplementedException();
        }

        public ManufacturerProperties searchManufacturer(string manufacturerName)
        {
            throw new NotImplementedException();
        }

        public ManufacturerProperties searchProduct(string ProductName)
        {
            throw new NotImplementedException();
        }

        string addProduct(ManufacturerProperties manufacturerProperties)
        {
            throw new NotImplementedException();
        }


    }
}
