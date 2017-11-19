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
using ConsignmentCompanyProject.com.app.business;
using ConsignmentCompanyProject.com.app.interfaces;

namespace ConsignmentCompanyProject
{   
    public partial class NewOrdersForm : Form
    {
        private static int _itemNo = 0;
        private double _totalPrice = 0;
        private double _minimumAdvancePayment = 0;
        private double _discountRate = 0;
        private double _discountPrice = 0;
        private double _grossPrice = 0;
        private int _itemCount = 0;
        private DataGridViewButtonColumn _buttonRemoveCartItem = new DataGridViewButtonColumn();
        private List<ProductProperties> _productList = new List<ProductProperties>();
        private Dictionary<int, OrderProperties> _listOfOrderItems = new Dictionary<int, OrderProperties>();
        private UserInformationProperties _userSessionInformation;
        private OrderHandler _orderHandler;


        public NewOrdersForm(object session)
        {
            InitializeComponent();
            _userSessionInformation = (UserInformationProperties)session;
            _orderHandler = new OrderHandler();
        }

       

        private void addToCartDataGrid(OrderProperties orderItems)
        {
            try
            {
                _itemNo++;
                string [] cartRow = new string[] {_itemNo.ToString(), orderItems.Order_Id.ToString(), orderItems.Manufacturer_Name, orderItems.Product_Name, orderItems.Product_Type, orderItems.Count.ToString(), orderItems.Price_Per_Unit.ToString("c"), orderItems.Total_Price.ToString("c") };
                dataGridViewCart.Rows.Add(cartRow);
                dataGridViewCart.Columns.Add(_buttonRemoveCartItem);
                _buttonRemoveCartItem.HeaderText = "REMOVE ITEM";
                _buttonRemoveCartItem.Name = "buttonRemoveCartItem";
                _buttonRemoveCartItem.Text = "REMOVE";
                _buttonRemoveCartItem.UseColumnTextForButtonValue = true;
                dataGridViewCart.CellClick += new DataGridViewCellEventHandler(dataGridViewCart_CellClick);
                
                }
            catch (Exception ex) { Console.WriteLine(ex.StackTrace); }
        }
        private void removeFromCartDataGrid(int gridIndex)
        {
            try { 
            if (gridIndex >0)
            {
                
                dataGridViewCart.Rows.RemoveAt(gridIndex);
                
                
                       
            }
            else if(gridIndex==0)
            {
                dataGridViewCart.Rows.RemoveAt(gridIndex);
                MessageBox.Show("Message".ToUpper(),"Cart is empty".ToUpper(),MessageBoxButtons.OK,MessageBoxIcon.Information);
                dataGridViewCart.CellClick -= new DataGridViewCellEventHandler(dataGridViewCart_CellClick);
                _totalPrice = 0;
                _minimumAdvancePayment = 0;
                _discountPrice = 0;
                _grossPrice = 0;

            }      
            }catch(Exception e)
            {
                Console.WriteLine("Empty cart click".ToUpper(), e.StackTrace);
            }
        }
        //Event handler for removing item from the cart
        void dataGridViewCart_CellClick(object sender, DataGridViewCellEventArgs btnevent){
            int orderNumber;
            try {
                 orderNumber= Convert.ToInt16(dataGridViewCart.Rows[btnevent.RowIndex].Cells[0].Value.ToString());

                if (btnevent.RowIndex > 0)
            {
                removeFromCartDataGrid(btnevent.RowIndex);
            }
                Console.WriteLine("Order Index Number {0}");
                _listOfOrderItems.Remove(orderNumber - 1);
                refreshOrderDetails();
            }
            catch(Exception ex) { Console.WriteLine(ex.StackTrace); }
            


        }


        void refreshOrderDetails()
        {
            foreach (KeyValuePair<int, OrderProperties> orders in _listOfOrderItems)
            {
                OrderProperties orderInCart = orders.Value;
                _grossPrice = orderInCart.Price_Per_Unit * orderInCart.Count;
                _discountPrice = (_grossPrice * _discountRate) / 100;
                _totalPrice = _grossPrice - _discountPrice;
                _minimumAdvancePayment = (_totalPrice * 70) / 100;
               
                textBoxAdvanceAmount.Text = _minimumAdvancePayment.ToString("c");
                textBoxDiscountId.Text = _discountPrice.ToString("c");
                textBoxTotalPrice.Text = _totalPrice.ToString("c");
                textBoxBalanceAmount.Text = (_totalPrice - _minimumAdvancePayment).ToString("c");
                               

            }
        }
       
     

