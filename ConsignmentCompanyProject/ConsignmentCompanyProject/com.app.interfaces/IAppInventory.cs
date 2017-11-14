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
        List<ManufacturerProperties> getManufacturersList();
        void addNewManufacturer(ManufacturerProperties manufacturerInfo,UserInformationProperties userInfo);
       // T searchManufacturer(string manufacturerName);
        bool addNewProduct(ProductProperties productInfo, UserInformationProperties userInfo);
        bool removeProduct(ProductProperties productId);
        bool reduceProductCount(List<ProductProperties> productInfo);
        bool increaseProductCount(ProductProperties productInfo);
       // Dictionary<string, List<ProductProperties>> getProducts();
    }

    
}
