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
        T searchManufacturer(string manufacturerName);
        string addProduct(ProductProperties productInfo);
        T removeProduct(ProductProperties productId);
        void reduceProductCount(ProductProperties[] productInfo);
        Dictionary<string, List<ProductProperties>> getProducts();
    }

    
}