        private void Orders_Load(object sender, EventArgs e)
        {
            

            try
            {
                
                // Start - Load the grid view column name
                dataGridViewCart.ColumnCount = 8;
                dataGridViewCart.Columns[0].Name = "ITEM#";
                dataGridViewCart.Columns[0].ReadOnly = true;
                dataGridViewCart.Columns[1].Name = "ORDER ID";
                dataGridViewCart.Columns[1].ReadOnly = true;
                dataGridViewCart.Columns[2].Name = "PRODUCT TYPE";
                dataGridViewCart.Columns[2].ReadOnly = true;
                dataGridViewCart.Columns[3].Name = "MANUFACTURER";
                dataGridViewCart.Columns[3].ReadOnly = true;
                dataGridViewCart.Columns[4].Name = "PRODCUT NAME";
                dataGridViewCart.Columns[4].ReadOnly = true;
                dataGridViewCart.Columns[5].Name = "PRICE PER UNIT";
                dataGridViewCart.Columns[5].ReadOnly = true;
                dataGridViewCart.Columns[6].Name = "COUNT";
                dataGridViewCart.Columns[6].ReadOnly = true;
                dataGridViewCart.Columns[7].Name = "TOTAL";
                dataGridViewCart.Columns[7].ReadOnly = true;

                //**********************************Change while integration
                textBoxUser.Text = _userSessionInformation.User_Id;
                textBoxVendor.Text = _userSessionInformation.Vendor_ID;

               
                _discountRate = _orderHandler.getCustomerDiscountRate();

                loadProductTypeComboBox();

                textBoxOrderId.Text = com.app.utlitiy.BusinessUtlities.getNewUniqueID("SALES_ORDER", "ORDER_ID");
                textBoxOrderDate.Text = com.app.utlitiy.BusinessUtlities.getCurrentDateTime;
            }
            catch (Exception ex) { Console.WriteLine(ex.StackTrace); }

        }

        private void buttonSubmitOrder_Click(object sender, EventArgs e)
        {
            double advanceAmount = Convert.ToDouble(textBoxAdvanceAmount.Text.Replace("$",""));
            if (advanceAmount >= _minimumAdvancePayment)
            {
                List<OrderProperties> finalListofOrderItems = new List<OrderProperties>();
                foreach(KeyValuePair<int,OrderProperties> orders in _listOfOrderItems) {
                    OrderProperties order = orders.Value;
                    order.Balance_Amount = _totalPrice - advanceAmount;
                    order.Order_Status = "NEW ORDER";
                    order.Paid_Amount = advanceAmount;
                    order.Discount_Rate = _discountRate.ToString(); 
                    if (order.Description == null)
                    {
                        order.Description = "NIL";
                    }
                    finalListofOrderItems.Add(order);

                    Console.WriteLine("The Balance amount is : {0}",order.Balance_Amount);
                }

                Console.WriteLine("Final list {0}",finalListofOrderItems.Count);
                if (_orderHandler.submitPurchaseOrder(finalListofOrderItems))
                {

                    MessageBox.Show("PURCHASE ORDER #" + textBoxOrderId.Text, "ORDER PLACED SUCCESSFULLY", MessageBoxButtons.OK);
                }

            }else
            {
                MessageBox.Show("ERROR", "ADVANCE PAYMENT SHOULD BE MORE THAN OR EQUAL TO MINIMUM ADVANCE",MessageBoxButtons.OK);
            }
        }



