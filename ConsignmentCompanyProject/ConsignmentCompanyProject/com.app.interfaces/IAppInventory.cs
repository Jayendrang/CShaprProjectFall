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

        List<ProductProperties> getManufacturersProductsList(T manufacturer);
        T searchProduct(string ProductName);
        List<T> getManufacturersList();
        void addNewManufacturer(ManufacturerProperties manufacturerInfo,UserInformationProperties userInfo);
        T searchManufacturer(string manufacturerName);
        T addNewProduct(ProductProperties productInfo, UserInformationProperties userInfo);
        bool removeProduct(ProductProperties productId, UserInformationProperties userinfo);
        bool reduceProductCount(ProductProperties[] productInfo);
        Dictionary<string, List<ProductProperties>> getProducts();
    }

    
}
