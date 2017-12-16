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
   /*
    * created by Jayendran Gurumoorthy and Jubril Bakare
    * */
        private List<ProductProperties> _current_product_list = new List<ProductProperties>();

        //Loading the control properties
       public OrderHandler(){
            
            com.app.model.InventoryDBProcessHandler productsList = new model.InventoryDBProcessHandler();
            productsList.getProducts();
            _current_product_list = InventoryDBProcessHandler._product_list;
            
            }

        //get manufacturer and thier product types from db
        public  List<ProductProperties> getManufacturerAndProductList(string productType)
        {
            List<ProductProperties> manufacturer = new List<ProductProperties>();
            foreach (List<ProductProperties> productList in InventoryDBProcessHandler._inventory_list.Values.ToList())
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

        //get products based on manager and product type
        public  List<ProductProperties> getProductList(string manfacturername, string productType)
        {
            List<ProductProperties> listofproducts = new List<ProductProperties>();
            foreach (List<ProductProperties> productList in InventoryDBProcessHandler._inventory_list.Values.ToList())
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

        //get product information 
        public  ProductProperties getProductInformation(List<ProductProperties> productDetails,string manufacturer,string productType,string productName)
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
        
        //Retrieve the product type
        public  List<ProductProperties> getproductTypeList()
        {
            List<ProductProperties> productType = new List<ProductProperties>();
            try
            { 
                foreach (ProductProperties prods in _current_product_list)
                {
                    if (!productType.Contains(prods))
                    {
                        productType.Add(prods);
                    }
                }

            }
            catch (Exception ex) { Console.WriteLine(ex.StackTrace + "\t" + "No Products loaded"); }
            return productType;
        }

        //Submit the purchase order
        public  bool submitPurchaseOrder(List<OrderProperties> purchaseOrders)
        {
            bool result = false;
            OrderDBProcessHandler submitOrder = new OrderDBProcessHandler();
            result=submitOrder.submitOrder(purchaseOrders);
            
            return result;
        }

        //get the custome discount rate from database
        public int  getCustomerDiscountRate()
        {
            DiscountProperties discount= DiscountDBProcessHandler.getDiscountOfCustomer("DIS1");

            return  Convert.ToInt16(discount.Discount_Rate);
        }

        public bool updateOrderStatus(OrderProperties orderStatusUpdate)
        {
            OrderDBProcessHandler updateOrder = new OrderDBProcessHandler();
            return updateOrder.updateOrderStatus(orderStatusUpdate);

        }
    }
}

