using ConsignmentCompanyProject.com.app.business;
using ConsignmentCompanyProject.com.app.dataobjects;
using ConsignmentCompanyProject.com.app.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ConsignmentCompanyProject
{
    public partial class InventoryManagement : Form
    {
        private InvetoryManagementHandler inventoryManagementHandler;
        public InventoryManagement()
        {
            inventoryManagementHandler = new InvetoryManagementHandler() ;
            
            InitializeComponent();

            }
       
        private void Manufacturer_Load(object sender, EventArgs e)
        {
            //default radio button selection

            //Data grid manufacturer headers

            dataGridViewManufacturers.ColumnCount = 5;
            dataGridViewManufacturers.Columns[0].Name = "#";
            dataGridViewManufacturers.Columns[0].ReadOnly = true;
            dataGridViewManufacturers.Columns[1].Name = "MANUFACTURER ID";
            dataGridViewManufacturers.Columns[1].ReadOnly = true;
            dataGridViewManufacturers.Columns[2].Name = "MANUFACTURER NAME";
            dataGridViewManufacturers.Columns[2].ReadOnly = true;
            dataGridViewManufacturers.Columns[3].Name = "DESCRIPTIONS";
            dataGridViewManufacturers.Columns[3].ReadOnly = true;
            dataGridViewManufacturers.Columns[4].Name = "STATUS";
            dataGridViewManufacturers.Columns[4].ReadOnly = true;

            //Data grid product list headers

            dataGridViewProductList.ColumnCount = 9;
            dataGridViewProductList.Columns[0].Name = "#";
            dataGridViewProductList.Columns[0].ReadOnly = true;
            dataGridViewProductList.Columns[1].Name = "PRODUCT ID";
            dataGridViewProductList.Columns[1].ReadOnly = true;
            dataGridViewProductList.Columns[2].Name = "PRODUCT NAME";
            dataGridViewProductList.Columns[2].ReadOnly = true;
            dataGridViewProductList.Columns[3].Name = "PRODUCT TYPE";
            dataGridViewProductList.Columns[3].ReadOnly = true;
            dataGridViewProductList.Columns[4].Name = "MANUFACTURER ID";
            dataGridViewProductList.Columns[4].ReadOnly = true;
            dataGridViewProductList.Columns[5].Name = "MANUFACTURER NAME";
            dataGridViewProductList.Columns[5].ReadOnly = true;
            dataGridViewProductList.Columns[6].Name = "IN STOCK COUNT";
            dataGridViewProductList.Columns[6].ReadOnly = true;
            dataGridViewProductList.Columns[7].Name = "MINIMUM COUNT";
            dataGridViewProductList.Columns[7].ReadOnly = true;
            dataGridViewProductList.Columns[8].Name = "PRICE PER UNIT";
            dataGridViewProductList.Columns[8].ReadOnly = true;

            radioButtonAddNewManufacturer.Checked = true;
            radioButtonActiveManufacturers.Checked = true;


            inventoryManagementHandler.getManufacturersProducts();
            fillProductsGridView(InventoryDBProcessHandler.PRODUCT_LIST);
            
        }

        private void buttonAddManufacturer_Click(object sender, EventArgs e)
        {
            bool result = false;

            //************************ TESTING DATA
            string userInfo = "JaY2234";

            try { 
            if (radioButtonAddNewManufacturer.Checked)
            {
                    ManufacturerProperties manufacturerProperties = new ManufacturerProperties();
                    

                    try
                    { 
                              manufacturerProperties.Manufacturer_Id = textBoxManufactureId.Text;
                              manufacturerProperties.Manufacturer_Name = textBoxManufacturerName.Text;
                              manufacturerProperties.Manufacturer_Detail = textBoxManfacturerDescriptions.Text;
                              manufacturerProperties.Manufacturer_Status = textBoxStatus.Text;
                    }catch(Exception ex) {
                        MessageBox.Show("PLEASE PROVIDE APPROPRIATE VALUES","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        Console.WriteLine(ex.StackTrace);
                    }
                            result=inventoryManagementHandler.addNewManufacturer(manufacturerProperties,userInfo);
                    if (result)
                    {
                        MessageBox.Show("NEW MANUFACTURER ADDED SUCCESSFULLY", "MANUFACTURER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
            }
            else if (radioButtonRemoveManufacturer.Checked)
                {
                    ManufacturerProperties manufacturerProperties = new ManufacturerProperties();
                    try
                    {
                        manufacturerProperties.Manufacturer_Id = textBoxManufactureId.Text;
                        manufacturerProperties.Manufacturer_Name = textBoxManufacturerName.Text;
                        manufacturerProperties.Manufacturer_Detail = textBoxManfacturerDescriptions.Text;
                        manufacturerProperties.Manufacturer_Status = comboBoxStatus.SelectedItem.ToString();
                        result = inventoryManagementHandler.removeManufacturer(manufacturerProperties, userInfo);
                    }catch(Exception ex)
                    {
                        MessageBox.Show("PLEASE ENTER THE MANUFACTURER ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine(ex.StackTrace);

                    }        
                }
            else if(radioButtonSearchManufacturer.Checked)
                {

                }
            }catch(Exception ex) { Console.WriteLine("Validation exception occured",ex.StackTrace); }
        }

        private void radioButtonAddNewManufacturer_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAddNewManufacturer.Checked) {

                buttonDynamicAction.Text = "ADD MANUFACTURER";
                textBoxStatus.Text = "ACTIVE";
                textBoxManufactureId.ReadOnly = true;
                textBoxManufacturerName.ReadOnly = false;
                textBoxManfacturerDescriptions.ReadOnly = false;
                textBoxManufacturerName.Clear();
                textBoxManfacturerDescriptions.Clear();
                textBoxStatus.ReadOnly = true;
                comboBoxStatus.Visible = false;
                comboBoxStatus.Enabled = false;
                textBoxManufactureId.Text = inventoryManagementHandler.getNewManufacturerId();

            }

        }

        private void radioButtonRemoveManufacturer_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRemoveManufacturer.Checked)
            {
                buttonDynamicAction.Text = "MODIFY";
                
                textBoxManufactureId.Clear();
                textBoxManufactureId.ReadOnly = false;
                textBoxManufacturerName.ReadOnly = true;
                textBoxManfacturerDescriptions.ReadOnly = true;
                textBoxStatus.Clear();
                textBoxManufacturerName.Clear();
                textBoxManfacturerDescriptions.Clear();

                textBoxStatus.ReadOnly = true;
                textBoxStatus.Enabled = false;
                textBoxStatus.Visible = false;
                comboBoxStatus.Visible = true;
                comboBoxStatus.Enabled = true;

            }

        }

        private void radioButtonSearchManufacturer_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSearchManufacturer.Checked)
            {
                buttonDynamicAction.Text = "SEARCH";
                textBoxManufactureId.Clear();
                textBoxManufacturerName.Clear();
                textBoxManfacturerDescriptions.Clear();
                textBoxManufactureId.ReadOnly = false;
                textBoxManufacturerName.ReadOnly = true;
                textBoxManfacturerDescriptions.ReadOnly = true;
                textBoxStatus.ReadOnly = false;
            }
        }

        private void fillManufacturersGridView(List<ManufacturerProperties> manufacturerList)
        {
            int index=0;
            try {
                dataGridViewManufacturers.Rows.Clear();    
            foreach(ManufacturerProperties props in manufacturerList) {
                ++index;
                string[] rowData = new string[] { index.ToString(), props.Manufacturer_Id, props.Manufacturer_Name, props.Manufacturer_Detail, props.Manufacturer_Status};
                    dataGridViewManufacturers.Rows.Add(rowData);
            }

            dataGridViewManufacturers.CellClick += new DataGridViewCellEventHandler(ManufacturerGridView_CellClick);
            }catch(Exception ex) { Console.WriteLine(ex.StackTrace); }
      }

        private void fillProductsGridView(List<ProductProperties> productslist)
        {

            int index = 0;
            foreach(ProductProperties props in productslist)
            {
                ++index;
                string[] rowData = new string[] { index.ToString(),props.Manufacturer_Id, props.Manufacturer_Name, props.Product_Id, props.Product_Name, props.Product_Type, props.Product_Current_Count.ToString(), props.Minimum_Count.ToString(),props.Price_Per_Unit.ToString() };
                dataGridViewProductList.Rows.Add(rowData);
            }

        }

        private void ManufacturerGridView_CellClick(object sender, DataGridViewCellEventArgs args)
        {
            string manufacturerId = null;
            try
            {
                manufacturerId = dataGridViewManufacturers.Rows[args.RowIndex].Cells[1].Value.ToString();
                if (manufacturerId.Contains("MAN") && (radioButtonRemoveManufacturer.Checked))
                {
                    string status = null;
                    textBoxManufactureId.Text = dataGridViewManufacturers.Rows[args.RowIndex].Cells[1].Value.ToString();
                    textBoxManufacturerName.Text = dataGridViewManufacturers.Rows[args.RowIndex].Cells[2].Value.ToString();
                    textBoxManfacturerDescriptions.Text = dataGridViewManufacturers.Rows[args.RowIndex].Cells[3].Value.ToString();
                    status = dataGridViewManufacturers.Rows[args.RowIndex].Cells[4].Value.ToString();
                    if (comboBoxStatus.Enabled)
                    {
                        if (status.Equals("ACTIVE")) { 
                        comboBoxStatus.SelectedIndex = 0;
                        }
                        else
                        {
                            comboBoxStatus.SelectedIndex = 1;
                        }
                    }
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine("Even Invoked", ex.StackTrace);
            }
        }

        private void radioButtonActiveManufacturers_CheckedChanged(object sender, EventArgs e)
        {
            fillManufacturersGridView(inventoryManagementHandler.getmanufacturersData("ACTIVE"));

        }

        private void radioButtonInactiveManufacturer_CheckedChanged(object sender, EventArgs e)
        {
            fillManufacturersGridView(inventoryManagementHandler.getmanufacturersData("INACTIVE"));

        }
    }
}
