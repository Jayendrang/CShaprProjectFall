using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsignmentCompanyProject.com.app.dataobjects;
using ConsignmentCompanyProject.com.app.utlitiy;
using ConsignmentCompanyProject.com.app.model;
using ConsignmentCompanyProject.com.app.interfaces;

namespace ConsignmentCompanyProject
{   
    public partial class Orders : Form
    {
        private static int _itemNo = 0;
        private DataGridViewButtonColumn buttonRemoveCartItem = new DataGridViewButtonColumn();

    
        public Orders()
        {
            InitializeComponent();
        }

        private void addToCartDataGrid(OrderProperties orderItems)
        {
            try
            {
                _itemNo += 1;
                string [] cartRow = new string[] {_itemNo.ToString(), orderItems.Order_Id.ToString(), orderItems.Manufacturer_Name, orderItems.Product_Name, orderItems.Product_Type, orderItems.Count.ToString(), orderItems.Price_Per_Unit.ToString("c"), orderItems.Total_Price.ToString("c") };
                dataGridViewCart.Rows.Add(cartRow);
                dataGridViewCart.Columns.Add(buttonRemoveCartItem);
                buttonRemoveCartItem.HeaderText = "REMOVE ITEM";
                buttonRemoveCartItem.Name = "buttonRemoveCartItem";
                buttonRemoveCartItem.Text = "REMOVE";
                buttonRemoveCartItem.UseColumnTextForButtonValue = true;
                dataGridViewCart.CellClick += new DataGridViewCellEventHandler(dataGridViewCart_CellClick);
                
                }
            catch (Exception ex) { Console.WriteLine(ex.StackTrace); }
        }
        private void removeFromCartDataGrid(int gridIndex)
        {
            try { 
            if (gridIndex >=0)
            {
                dataGridViewCart.Rows.RemoveAt(gridIndex);

            }
            else if(gridIndex==0)
            {
                MessageBox.Show("Cart is empty");
                dataGridViewCart.CellClick -= new DataGridViewCellEventHandler(dataGridViewCart_CellClick);
            }
            }catch(Exception e)
            {
                Console.WriteLine("Empty cart click", e.StackTrace);
            }
        }
        //Event handler for removing item from the cart
        // 'is' keyword used to check object type compatability
        void dataGridViewCart_CellClick(object sender, DataGridViewCellEventArgs btnevent){

            if (btnevent.RowIndex >= 0)
            {
                removeFromCartDataGrid(btnevent.RowIndex);
            }
            

                        
        }

        
        private void panelOrder_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void groupBoxOrderDetails_Enter(object sender, EventArgs e)
        {

        }

        private void Orders_Load(object sender, EventArgs e)
        {
            InventoryDBProcessHandler inventoryDBProcess = new InventoryDBProcessHandler();

            try
            {
                dataGridViewCart.ColumnCount = 9;
                dataGridViewCart.Columns[0].Name = "ITEM#";
                dataGridViewCart.Columns[1].Name = "ORDER ID";
                dataGridViewCart.Columns[2].Name = "PRODUCT TYPE";
                dataGridViewCart.Columns[3].Name = "MANUFACTURER";
                dataGridViewCart.Columns[4].Name = "PRODCUT NAME";
                dataGridViewCart.Columns[5].Name = "PRICE PER UNIT";
                dataGridViewCart.Columns[6].Name = "COUNT";
                dataGridViewCart.Columns[7].Name = "TOTAL";
                dataGridViewCart.Columns[8].Name = "REMOVE ITEM";

                inventoryDBProcess.getProducts();

                foreach (string typeOfProduct in getproductTypeList()) {

                    comboBoxProductType.Items.Add(typeOfProduct);

                }
                

            }
            catch (Exception ex) { Console.WriteLine(ex.StackTrace); }

        }

