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


namespace ConsignmentCompanyProject.com.windows.forms
{
    public partial class OrdersDetailsForm : Form
    {
        private List<OrderProperties> _ListOfOrderItinerary = new List<OrderProperties>();
        private OrderProperties updateOrderProperties = new OrderProperties();
        private string currentUserInfo = null;
        public OrdersDetailsForm(object data,string userInfo)
        {
            currentUserInfo = userInfo;
            InitializeComponent();
            _ListOfOrderItinerary = (List<OrderProperties>)data;

        }

        
        private void ordersDetailsForm_Load(object sender, EventArgs e)
        {
            dataGridViewItinerary.ColumnCount = 12;
            
            dataGridViewItinerary.Columns[0].Name = "MANUFACTURER NAME";
            dataGridViewItinerary.Columns[0].ReadOnly = true;
            dataGridViewItinerary.Columns[1].Name = "PRODUCT TYPE";
            dataGridViewItinerary.Columns[1].ReadOnly = true;
            dataGridViewItinerary.Columns[2].Name = "PRODUCT NAME";
            dataGridViewItinerary.Columns[2].ReadOnly = true;
            dataGridViewItinerary.Columns[3].Name = "COUNT";
            dataGridViewItinerary.Columns[3].ReadOnly = true;
            dataGridViewItinerary.Columns[4].Name = "UNIT PRICE";
            dataGridViewItinerary.Columns[4].ReadOnly = true;
            dataGridViewItinerary.Columns[5].Name = "TOTAL PRICE";
            dataGridViewItinerary.Columns[5].ReadOnly = true;
            dataGridViewItinerary.Columns[6].Name = "BALANCE";
            dataGridViewItinerary.Columns[6].ReadOnly = true;
            dataGridViewItinerary.Columns[7].Name = "ADVANCE PAYMENT";
            dataGridViewItinerary.Columns[7].ReadOnly = true;
            dataGridViewItinerary.Columns[8].Name = "DISCOUNT RATE";
            dataGridViewItinerary.Columns[8].ReadOnly = true;
            dataGridViewItinerary.Columns[9].Name = "ORDER STATUS";
            dataGridViewItinerary.Columns[9].ReadOnly = true;
            dataGridViewItinerary.Columns[10].Name = "DESCRIPTION";
            dataGridViewItinerary.Columns[10].ReadOnly = true;
            dataGridViewItinerary.Columns[11].Name = "LAST UPDATED DATE";
            dataGridViewItinerary.Columns[11].ReadOnly = true;


        }

        public void loadDataGrid()
        {
            foreach(OrderProperties order in _ListOfOrderItinerary)
            {
                string[] rows = new string[] { order.Manufacturer_Name, order.Product_Type, order.Product_Name,
                order.Count.ToString(),order.Price_Per_Unit.ToString(),order.Balance_Amount.ToString(),order.Paid_Amount.ToString(),
                order.Discount_Rate,order.Order_Status,order.Description,order.OrderDate};
                dataGridViewItinerary.Rows.Add(rows);

                textBoxDate.Text = order.OrderDate.ToUpper();
                textBoxOrderId.Text = order.Order_Id.ToUpper();
                textBoxVendorId.Text = order.Vendor_Id.ToUpper();
                updateOrderProperties = order;

            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try { 
            string orderStatus = listBoxStatus.SelectedItem.ToString();
            ConsignmentCompanyProject.com.app.business.OrderHandler updateOrderHandler = new app.business.OrderHandler();
            updateOrderProperties.Order_Status = orderStatus;
            updateOrderProperties.User_ID = currentUserInfo;
            bool result= updateOrderHandler.updateOrderStatus(updateOrderProperties);
                if (result)
                {
                    MessageBox.Show("SUCCESSFULLY UPDATED");
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("PLEASE SELECT STATUS", "ORDER");
            }

        }
    }
}
