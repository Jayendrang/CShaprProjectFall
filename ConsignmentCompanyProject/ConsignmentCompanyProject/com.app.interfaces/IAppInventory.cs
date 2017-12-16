using System.Collections.Generic;
using ConsignmentCompanyProject.com.app.dataobjects;

namespace ConsignmentCompanyProject.com.app.interfaces
{
    /*
     * created by Jayendran Gurumoorthy
     * */

    //Interface for inventory related operations

    interface IAppInventory<T> 
    {

        List<ProductProperties> getManufacturerProductsList(T manufacturer);
        //T searchProduct(string ProductName);
        List<ManufacturerProperties> getManufacturersList(string status);
        bool addNewManufacturer(ManufacturerProperties manufacturerInfo,string userInfo);
       // T searchManufacturer(string manufacturerName);
        bool addNewProduct(ProductProperties productInfo, string userInfo);
        bool removeProduct(ProductProperties productId);
        bool reduceProductCount(List<ProductProperties> productInfo);
        bool updateProduct(ProductProperties productInfo,string userInfo);
        Dictionary<string, List<ProductProperties>> getProducts();
        bool deActivateManufacturer(ManufacturerProperties manufacturerProperties, string userInfo);
    }

    
}
