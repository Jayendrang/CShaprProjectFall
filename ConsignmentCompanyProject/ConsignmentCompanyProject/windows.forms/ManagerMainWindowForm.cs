using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsignmentCompanyProject.com.app.business;
using ConsignmentCompanyProject.com.app.dataobjects;

namespace ConsignmentCompanyProject
{
    public partial class ManagerMainWindow : Form
    {

        private Dictionary<string, List<OrderProperties>> _NewOrdersDictionary = new Dictionary<string, List<OrderProperties>>();
        private Dictionary<string, List<OrderProperties>> _InProcessOrdersDictionary = new Dictionary<string, List<OrderProperties>>();
        private Dictionary<string, List<OrderProperties>> _CompletedOrdersDictionary = new Dictionary<string, List<OrderProperties>>();
        private List<OrderReturnProperties> _returnOrderList = new List<OrderReturnProperties>();
        private MainWIndowFormHandler handler = new MainWIndowFormHandler();
        private UserInformationProperties _userSessionInformation;


        public ManagerMainWindow(object session)
        {
            InitializeComponent();
            _userSessionInformation =(UserInformationProperties) session;
        }

        private void ManagerMainWindow_Load(object sender, EventArgs e)
        {
            tabPage1.Text = "NEW ORDERS";
            tabPage2.Text = "ORDERS IN PROCESS";
            tabPage3.Text = "COMPLETED";
            tabPage4.Text = "ORDER RETUNS";

            loadNewOrderGrid();
            loadOrderCompletedDataGrid();
            loadOrderInProcessDataGrid();
            loadOrderReturnsDataGrid();

            loadCompletedOrders(handler.getOrders("COMPLETED"));
            loadNewOrderCollections(handler.getOrders("NEW ORDER"));
            loadInProcessOrdersCollection(handler.getOrders("INPROCESS"));
            loadReturnOrders(handler.getReturnOrders("NEW RETURN"));

            
        }

        private void ManagerMainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        void loadReturnOrders(List<OrderReturnProperties> returnOrders)
        {
            fillReturnOrders(returnOrders);
        }

        

        void loadNewOrderCollections(List<OrderProperties> newOrders)
        {
            foreach(OrderProperties orderData in newOrders) {
               
                if (_NewOrdersDictionary.Keys.Contains(orderData.Order_Id))
                {
                    OrderProperties orderProperty = new OrderProperties();
                    List<OrderProperties> existingData;
                    _NewOrdersDictionary.TryGetValue(orderData.Order_Id, out existingData);
                    orderProperty = orderData;
                    existingData.Add(orderProperty);
                    _NewOrdersDictionary.Remove(orderData.Order_Id);
                    _NewOrdersDictionary.Add(orderData.Order_Id, existingData);
                }else
                {
                    OrderProperties orderProperty = new OrderProperties();
                    List<OrderProperties> existingData = new List<OrderProperties>();
                    orderProperty = orderData;
                    existingData.Add(orderProperty);
                    _NewOrdersDictionary.Add(orderData.Order_Id, existingData);

                }
             }
            fillNewOrderGridView(newOrders);


        }

        void loadInProcessOrdersCollection(List<OrderProperties> inProcessOrders){

            foreach (OrderProperties orderData in inProcessOrders)
            {

                if (_InProcessOrdersDictionary.Keys.Contains(orderData.Order_Id))
                {
                    OrderProperties orderProperty = new OrderProperties();
                    List<OrderProperties> existingData;
                    _InProcessOrdersDictionary.TryGetValue(orderData.Order_Id, out existingData);
                    orderProperty = orderData;
                    existingData.Add(orderProperty);
                    _InProcessOrdersDictionary.Remove(orderData.Order_Id);
                    _InProcessOrdersDictionary.Add(orderData.Order_Id, existingData);
                }
                else
                {
                    OrderProperties orderProperty = new OrderProperties();
                    List<OrderProperties> existingData = new List<OrderProperties>();
                    orderProperty = orderData;
                    existingData.Add(orderProperty);
                    _InProcessOrdersDictionary.Add(orderData.Order_Id, existingData);

                }
            }
            fillOrdersInProcess(inProcessOrders);
        }

