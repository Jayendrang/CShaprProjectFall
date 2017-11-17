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
using ConsignmentCompanyProject.com.app.model;


namespace ConsignmentCompanyProject.com.windows.forms
{
    public partial class CustomerMainWindow : Form
    {
        public CustomerMainWindow()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItemCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                ConsignmentCompanyProject.NewOrdersForm purchaseOrderForm = new NewOrdersForm();
                purchaseOrderForm.ImeMode = this.ImeModeBase;
                purchaseOrderForm.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }



        }

        private void CustomerMainWindow_Load(object sender, EventArgs e)
        {
            labelSessionDate.Text = com.app.utlitiy.BusinessUtlities.getCurrentDateTime;

            dataGridViewCustomerOrders.ColumnCount = 13;
            dataGridViewCustomerOrders.Columns[0].Name = "ORDER #";
            dataGridViewCustomerOrders.Columns[0].ReadOnly = true;
            dataGridViewCustomerOrders.Columns[1].Name = "DATE";
            dataGridViewCustomerOrders.Columns[1].ReadOnly = true;
            dataGridViewCustomerOrders.Columns[2].Name = "PRODUCT NAME";
            dataGridViewCustomerOrders.Columns[2].ReadOnly = true;
            dataGridViewCustomerOrders.Columns[3].Name = "PRODUCT TYPE";
            dataGridViewCustomerOrders.Columns[3].ReadOnly = true;
            dataGridViewCustomerOrders.Columns[4].Name = "MANUFACTURER NAME";
            dataGridViewCustomerOrders.Columns[4].ReadOnly = true;
            dataGridViewCustomerOrders.Columns[5].Name = "COUNT";
            dataGridViewCustomerOrders.Columns[5].ReadOnly = true;
            dataGridViewCustomerOrders.Columns[6].Name = "PRICE PER UNIT";
            dataGridViewCustomerOrders.Columns[6].ReadOnly = true;
            dataGridViewCustomerOrders.Columns[7].Name = "TOTAL PRICE";
            dataGridViewCustomerOrders.Columns[7].ReadOnly = true;
            dataGridViewCustomerOrders.Columns[8].Name = "PAID AMOUNT";
            dataGridViewCustomerOrders.Columns[8].ReadOnly = true;
            dataGridViewCustomerOrders.Columns[9].Name = "BALANCE";
            dataGridViewCustomerOrders.Columns[9].ReadOnly = true;
            dataGridViewCustomerOrders.Columns[10].Name = "DISCOUNT";
            dataGridViewCustomerOrders.Columns[10].ReadOnly = true;
            dataGridViewCustomerOrders.Columns[11].Name = "ORDER STATUS";
            dataGridViewCustomerOrders.Columns[11].ReadOnly = true;
            dataGridViewCustomerOrders.Columns[12].Name = "DESCRIPTION";
            dataGridViewCustomerOrders.Columns[12].ReadOnly = true;

            radioButtonActive.Checked = true;
            groupBoxCancelOrder.Visible = false; 
        }

        private void radioButtonActive_CheckedChanged(object sender, EventArgs e)
        {
            com.app.business.CustomerMainWindowHandler getActiveOrders = new app.business.CustomerMainWindowHandler();
            //**********testing
            List < OrderProperties > listofOrders = getActiveOrders.getOrders("VEN1120", "NEW ORDER");
            fillOrderDataGrid(listofOrders);
        }

        private void fillOrderDataGrid(List<OrderProperties> orders)
        {
            
            dataGridViewCustomerOrders.Rows.Clear();
         
            foreach(OrderProperties order in orders) {
                string[] columns = new string[] { order.Order_Id, order.OrderDate, order.Product_Name, order.Product_Type, order.Manufacturer_Name, order.Count.ToString(), order.Price_Per_Unit.ToString("c"),order.Total_Price.ToString("c"),
                order.Paid_Amount.ToString("c"),order.Balance_Amount.ToString("c"),order.Discount_Rate,order.Order_Status,order.Description};

                dataGridViewCustomerOrders.Rows.Add(columns);
            }

        }

        private void radioButtonCompleted_CheckedChanged(object sender, EventArgs e)
        {
            
            com.app.business.CustomerMainWindowHandler getActiveOrders = new app.business.CustomerMainWindowHandler();
            //**********testing
            List<OrderProperties> listofOrders = getActiveOrders.getOrders("VEN1120", "COMPLETED");
            fillOrderDataGrid(listofOrders);
        }

        private void cANCELORDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxCancelOrder.Visible = true;
        }

        private void buttonCloseCancel_Click(object sender, EventArgs e)
        {
            groupBoxCancelOrder.Visible = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            try
            {
                OrderProperties cancelOrderProperties = new OrderProperties();
                cancelOrderProperties.Order_Id = textBoxCancelOrderId.Text;
                cancelOrderProperties.Description = textBoxCancelDescription.Text;
                cancelOrderProperties.User_ID = "JaY2234";
                cancelOrderProperties.Vendor_Id = "VEN1120";
                cancelOrderProperties.Order_Status = "NEW ORDER";

                com.app.business.CustomerMainWindowHandler customerOrderCancel = new app.business.CustomerMainWindowHandler();
                customerOrderCancel.cancelExistingOrder(cancelOrderProperties);
            }
            catch(Exception exp)
            {
                Console.WriteLine(exp.StackTrace);
            }
        }

        private void radioButtonCancelled_CheckedChanged(object sender, EventArgs e)
        {
            com.app.business.CustomerMainWindowHandler getActiveOrders = new app.business.CustomerMainWindowHandler();
            //**********testing
            List<OrderProperties> listofOrders = getActiveOrders.getOrders("VEN1120", "CANCELLED");
            fillOrderDataGrid(listofOrders);

        }

        private void radioButtonAllOrder_CheckedChanged(object sender, EventArgs e)
        {
            com.app.business.CustomerMainWindowHandler getActiveOrders = new app.business.CustomerMainWindowHandler();
            //**********testing
            List<OrderProperties> listofOrders = getActiveOrders.getOrders("VEN1120", null);
            fillOrderDataGrid(listofOrders);

        }

        private void oRDERRETURNSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { 
            ConsignmentCompanyProject.windows.forms.OrderReturnForm orderReturnForm = new ConsignmentCompanyProject.windows.forms.OrderReturnForm();
            orderReturnForm.ImeMode = this.ImeMode;
                orderReturnForm.Show();
            }catch(Exception exp)
            {
                Console.WriteLine(exp.StackTrace);
            }
        }
    }
}
