using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsignmentCompanyProject.com.app.interfaces;
using ConsignmentCompanyProject.com.app.dataobjects;
using ConsignmentCompanyProject.com.app.model;
namespace ConsignmentCompanyProject.com.app.business
{
    class OrderHandler
    {
       public OrderHandler(){
            
            com.app.model.InventoryDBProcessHandler productsList = new model.InventoryDBProcessHandler();
            productsList.getProducts();
            
            }
        public static List<ProductProperties> getManufacturerAndProductList(string productType)
        {
            List<ProductProperties> manufacturer = new List<ProductProperties>();
            foreach (List<ProductProperties> productList in InventoryDBProcessHandler.INVENTORY_LIST.Values.ToList())
            {
                foreach (ProductProperties products in productList)
                {
                    if (products.Product_Type.Equals(productType))
                    {
                        manufacturer.Add(products);
                    }
                }
            }
            return manufacturer;
        }

        public static List<ProductProperties> getProductList(string manfacturername, string productType)
        {
            List<ProductProperties> listofproducts = new List<ProductProperties>();
            foreach (List<ProductProperties> productList in InventoryDBProcessHandler.INVENTORY_LIST.Values.ToList())
            {
                foreach (ProductProperties products in productList)
                {
                    if ((products.Product_Type.Equals(productType)) && (products.Manufacturer_Name.Equals(manfacturername)))
                    {
                        listofproducts.Add(products);
                    }
                }
            }
            return listofproducts;
        }
        public static ProductProperties getProductInformation(List<ProductProperties> productDetails,string manufacturer,string productType,string productName)
        {
            ProductProperties selectedProductInfo = new ProductProperties();
            foreach(ProductProperties products in productDetails)
            {
                if ((products.Manufacturer_Name.Equals(manufacturer)&&products.Product_Type.Equals(productType)&&(products.Product_Name.Equals(productName))))
                {
                    selectedProductInfo = products;
                }

            }

            return selectedProductInfo;

        }
        public static List<string> getproductTypeList()
        {
            List<string> productType = new List<string>();
            try
            {
                productType = InventoryDBProcessHandler.PRODUCT_TYPE.Distinct().ToList();

            }
            catch (Exception ex) { Console.WriteLine(ex.StackTrace + "\t" + "No Products loaded"); }
            return productType;
        }

        public static bool submitPurchaseOrder(List<OrderProperties> purchaseOrders)
        {
            bool result = false;
            OrderDBProcessHandler submitOrder = new OrderDBProcessHandler();
            result=submitOrder.submitOrder(purchaseOrders);
            
            return result;
        }

        public int  getCustomerDiscountRate()
        {
            DiscountProperties discount= DiscountDBProcessHandler.getDiscountOfCustomer("DIS1");
            return  Convert.ToInt16(discount.Discount_Rate);
        }
    }
}