        void loadCompletedOrders(List<OrderProperties> completedOrders)
        {
            foreach (OrderProperties orderData in completedOrders)
            {

                if (_CompletedOrdersDictionary.Keys.Contains(orderData.Order_Id))
                {
                    OrderProperties orderProperty = new OrderProperties();
                    List<OrderProperties> existingData;
                    _CompletedOrdersDictionary.TryGetValue(orderData.Order_Id, out existingData);
                    orderProperty = orderData;
                    existingData.Add(orderProperty);
                    _CompletedOrdersDictionary.Remove(orderData.Order_Id);
                    _CompletedOrdersDictionary.Add(orderData.Order_Id, existingData);
                }
                else
                {
                    OrderProperties orderProperty = new OrderProperties();
                    List<OrderProperties> existingData = new List<OrderProperties>();
                    orderProperty = orderData;
                    existingData.Add(orderProperty);
                    _CompletedOrdersDictionary.Add(orderData.Order_Id, existingData);

                }
            }
            fillCompletedOrderGridView(completedOrders);
        }

       
        void fillNewOrderGridView(List<OrderProperties> newOrders)
        {
            List<string> processed = new List<string>();
            int index = 0;
            try {
                dataGridViewNewOrders.Rows.Clear();
            foreach(OrderProperties orders in newOrders) {
                    if (!processed.Contains(orders.Order_Id)) { 
                DataGridViewLinkCell orderIDCell = new DataGridViewLinkCell();
                orderIDCell.Value = orders.Order_Id;
                orderIDCell.LinkBehavior = LinkBehavior.AlwaysUnderline;
                orderIDCell.LinkColor = Color.Blue;
                orderIDCell.LinkVisited = false;
                orderIDCell.TrackVisitedState = true;

                string[] rows = new string[] {"",orders.OrderDate,orders.Vendor_Id,orders.Total_Price.ToString("c"),
                orders.Balance_Amount.ToString("c"),orders.Paid_Amount.ToString("c"),orders.Discount_Rate,orders.Order_Status,orders.Description};
                dataGridViewNewOrders.Rows.Add(rows);
                dataGridViewNewOrders[0, index++] = orderIDCell;
                processed.Add(orders.Order_Id);
                    }
                }

                dataGridViewNewOrders.CellClick += new DataGridViewCellEventHandler(gridViewOrderClickEvent);


            }
            catch(Exception ex) { Console.WriteLine(ex.StackTrace); }
        }

