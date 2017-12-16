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
using ConsignmentCompanyProject.com.app.utilities;
using ConsignmentCompanyProject.com.app.business;


namespace ConsignmentCompanyProject.com.windows.forms
{
    
    public partial class CustomerMainWindow : Form
    {
        private UserInformationProperties _currentUserSessionInformation;
        public CustomerMainWindow(object sessionInfo)
        {
            InitializeComponent();
            _currentUserSessionInformation =(UserInformationProperties) sessionInfo;
            textBoxSessionUser.Text = _currentUserSessionInformation.Name;
            textBoxSessionVendor.Text = _currentUserSessionInformation.Vendor_Name;
            textBoxCurrentDate.Text = ConsignmentCompanyProject.com.app.utlitiy.BusinessUtlities.getCurrentDateTime;
        }

        private void ToolStripMenuItemCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                ConsignmentCompanyProject.NewOrdersForm purchaseOrderForm = new NewOrdersForm(_currentUserSessionInformation);
                //purchaseOrderForm.MdiParent = this;
                purchaseOrderForm.ImeMode = this.DefaultImeMode;
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
            List < OrderProperties > listofOrders = getActiveOrders.getOrders(_currentUserSessionInformation.Vendor_ID, "NEW ORDER");
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
            List<OrderProperties> listofOrders = getActiveOrders.getOrders(_currentUserSessionInformation.Vendor_ID, "COMPLETED");
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
            bool result = false;
            try
            {
                if (!FormValidationUtilities.nullCheck(textBoxCancelOrderId.Text) && textBoxCancelOrderId.Text.StartsWith("ORD") && !FormValidationUtilities.nullCheck(textBoxCancelDescription.Text)) {
                OrderProperties cancelOrderProperties = new OrderProperties();
                cancelOrderProperties.Order_Id = textBoxCancelOrderId.Text;
                cancelOrderProperties.Description = textBoxCancelDescription.Text;
                cancelOrderProperties.User_ID = _currentUserSessionInformation.User_Id;
                cancelOrderProperties.Vendor_Id = _currentUserSessionInformation.Vendor_ID;
                cancelOrderProperties.Order_Status = "NEW ORDER";

                com.app.business.CustomerMainWindowHandler customerOrderCancel = new app.business.CustomerMainWindowHandler();
                result =customerOrderCancel.cancelExistingOrder(cancelOrderProperties);
                if (result)
                {
                    MessageBox.Show("ORDER CANCELLED SUCCESSFULLY","ORDERS",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ORDER CANCELLED ALREADY! ", "ORDERS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    throw new OrderException("ORDER CANCELLED ALREADY");
                }
                }
                else{

                    errorProviderCustomerWindow.SetError(textBoxCancelOrderId,"Wrong order ID".ToUpper());

                }
            }
            catch (BusinessExceptions exp)
            {
                Console.WriteLine(exp.StackTrace);
               
                MessageBox.Show("PLEASE PROIVDE ORDER ID TO CANCEL", "ORDER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void radioButtonCancelled_CheckedChanged(object sender, EventArgs e)
        {
            com.app.business.CustomerMainWindowHandler getActiveOrders = new app.business.CustomerMainWindowHandler();
            //**********testing
            List<OrderProperties> listofOrders = getActiveOrders.getOrders(_currentUserSessionInformation.Vendor_ID, "CANCELLED");
            fillOrderDataGrid(listofOrders);

        }

        private void radioButtonAllOrder_CheckedChanged(object sender, EventArgs e)
        {
            com.app.business.CustomerMainWindowHandler getActiveOrders = new app.business.CustomerMainWindowHandler();
            //**********testing
            List<OrderProperties> listofOrders = getActiveOrders.getOrders(_currentUserSessionInformation.Vendor_ID, null);
            fillOrderDataGrid(listofOrders);

        }

        private void oRDERRETURNSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { 
            ConsignmentCompanyProject.windows.forms.OrderReturnForm orderReturnForm = new ConsignmentCompanyProject.windows.forms.OrderReturnForm(_currentUserSessionInformation);
               // orderReturnForm.MdiParent = this;
                orderReturnForm.ImeMode = this.ImeModeBase;
                orderReturnForm.Show();
            }catch(Exception exp)
            {
                Console.WriteLine(exp.StackTrace);
            }
        }

        private void aBOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBoxCustomer customerAbout = new AboutBoxCustomer();
           // customerAbout.MdiParent = this;
            customerAbout.ImeMode = this.ImeModeBase;
            customerAbout.Show();
                
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uSERPROFILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsignmentCompanyProject.windows.forms.UserProfileChangeForm userProfileChange = new ConsignmentCompanyProject.windows.forms.UserProfileChangeForm(_currentUserSessionInformation);
           // userProfileChange.MdiParent = this;
            userProfileChange.ImeMode = this.ImeModeBase;
            userProfileChange.Show();
            
        }

        private void textBoxCancelOrderId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