        private void buttonSubmitOrder_Click(object sender, EventArgs e)
        {

            
                

        }



        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            OrderProperties cartItems = new OrderProperties();
            try
            {
                cartItems.Order_Id = 111231;
                cartItems.OrderDate = BusinessUtlities.getCurrentDateTime;
                cartItems.Product_Type = "Laptop";
                cartItems.Product_Name = "Sony VAIO";
                cartItems.Product_Id = "PRD0101";
                cartItems.Count = 5;
                cartItems.Price_Per_Unit = 500;
                cartItems.Total_Price = cartItems.Count * cartItems.Price_Per_Unit;
                addToCartDataGrid(cartItems);

            }
            catch (Exception ex) { Console.WriteLine(ex.StackTrace); }
        }

        private void buttonCancelOrder_Click(object sender, EventArgs e)
        {
            ManufacturerProperties man = new ManufacturerProperties();
            man.Manufacturer_Id = "MAN002";
            string selectQueryString = "SELECT PRODUCT.PRODUCT_ID,PRODUCT_TYPE,PRODUCT.PRODUCT_NAME,PRODUCT.PRODUCT_CURRENT_COUNT,PRODUCT.PRICE_PER_UNIT,PRODUCT.MINIMUM_COUNT,MANUFACTURER.MANUFACTURER_ID, MANUFACTURER.MANUFACTURER_NAME,MANUFACTURER_DETAIL FROM PRODUCT INNER JOIN MANUFACTURER ON PRODUCT.MANUFACTURER_ID = MANUFACTURER.MANUFACTURER_ID WHERE MANUFACTURER.MANUFACTURER_ID = @MANFACTURERID ORDER BY MANUFACTURER.MANUFACTURER_NAME;";

            
        }
        private List<string> getproductTypeList()
        {
            List<string> productType = new List<string>();
            try
            {
                productType = InventoryDBProcessHandler.PRODUCT_TYPE.Distinct().ToList();
                
            }catch(Exception ex) { Console.WriteLine(ex.StackTrace + "\t" + "No Products loaded"); }
            return productType;
        }

        private List<ProductProperties> getManufacturerAndProductList(string productType)
        {
            List<ProductProperties> manufacturer = new List<ProductProperties>();
            foreach(List<ProductProperties> productList in InventoryDBProcessHandler.INVENTORY_LIST.Values.ToList())
            {
                foreach(ProductProperties products in productList)
                {
                    if (products.Product_Type.Equals(productType))
                    {
                        manufacturer.Add(products);
                    }
                }
            }
            return manufacturer;
        }

        private List<ProductProperties> getProductList(string manfacturername,string productType)
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
            return listofproducts  ;
        }


        private void comboBoxProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Selected Index changed event called : ProductTypeComboBox");

            List<ProductProperties> props = getManufacturerAndProductList(comboBoxProductType.Text.ToString());
            comboBoxManufacturer.Items.Clear();
            foreach(ProductProperties pp in props)
            {
                comboBoxManufacturer.Items.Add(pp.Manufacturer_Name);
            }
        }

        private void comboBoxManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {


            Console.WriteLine("Selected Index changed event called : ManufacturerComboBox");
            List<ProductProperties> props = getProductList(comboBoxManufacturer.Text.ToString(), comboBoxProductType.Text.ToString()).Distinct().ToList();
            comboBoxProductName.Items.Clear();
            foreach (ProductProperties pp in props)
            {

                comboBoxProductName.Items.Add(pp.Product_Name);
            }


        }

        private void comboBoxProductType_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Click event called : ProductTypeCombobox");
            List<ProductProperties> props = getManufacturerAndProductList(comboBoxProductType.Text.ToString()).Distinct().ToList();

            foreach (ProductProperties pp in props)
            {
                comboBoxManufacturer.Items.Add(pp.Manufacturer_Name);
            }
        }

        private void comboBoxProductType_SelectedValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine("SelectedValue changed event called : ProductTypeComboBox");
            List<ProductProperties> props = getManufacturerAndProductList(comboBoxProductType.Text.ToString()).Distinct().ToList();

            foreach (ProductProperties pp in props)
            {
                comboBoxManufacturer.Items.Add(pp.Manufacturer_Name);
            }


        }
    }
    }
    

 