        private void buttonAddToCart_Click(object sender, EventArgs e)
        {

            OrderProperties cartItems = new OrderProperties();
            try
            {
                cartItems.Order_Id = textBoxOrderId.Text;
                cartItems.OrderDate = BusinessUtlities.getCurrentDateTime;
                cartItems.Product_Type = comboBoxProductType.SelectedItem.ToString();
                cartItems.Manufacturer_Name = comboBoxManufacturer.SelectedItem.ToString();
                cartItems.Product_Name = comboBoxProductName.SelectedItem.ToString();
                cartItems.Product_Id = textBoxProductId.Text;
                cartItems.Count = Convert.ToInt16(textBoxCount.Text);
                cartItems.Price_Per_Unit =Convert.ToDouble(textBoxPricePerUnit.Text);
                cartItems.Total_Price = cartItems.Count * cartItems.Price_Per_Unit;
                cartItems.Discount_Rate = textBoxDiscountId.Text;
                cartItems.User_ID = textBoxUser.Text;
                cartItems.Vendor_Id = textBoxVendor.Text;
                
                if (textBoxDescription.Text.Length>0)
                {
                    cartItems.Description = textBoxDescription.Text;
                }

                addToCartDataGrid(cartItems);
                _grossPrice +=cartItems.Total_Price;
                _discountPrice = (_grossPrice * _discountRate) / 100;
                _totalPrice = _grossPrice - _discountPrice;
                _minimumAdvancePayment = (_totalPrice * 70) / 100;
                textBoxAdvanceAmount.Text = _minimumAdvancePayment.ToString("c");
                textBoxTotalPrice.Text = _totalPrice.ToString("c");
                textBoxDiscountId.Text = _discountPrice.ToString("c");
                textBoxBalanceAmount.Text = (_totalPrice - _minimumAdvancePayment).ToString("c");
                _listOfOrderItems.Add(_itemCount++, cartItems);


            }
            catch (Exception ex) { Console.WriteLine(ex.StackTrace); }
        }

        private void buttonCancelOrder_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void comboBoxManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxProductName.Items.Clear();
            
            List<ProductProperties> productsList = _orderHandler.getProductList(comboBoxManufacturer.SelectedItem.ToString(), comboBoxProductType.SelectedItem.ToString());
            foreach(ProductProperties products in productsList.Distinct().ToList())
            {
                comboBoxProductName.Items.Add(products.Product_Name);
                _productList.Add(products);
            }
        }

        private void comboBoxProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxManufacturer.SelectedText = "";
            comboBoxManufacturer.Items.Clear();
            
            List<ProductProperties> manufacturerslist = _orderHandler.getManufacturerAndProductList(comboBoxProductType.SelectedItem.ToString());

            foreach (ProductProperties props in manufacturerslist.Distinct().ToList())
            {
                if (!comboBoxManufacturer.Items.Contains(props.Manufacturer_Name)) {

                    comboBoxManufacturer.Items.Add(props.Manufacturer_Name);
                }
            }
        }

        private void comboBoxProductName_SelectedIndexChanged(object sender, EventArgs e)
        {try { 
            ProductProperties singleproductInformations = _orderHandler.getProductInformation(_productList,comboBoxManufacturer.SelectedItem.ToString(),comboBoxProductType.SelectedItem.ToString(),comboBoxProductName.SelectedItem.ToString());
            textBoxProductId.Text = singleproductInformations.Product_Id.ToString();
            textBoxPricePerUnit.Text = singleproductInformations.Price_Per_Unit.ToString();
            }catch(Exception ex) { MessageBox.Show("WRONG SELECTION, PLEASE SELECT RIGHT MANUFACTURER AND PRODUCT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        private void textBoxCount_TextChanged(object sender, EventArgs e)
        {
            try { 
            if (textBoxCount.Text != null)
            {
                double totalCount = Convert.ToInt16(textBoxCount.Text) * Convert.ToDouble(textBoxPricePerUnit.Text);
                textBoxItemTotalPrice.Text = totalCount.ToString("c");
            }
            }catch(Exception ex) { Console.WriteLine(ex.Message); }
        }

        private void loadProductTypeComboBox()
        {
            try {
                _productList = _orderHandler.getproductTypeList();
                
            foreach (ProductProperties props in _productList)
            {
             if (comboBoxProductType.Items != null) { 
                if (!comboBoxProductType.Items.Contains(props.Product_Type)) { 
                comboBoxProductType.Items.Add(props.Product_Type);
                }
                    }else
                    {
                        comboBoxProductType.Items.Add(props.Product_Type);
                    }

                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
    public class ItemRemovedEventArgs : EventArgs
    {
        public int indexNumber { get; set; }
        public ItemRemovedEventArgs(int number)
        {
            indexNumber = number;
        }
    }
    }
    

 