        void fillCompletedOrderGridView(List<OrderProperties> completed)
        {
            List<string> processed = new List<string>();
            int index = 0;
            try
            {
                dataGridViewOrderCompleted.Rows.Clear();
                foreach (OrderProperties orders in completed)
                {
                    if (!processed.Contains(orders.Order_Id))
                    {
                        DataGridViewLinkCell orderIDCell = new DataGridViewLinkCell();
                        orderIDCell.Value = orders.Order_Id;
                        orderIDCell.LinkBehavior = LinkBehavior.AlwaysUnderline;
                        orderIDCell.LinkColor = Color.Blue;
                        orderIDCell.LinkVisited = false;
                        orderIDCell.TrackVisitedState = true;

                        string[] rows = new string[] {"",orders.OrderDate,orders.Vendor_Id,orders.Total_Price.ToString("c"),
                orders.Balance_Amount.ToString("c"),orders.Paid_Amount.ToString("c"),orders.Discount_Rate,orders.Order_Status,orders.Description};
                        dataGridViewOrderCompleted.Rows.Add(rows);
                        dataGridViewOrderCompleted[0, index++] = orderIDCell;
                        processed.Add(orders.Order_Id);
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.StackTrace); }
           
        }

        void fillOrdersInProcess(List<OrderProperties> inProcess)
        {
            List<string> processed = new List<string>();
            int index = 0;
            try
            {
                dataGridViewOrdersInProcess.Rows.Clear();
                foreach (OrderProperties orders in inProcess)
                {
                    if (!processed.Contains(orders.Order_Id))
                    {
                        DataGridViewLinkCell orderIDCell = new DataGridViewLinkCell();
                        orderIDCell.Value = orders.Order_Id;
                        orderIDCell.LinkBehavior = LinkBehavior.AlwaysUnderline;
                        orderIDCell.LinkColor = Color.Blue;
                        orderIDCell.LinkVisited = false;
                        orderIDCell.TrackVisitedState = true;

                        string[] rows = new string[] {"",orders.OrderDate,orders.Vendor_Id,orders.Total_Price.ToString("c"),
                orders.Balance_Amount.ToString("c"),orders.Paid_Amount.ToString("c"),orders.Discount_Rate,orders.Order_Status,orders.Description};
                        dataGridViewOrdersInProcess.Rows.Add(rows);
                        dataGridViewOrdersInProcess[0, index++] = orderIDCell;
                        processed.Add(orders.Order_Id);
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.StackTrace); }
           dataGridViewOrdersInProcess.CellClick += new DataGridViewCellEventHandler(gridViewInProcessOrderClickEvent);
        }
        void fillReturnOrders(List<OrderReturnProperties> orderReturns)
        {
            try
            {
                _returnOrderList = orderReturns;
                foreach (OrderReturnProperties orders in orderReturns)
                {
                    double total = orders.Count * orders.Price_Per_Unit;
                    string[] rows = new string[] {orders.Return_Order_Id,orders.Order_Id ,orders.Vendor_Id,orders.User_Id,
                orders.Product_Id,orders.Product_Type,orders.Count.ToString(),orders.Price_Per_Unit.ToString(),total.ToString(),
                orders.Return_Description, orders.Return_Status};

                    dataGridViewOrderReturns.Rows.Add(rows);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
        void loadNewOrderGrid()
        {
            dataGridViewNewOrders.ColumnCount = 9;
            dataGridViewNewOrders.Columns[0].Name = "ORDER ID";
            dataGridViewNewOrders.Columns[0].ReadOnly = true;
            dataGridViewNewOrders.Columns[1].Name = "ORDER DATE";
            dataGridViewNewOrders.Columns[1].ReadOnly = true;
            dataGridViewNewOrders.Columns[2].Name = "VENDOR ID";
            dataGridViewNewOrders.Columns[2].ReadOnly = true;
            dataGridViewNewOrders.Columns[3].Name = "TOTAL PRICE";
            dataGridViewNewOrders.Columns[3].ReadOnly = true;
            dataGridViewNewOrders.Columns[4].Name = "BALANCE";
            dataGridViewNewOrders.Columns[4].ReadOnly = true;
            dataGridViewNewOrders.Columns[5].Name = "ADVANCE PAYMENT";
            dataGridViewNewOrders.Columns[5].ReadOnly = true;
            dataGridViewNewOrders.Columns[6].Name = "DISCOUNT RATE";
            dataGridViewNewOrders.Columns[6].ReadOnly = true;
            dataGridViewNewOrders.Columns[7].Name = "ORDER STATUS";
            dataGridViewNewOrders.Columns[7].ReadOnly = true;
            dataGridViewNewOrders.Columns[8].Name = "DESCRIPTION";
            dataGridViewNewOrders.Columns[8].ReadOnly = true;
            
        }

        void loadOrderInProcessDataGrid()
        {
            dataGridViewOrdersInProcess.ColumnCount = 9;
            dataGridViewOrdersInProcess.Columns[0].Name = "ORDER ID";
            dataGridViewOrdersInProcess.Columns[0].ReadOnly = true;
            dataGridViewOrdersInProcess.Columns[1].Name = "ORDER DATE";
            dataGridViewOrdersInProcess.Columns[1].ReadOnly = true;
            dataGridViewOrdersInProcess.Columns[2].Name = "VENDOR ID";
            dataGridViewOrdersInProcess.Columns[2].ReadOnly = true;
            dataGridViewOrdersInProcess.Columns[3].Name = "TOTAL PRICE";
            dataGridViewOrdersInProcess.Columns[3].ReadOnly = true;
            dataGridViewOrdersInProcess.Columns[4].Name = "BALANCE";
            dataGridViewOrdersInProcess.Columns[4].ReadOnly = true;
            dataGridViewOrdersInProcess.Columns[5].Name = "ADVANCE PAYMENT";
            dataGridViewOrdersInProcess.Columns[5].ReadOnly = true;
            dataGridViewOrdersInProcess.Columns[6].Name = "DISCOUNT RATE";
            dataGridViewOrdersInProcess.Columns[6].ReadOnly = true;
            dataGridViewOrdersInProcess.Columns[7].Name = "ORDER STATUS";
            dataGridViewOrdersInProcess.Columns[7].ReadOnly = true;
            dataGridViewOrdersInProcess.Columns[8].Name = "DESCRIPTION";
            dataGridViewOrdersInProcess.Columns[8].ReadOnly = true;
           
        }
        
        void loadOrderCompletedDataGrid()
        {
            dataGridViewOrderCompleted.ColumnCount = 9;
            dataGridViewOrderCompleted.Columns[0].Name = "ORDER ID";
            dataGridViewOrderCompleted.Columns[0].ReadOnly = true;
            dataGridViewOrderCompleted.Columns[1].Name = "ORDER DATE";
            dataGridViewOrderCompleted.Columns[1].ReadOnly = true;
            dataGridViewOrderCompleted.Columns[2].Name = "VENDOR ID";
            dataGridViewOrderCompleted.Columns[2].ReadOnly = true;
            dataGridViewOrderCompleted.Columns[3].Name = "TOTAL PRICE";
            dataGridViewOrderCompleted.Columns[3].ReadOnly = true;
            dataGridViewOrderCompleted.Columns[4].Name = "BALANCE";
            dataGridViewOrderCompleted.Columns[4].ReadOnly = true;
            dataGridViewOrderCompleted.Columns[5].Name = "ADVANCE PAYMENT";
            dataGridViewOrderCompleted.Columns[5].ReadOnly = true;
            dataGridViewOrderCompleted.Columns[6].Name = "DISCOUNT RATE";
            dataGridViewOrderCompleted.Columns[6].ReadOnly = true;
            dataGridViewOrderCompleted.Columns[7].Name = "ORDER STATUS";
            dataGridViewOrderCompleted.Columns[7].ReadOnly = true;
            dataGridViewOrderCompleted.Columns[8].Name = "DESCRIPTION";
            dataGridViewOrderCompleted.Columns[8].ReadOnly = true;
           

        }

       
        void loadOrderReturnsDataGrid()
        {
            dataGridViewOrderReturns.ColumnCount = 11;
            dataGridViewOrderReturns.Columns[0].Name = "RETURN ORDER ID";
            dataGridViewOrderReturns.Columns[0].ReadOnly = true;
            dataGridViewOrderReturns.Columns[1].Name = "ORGIN ORDER";
            dataGridViewOrderReturns.Columns[1].ReadOnly = true;
            dataGridViewOrderReturns.Columns[2].Name = "VENDOR ID";
            dataGridViewOrderReturns.Columns[2].ReadOnly = true;
            dataGridViewOrderReturns.Columns[3].Name = "USER ID";
            dataGridViewOrderReturns.Columns[3].ReadOnly = true;
            dataGridViewOrderReturns.Columns[4].Name = "PRODUCT ID";
            dataGridViewOrderReturns.Columns[4].ReadOnly = true;
            dataGridViewOrderReturns.Columns[5].Name = "PRODUCT TYPE";
            dataGridViewOrderReturns.Columns[5].ReadOnly = true;
            dataGridViewOrderReturns.Columns[6].Name = "ITEM COUNT";
            dataGridViewOrderReturns.Columns[6].ReadOnly = true;
            dataGridViewOrderReturns.Columns[7].Name = "UNIT PRICE";
            dataGridViewOrderReturns.Columns[7].ReadOnly = true;
            dataGridViewOrderReturns.Columns[8].Name = "TOTAL";
            dataGridViewOrderReturns.Columns[8].ReadOnly = true;
            dataGridViewOrderReturns.Columns[9].Name = "RETURN DESCRIPTION";
            dataGridViewOrderReturns.Columns[9].ReadOnly = true;
            dataGridViewOrderReturns.Columns[10].Name = "RETURN STATUS";
            dataGridViewOrderReturns.Columns[10].ReadOnly = true;
            

        }

        private void buttonRefersh_Click(object sender, EventArgs e)
        {
            loadCompletedOrders(handler.getOrders("COMPLETED"));
            loadNewOrderCollections(handler.getOrders("NEW ORDER"));
            loadInProcessOrdersCollection(handler.getOrders("INPROCESS"));

        }
        void gridViewOrderClickEvent(object sender,DataGridViewCellEventArgs args)
        {
            try { 
            string orderId = dataGridViewNewOrders.Rows[args.RowIndex].Cells[0].Value.ToString();

            if (_NewOrdersDictionary.Keys.Contains(orderId)) {
            List<OrderProperties> newOrders= new List<OrderProperties>();
            _NewOrdersDictionary.TryGetValue(orderId, out newOrders);
                    //******testing
            com.windows.forms.OrdersDetailsForm ordersDetailsForm = new com.windows.forms.OrdersDetailsForm(newOrders, _userSessionInformation.User_Id);
            ordersDetailsForm.Show();
            ordersDetailsForm.loadDataGrid();
            
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

        }
        void gridViewInProcessOrderClickEvent(object sender, DataGridViewCellEventArgs args)
        {
            try
            {
                string orderId = dataGridViewOrdersInProcess.Rows[args.RowIndex].Cells[0].Value.ToString();

                if (_InProcessOrdersDictionary.Keys.Contains(orderId))
                {
                    List<OrderProperties> newOrders = new List<OrderProperties>();
                    _InProcessOrdersDictionary.TryGetValue(orderId, out newOrders);
                    //******testing
                    com.windows.forms.OrdersDetailsForm ordersDetailsForm = new com.windows.forms.OrdersDetailsForm(newOrders, _userSessionInformation.User_Id);
                    ordersDetailsForm.Show();
                    ordersDetailsForm.loadDataGrid();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

        }

        private void iNVENTORYMANAGEMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryManagementForm inventoryManagementForm = new InventoryManagementForm(_userSessionInformation);
            //inventoryManagementForm.MdiParent = this;
            inventoryManagementForm.ImeMode = this.ImeModeBase;
            inventoryManagementForm.Show();
        }

        private void cUSTOMERMANAGEMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsignmentCompanyProject.CustomerManagementForm customerManagementForm = new CustomerManagementForm(_userSessionInformation);
           // customerManagementForm.MdiParent = this;
            customerManagementForm.ImeMode = this.ImeModeBase;
            customerManagementForm.Show();
        }

        private void eXITToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            windows.forms.UserProfileChangeForm userProfile = new windows.forms.UserProfileChangeForm(_userSessionInformation);
           // userProfile.MdiParent = this;
            userProfile.ImeMode = this.ImeModeBase;
            userProfile.Show();

        }

        private void aDDNEWUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            windows.forms.NewUserRegistrationForm newUserRegistration = new windows.forms.NewUserRegistrationForm(_userSessionInformation);
           // newUserRegistration.MdiParent = this;
            newUserRegistration.ImeMode = this.ImeModeBase;
            newUserRegistration.Show();
            
        }

        private void aBOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBoxCustomer aboutBoxManager = new AboutBoxCustomer();
          //  aboutBoxManager.MdiParent = this;
            aboutBoxManager.ImeMode = this.ImeModeBase;
            aboutBoxManager.Show();
        }
    }
}
