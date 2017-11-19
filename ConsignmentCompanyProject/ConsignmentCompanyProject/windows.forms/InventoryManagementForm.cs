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
    public partial class InventoryManagementForm : Form
    {
        private InvetoryManagementHandler inventoryManagementHandler;
        private List<ProductProperties> _PRODUCT_LIST_COMMMON = new List<ProductProperties>();
      
        private Dictionary<string, List<ProductProperties>> _MANUFACTURER_PRODUCT_DICTIONARY = new Dictionary<string, List<ProductProperties>>();
        private List<ManufacturerProperties> _MANUFACTURER_LIST = new List<ManufacturerProperties>();
        private UserInformationProperties _userSessionInformation;
        public InventoryManagementForm(object session)
        {
            InitializeComponent();
            inventoryManagementHandler = new InvetoryManagementHandler();
            _userSessionInformation = (UserInformationProperties)session;

        }

        private void Manufacturer_Load(object sender, EventArgs e)
        {

            refreshFormData();
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
            dataGridViewProductList.Columns[1].Name = "MANUFACTURER ID";
            dataGridViewProductList.Columns[1].ReadOnly = true;
            dataGridViewProductList.Columns[2].Name = "MANUFACTURER NAME";
            dataGridViewProductList.Columns[2].ReadOnly = true;
            dataGridViewProductList.Columns[3].Name = "PRODUCT ID";
            dataGridViewProductList.Columns[3].ReadOnly = true;
            dataGridViewProductList.Columns[4].Name = "PRODUCT NAME";
            dataGridViewProductList.Columns[4].ReadOnly = true;
            dataGridViewProductList.Columns[5].Name = "PRODUCT TYPE";
            dataGridViewProductList.Columns[5].ReadOnly = true;
            dataGridViewProductList.Columns[6].Name = "IN STOCK COUNT";
            dataGridViewProductList.Columns[6].ReadOnly = true;
            dataGridViewProductList.Columns[7].Name = "MINIMUM COUNT";
            dataGridViewProductList.Columns[7].ReadOnly = true;
            dataGridViewProductList.Columns[8].Name = "PRICE PER UNIT";
            dataGridViewProductList.Columns[8].ReadOnly = true;

            //default radio button selection

            radioButtonAddNewManufacturer.Checked = true;
            radioButtonActiveManufacturers.Checked = true;



           
            refreshProductList();
            fillProductsGridView(_PRODUCT_LIST_COMMMON);

            loadManufacturersComboBox();

            checkBoxNewProductType.Visible = false;
            checkBoxNewProductType.Enabled = false;

            textBoxNewProductType.Visible = false;
            textBoxNewProductType.Enabled = false;
            radioButtonAddNewProduct.Checked = true;



        }

        private void buttonAddManufacturer_Click(object sender, EventArgs e)
        {
            bool result = false;

            //************************ TESTING DATA
            string userInfo = _userSessionInformation.User_Id;

            try
            {
                if (radioButtonAddNewManufacturer.Checked)
                {
                    ManufacturerProperties manufacturerProperties = new ManufacturerProperties();


                    try
                    {
                        manufacturerProperties.Manufacturer_Id = textBoxManufactureId.Text;
                        manufacturerProperties.Manufacturer_Name = textBoxManufacturerName.Text;
                        manufacturerProperties.Manufacturer_Detail = textBoxManfacturerDescriptions.Text;
                        manufacturerProperties.Manufacturer_Status = textBoxStatus.Text;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("PLEASE PROVIDE APPROPRIATE VALUES", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine(ex.StackTrace);
                    }
                    result = inventoryManagementHandler.addNewManufacturer(manufacturerProperties, userInfo);
                    if (result)
                    {
                        fillManufacturersGridView(inventoryManagementHandler.getmanufacturersData("ACTIVE"));
                        MessageBox.Show("NEW MANUFACTURER ADDED SUCCESSFULLY", "MANUFACTURER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refreshProductList();
                        loadManufacturerGridView();
                        loadManufacturersComboBox();
                        
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

                        if (result)
                        {
                            MessageBox.Show("MANUFACTURER REMOVED SUCCESSFULLY", "MANUFACTURER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadManufacturerGridView();
                            loadManufacturersComboBox();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("PLEASE ENTER THE MANUFACTURER ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        Console.WriteLine(ex.StackTrace);

                    }
                }

            }
            catch (Exception ex) { Console.WriteLine("Validation exception occured", ex.StackTrace); }
        }

        private void radioButtonAddNewManufacturer_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAddNewManufacturer.Checked)
            {

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
                textBoxStatus.Enabled = true;
                textBoxStatus.Visible = true;
                textBoxManufactureId.Text = inventoryManagementHandler.getNewManufacturerId();

            }

        }

        private void radioButtonRemoveManufacturer_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRemoveManufacturer.Checked)
            {
                buttonDynamicAction.Text = "MODIFY";


                textBoxManufactureId.ReadOnly = false;
                textBoxManufacturerName.ReadOnly = true;
                textBoxManfacturerDescriptions.ReadOnly = true;

                textBoxStatus.Clear();
                textBoxManufacturerName.Clear();
                textBoxManfacturerDescriptions.Clear();
                textBoxManufactureId.Clear();

                textBoxStatus.ReadOnly = true;
                textBoxStatus.Enabled = false;
                textBoxStatus.Visible = false;
                comboBoxStatus.Visible = true;
                comboBoxStatus.Enabled = true;


            }

        }

        private void fillManufacturersGridView(List<ManufacturerProperties> manufacturerList)
        {
            int index = 0;
            try
            {
                dataGridViewManufacturers.Rows.Clear();
                foreach (ManufacturerProperties props in manufacturerList)
                {
                    ++index;
                    string[] rowData = new string[] { index.ToString(), props.Manufacturer_Id, props.Manufacturer_Name, props.Manufacturer_Detail, props.Manufacturer_Status };
                    dataGridViewManufacturers.Rows.Add(rowData);
                }

                dataGridViewManufacturers.CellClick += new DataGridViewCellEventHandler(ManufacturerGridView_CellClick);
            }
            catch (Exception ex) { Console.WriteLine(ex.StackTrace); }
        }

        private void fillProductsGridView(List<ProductProperties> productslist)
        {
            try { 
            dataGridViewProductList.Rows.Clear();
            int index = 0;
            foreach (ProductProperties props in productslist)
            {
                ++index;
                string[] rowData = new string[] { index.ToString(), props.Manufacturer_Id, props.Manufacturer_Name, props.Product_Id, props.Product_Name, props.Product_Type, props.Product_Current_Count.ToString(), props.Minimum_Count.ToString(), props.Price_Per_Unit.ToString() };
                dataGridViewProductList.Rows.Add(rowData);
            }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

        }

        private void ManufacturerGridView_CellClick(object sender, DataGridViewCellEventArgs args)
        {
            string manufacturerId = null;
            try
            {
                manufacturerId = dataGridViewManufacturers.Rows[args.RowIndex].Cells[1].Value.ToString();
                if ((manufacturerId.Contains("MAN") && (radioButtonRemoveManufacturer.Checked)))
                {
                    string status = null;
                    textBoxManufactureId.Text = dataGridViewManufacturers.Rows[args.RowIndex].Cells[1].Value.ToString();
                    textBoxManufacturerName.Text = dataGridViewManufacturers.Rows[args.RowIndex].Cells[2].Value.ToString();
                    textBoxManfacturerDescriptions.Text = dataGridViewManufacturers.Rows[args.RowIndex].Cells[3].Value.ToString();
                    status = dataGridViewManufacturers.Rows[args.RowIndex].Cells[4].Value.ToString();

                    if (status == "ACTIVE")
                    {
                        comboBoxStatus.SelectedIndex = 0;
                    }
                    else
                    {
                        comboBoxStatus.SelectedIndex = 1;
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Even Invoked", ex.StackTrace);
            }
        }

        private void radioButtonActiveManufacturers_CheckedChanged(object sender, EventArgs e)
        {
            loadManufacturerGridView();
            loadManufacturersComboBox();
        }

        private void radioButtonInactiveManufacturer_CheckedChanged(object sender, EventArgs e)
        {
            try { 
            List<ManufacturerProperties> inActiveManufacturerProperties = inventoryManagementHandler.getmanufacturersData("INACTIVE");
            if (!inActiveManufacturerProperties.Equals(null))
            {
                fillManufacturersGridView(inActiveManufacturerProperties);
            }
            else
            {
                MessageBox.Show("NO ACTIVE USERS AVAILABLE", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }



        private List<ProductProperties> getOneManufacturersProduct(string ManufacturersName, string productType)
        {
          
            List<ProductProperties> productsOfManufacturer = new List<ProductProperties>();
            try
            {
                if (!ManufacturersName.Equals(null))
            {
                foreach (ProductProperties singleProductInformation in _PRODUCT_LIST_COMMMON)
                {
                    if (singleProductInformation.Manufacturer_Name.Equals(ManufacturersName))
                    {
                        productsOfManufacturer.Add(singleProductInformation);
                    }
                }
            }
            else if ((!productType.Equals(null)) && (ManufacturersName.Length > 0))
            {

                foreach (ProductProperties singleProductInformation in _PRODUCT_LIST_COMMMON)
                {
                    if (singleProductInformation.Manufacturer_Name.Equals(ManufacturersName) && (singleProductInformation.Product_Type.Equals(productType)))
                    {
                        productsOfManufacturer.Add(singleProductInformation);
                    }

                }
            }

            else
            {
                productsOfManufacturer = null;
            }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            return productsOfManufacturer;
        }

        private void comboBoxManufacturerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
            if ((!comboBoxManufacturerName.SelectedItem.ToString().Equals(null)) && (comboBoxManufacturerName.SelectedItem.ToString().Length > 0))
            {
                List<ProductProperties> producTypeList = getOneManufacturersProduct(comboBoxManufacturerName.SelectedItem.ToString(), null);
                    if (checkBoxNewProductType.Checked == true) {

                        comboBoxProductType.SelectedText = "";
                        textBoxNewProductType.Enabled = true;
                        textBoxNewProductType.Visible = true;
                        textBoxNewProductType.ReadOnly = false;

                    }
                    else
                    {
                        comboBoxProductType.Items.Clear();
                        comboBoxProductType.Enabled = true;
                        comboBoxProductType.Visible = true;

                    }
                    if (!producTypeList.Equals(null))
                {
                    foreach (ProductProperties props in producTypeList)
                    {
                        if (!comboBoxProductType.Items.Contains(props.Product_Type))
                        {

                            comboBoxProductType.Items.Add(props.Product_Type);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("No Products available".ToUpper(), "PRODUCTS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
        private void loadManufacturersComboBox()
        {
            comboBoxManufacturerName.Items.Clear();
            foreach (ManufacturerProperties manufacturerName in _MANUFACTURER_LIST)
            {
                if (!comboBoxManufacturerName.Items.Contains(manufacturerName.Manufacturer_Name))
                {
                    comboBoxManufacturerName.Items.Add(manufacturerName.Manufacturer_Name);
                }

            }
        }

        private void comboBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ProductProperties> producTypeList = getOneManufacturersProduct(comboBoxManufacturerName.SelectedItem.ToString(), comboBoxProductType.SelectedItem.ToString());
            foreach (ProductProperties props in producTypeList)
            {
                if (props.Product_Name.Equals(comboBoxProductName.SelectedItem.ToString()))
                {
                    textBoxProductId.Text = props.Product_Id;
                    textBoxProductPerUnit.Text = props.Price_Per_Unit.ToString("c");
                    textBoxProductCurrentCount.Text = props.Product_Current_Count.ToString();

                }
            }

        }

        private void comboBoxProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxProductName.Clear();
            textBoxProductName.Visible = false;
            textBoxProductName.Enabled = false;
            comboBoxProductName.Enabled = true;
            comboBoxProductName.Visible = true;
            addItemsInComboBoxProductType();

        }

      
        private void addItemsInComboBoxProductType()
        {
            try
            {
                if ((!comboBoxManufacturerName.SelectedItem.ToString().Equals(null)) && (comboBoxManufacturerName.SelectedItem.ToString().Length > 0))
                {

                    List<ProductProperties> producTypeList = getOneManufacturersProduct(comboBoxManufacturerName.SelectedItem.ToString(), comboBoxProductType.SelectedItem.ToString());
                    comboBoxProductName.Items.Clear();

                    foreach (ProductProperties props in producTypeList)
                    {
                        if (props.Product_Type.Equals(comboBoxProductType.SelectedItem.ToString()))
                        {
                            comboBoxProductName.Items.Add(props.Product_Name);
                        }


                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                // MessageBox.Show("PLEASE SELECT THE MANUFACTURER","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Stop);

            }
        }



        private void buttonAddProducts_Click(object sender, EventArgs e)
        {
            ProductProperties newProduct = new ProductProperties();

            //***************testing
           
            bool result = false;
            if (radioButtonAddNewProduct.Checked)
            {
                try
                {
                    if (comboBoxManufacturerName.SelectedItem.ToString() != null)
                    {
                        foreach (ManufacturerProperties manufacturerProperties in _MANUFACTURER_LIST)
                        {
                            if (manufacturerProperties.Manufacturer_Name.Equals(comboBoxManufacturerName.SelectedItem.ToString()))
                            {
                                newProduct.Manufacturer_Id = manufacturerProperties.Manufacturer_Id; break;
                            }
                        }
                        if (checkBoxNewProductType.Checked == true)
                        {
                            newProduct.Product_Type = textBoxNewProductType.Text;
                        }
                        else
                        {
                            newProduct.Product_Type = comboBoxProductType.SelectedItem.ToString();
                        }
                        newProduct.Product_Id = textBoxProductId.Text;

                        newProduct.Product_Name = textBoxProductName.Text.ToUpper();
                        int initialCount = Convert.ToInt16(textBoxProductCurrentCount.Text);
                        
                        double productPrice = Convert.ToDouble(textBoxProductPerUnit.Text.Replace("$",""));
                        int minimumCount = Convert.ToInt16(textBoxMinimumCount.Text);
                        if (minimumCount <= 0)
                        {
                            MessageBox.Show("PLEASE SET THE MINIMUM COUNT","PRODUCT",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                            return;
                        }
                        if ((initialCount > 0) && (productPrice > 0) && (minimumCount > 0))
                        {
                            newProduct.Product_Current_Count = initialCount;
                            newProduct.Price_Per_Unit = productPrice;
                            newProduct.Minimum_Count = minimumCount;
                            result = inventoryManagementHandler.addNewProductInInventory(newProduct, _userSessionInformation.User_Id);

                            if (result)
                            {
                                MessageBox.Show("NEW PRODUCT ADDED IN INVENTORY SUCCESSFULLY", "INVENTORY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                refreshFormData();
                                refreshProductList();
                                fillProductsGridView(_PRODUCT_LIST_COMMMON);
                            }else
                            {
                                MessageBox.Show("NEW PRODUCT INSERTION FAILED, PLEASE CHECK THE FIELDS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else
                        {
                            MessageBox.Show("INVALID COUNT");
                        }
                       
                    }


                }
                catch (Exception exp)
                {
                    MessageBox.Show("INPUT ERROR, PLEASE PROVIDE PROPERVALUES", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(exp.StackTrace);
                }

            }
            else if (radioButtonUpdateProductUnit.Checked)
            {
                try
                {
                    double existingProductPrice = 0.0, newPrice=0.0;
                    int existingProductCount = 0, newUnitsCount=0;
                    ProductProperties updateProducts = new ProductProperties();
                    foreach(ProductProperties props in _PRODUCT_LIST_COMMMON) {
                        if (props.Manufacturer_Name.Equals(comboBoxManufacturerName.SelectedItem.ToString())){
                            updateProducts.Manufacturer_Id = props.Manufacturer_Id;
                            existingProductCount = props.Product_Current_Count;
                            existingProductPrice = props.Price_Per_Unit;
                            break;
                           }
                    }
                    updateProducts.Product_Type = comboBoxProductType.Text;
                    updateProducts.Product_Name = comboBoxProductName.Text;
                    updateProducts.Product_Id = textBoxProductId.Text;
                    updateProducts.Minimum_Count = Convert.ToInt16(textBoxMinimumCount.Text);
                    newPrice = Convert.ToDouble(textBoxProductPerUnit.Text.Replace("$", ""));
                    newUnitsCount = Convert.ToInt16(textBoxProductCurrentCount.Text);
                    if ((newUnitsCount>0) && (( newPrice> 0))) {
                        newPrice = existingProductPrice;
                        newUnitsCount = existingProductCount;
                        updateProducts.Product_Current_Count = newUnitsCount;
                        updateProducts.Price_Per_Unit = newPrice;
                        result = inventoryManagementHandler.updateProductFromInventory(updateProducts, _userSessionInformation.User_Id);
                        if (result)
                        {
                            MessageBox.Show("ITEM DETAILS UPDATED SUCCESSFULLY","PRODUCT",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            refreshFormData();
                            refreshProductList();
                            fillProductsGridView(_PRODUCT_LIST_COMMMON);
                        }
                    }else
                    {
                        MessageBox.Show("PLEASE PROVIDE PROPER VALUE","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
            }else if (radioButtonRemoveProduct.Checked)
            {
                try
                {
                    if (!textBoxProductId.Text.Equals(null))
                    {
                        ProductProperties removedProductProperty = new ProductProperties();
                        removedProductProperty.Product_Id = textBoxProductId.Text;
                        result = inventoryManagementHandler.removeProductFromInventory(removedProductProperty);
                        if (result)
                        {
                            MessageBox.Show("PRODUCT REMOVED SUCCESSFULLY","PRODUCT",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            refreshFormData();
                            refreshProductList();
                            fillProductsGridView(_PRODUCT_LIST_COMMMON);
                        }
                        else
                        {
                            MessageBox.Show("SELECT THE ITEM TO BE REMOVED FROM INVENTORY", "PRODUCT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }catch(Exception ex)
                {
                    ///**********
                    MessageBox.Show("",ex.Message);
                }
            }
        }

        private void radioButtonExistingType_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxNewProductType_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNewProductType.Checked)
            {
                textBoxNewProductType.Visible = true;
                textBoxNewProductType.Enabled = true;
                comboBoxProductType.Enabled = false;
                comboBoxProductType.Visible = false;

            }
            else
            {
                comboBoxProductType.Enabled = true;
                comboBoxProductType.Visible = true;
                textBoxNewProductType.Visible = false;
                textBoxNewProductType.Enabled = false;

                addItemsInComboBoxProductType();

            }
        }
        private void refreshProductList()
        {
            _PRODUCT_LIST_COMMMON = InventoryDBProcessHandler._product_list;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonUpdateProductUnit_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxNewProductType.Visible = false;
            checkBoxNewProductType.Enabled = false;
            textBoxProductId.Clear();
            textBoxProductId.Enabled = true;
            textBoxProductId.ReadOnly = true;
            buttonAddProducts.Text = "UPDATE INVENTORY";
            checkBoxNewProductType.Enabled = true;
            checkBoxNewProductType.Visible = false;
        }

        private void radioButtonRemoveProduct_CheckedChanged(object sender, EventArgs e)
        {

            checkBoxNewProductType.Visible = true;
            checkBoxNewProductType.Enabled = true;
            textBoxProductId.Clear();
            textBoxProductId.Enabled = false;
            textBoxProductId.ReadOnly = false;
            buttonAddProducts.Text = "REMOVE PRODUCT";
            checkBoxNewProductType.Enabled = false;
            checkBoxNewProductType.Visible = false;
        }
        private void radioButtonAddNewProduct_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxNewProductType.Enabled = true;
            checkBoxNewProductType.Visible = true;
            comboBoxProductName.Enabled = false;
            comboBoxProductName.Visible = false;
            textBoxProductName.Enabled = true;
            textBoxProductName.Visible = true;
            buttonAddProducts.Text = "ADD PRODUCT";
            textBoxProductId.ReadOnly = true;
            textBoxProductId.Text = inventoryManagementHandler.generateNewUniqueProductId();

        }
        private void loadManufacturerGridView()
        {
            try
            {
                List<ManufacturerProperties> activeManufacturerProperties = inventoryManagementHandler.getmanufacturersData("ACTIVE");
                _MANUFACTURER_LIST = activeManufacturerProperties;
                if (!activeManufacturerProperties.Equals(null))
                {
                    fillManufacturersGridView(activeManufacturerProperties);
                }
                else
                {
                    MessageBox.Show("DEAR USER PLEASE ADD YOUR FIRST MANUFACTURER", "WELCOME", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void refreshFormData()
        {
            _MANUFACTURER_PRODUCT_DICTIONARY = inventoryManagementHandler.getManufacturersProductInformation();
        }
    }
}
