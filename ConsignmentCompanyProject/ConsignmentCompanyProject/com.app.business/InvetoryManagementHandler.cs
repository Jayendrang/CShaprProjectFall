using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsignmentCompanyProject.com.app.utlitiy;
using ConsignmentCompanyProject.com.app.dataobjects;
using ConsignmentCompanyProject.com.app.model;
namespace ConsignmentCompanyProject.com.app.business
{
    /*
     *Crated By Jayendran Gurumoorthy
     * Class contains all the inventory related activities
     */

    
    class InvetoryManagementHandler  
    {

        private InventoryDBProcessHandler inventoryDbProcessHandler = new InventoryDBProcessHandler();
        
        private Dictionary<string, List<ProductProperties>> manufacturerProductList = new Dictionary<string, List<ProductProperties>>();
        private List<ProductProperties> productList = new List<ProductProperties>();

        void InventoryManagementHanlder()
        {
            getManufacturersProducts();
        }
        
        public string getNewManufacturerId()
        {
            string uniqueId = null;
            try { 
            uniqueId= BusinessUtlities.getNewUniqueID("MANUFACTURER", "MANUFACTURER_ID");
            }catch(Exception ex)
            {
                Console.WriteLine("Error in generating unique ID",ex.StackTrace);

            }
            return uniqueId;
        }
        
        public bool addNewManufacturer(ManufacturerProperties manufacturerInfo, string userInfo)
        {
            return inventoryDbProcessHandler.addNewManufacturer(manufacturerInfo, userInfo);
        }

       

        public List<ManufacturerProperties> getmanufacturersData(string manufacturerStatus)
        {
            List<ManufacturerProperties> manufacturersProperties = new List<ManufacturerProperties>();
            if (manufacturerStatus != null) { 
            manufacturersProperties= inventoryDbProcessHandler.getManufacturersList(manufacturerStatus);
            }
            return manufacturersProperties;
        }

        public void getManufacturersProducts()
        {
            manufacturerProductList =inventoryDbProcessHandler.getProducts();

        }

        public bool removeManufacturer( ManufacturerProperties manufacturerProperites, string currentUserId)
        {
            return inventoryDbProcessHandler.deActivateManufacturer(manufacturerProperites, currentUserId);
        }
    }
}
