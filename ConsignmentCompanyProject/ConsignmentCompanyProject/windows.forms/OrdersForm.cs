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
namespace ConsignmentCompanyProject
{
    public partial class Orders : Form
    {

        public Orders()
        {
            InitializeComponent();
        }

        private void addToCartDataGridLoad(OrderProperties orderItems)
        {
            string[] cartRow = new string[] { orderItems.Order_Id.ToString(), orderItems.Product_Type, orderItems.Manufacturer_Name, orderItems.Product_Name, orderItems.Price_Per_Unit.ToString(), orderItems.Count.ToString(), orderItems.Total_Price.ToString() };
            dataGridViewCart.Rows.Add(cartRow);
        }
        
        private void panelOrder_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void groupBoxOrderDetails_Enter(object sender, EventArgs e)
        {

        }

        private void Orders_Load(object sender, EventArgs e)
        {
            dataGridViewCart.ColumnCount = 7;
            dataGridViewCart.Columns[0].Name = "ORDER ID";
            dataGridViewCart.Columns[1].Name = "PRODUCT TYPE";
            dataGridViewCart.Columns[2].Name = "MANUFACTURER";
            dataGridViewCart.Columns[3].Name = "PRODCUT NAME";
            dataGridViewCart.Columns[4].Name = "PRICE PER UNIT";
            dataGridViewCart.Columns[5].Name = "COUNT";
            dataGridViewCart.Columns[6].Name = "TOTAL";

        }

        private void buttonSubmitOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
