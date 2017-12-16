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
using ConsignmentCompanyProject.com.app.business;
using ConsignmentCompanyProject.com.app.utilities;
namespace ConsignmentCompanyProject
{
    /*
     * CREATED BY JAYENDRAN GURUMOORTHY
     * */

    public partial class CustomerManagementForm : Form
    {
        // DATA GRID INDEX NUMBER 
        private int _indexNumber = 0;
        //DELEGATE FOR GET VENDOR LIST FROM DB
        private delegate List<CustomerProperties> vendorListDelegate(string status);

        //GENERIC DELEGATE FOR ADDING NEW VENDOR INTO DB
        private delegate bool vendorDelegate<T>(T input1, string input2);

        //GENERIC DELEGATE FOR RETRIEVING SINGLE VENDOR FROM DB
        private delegate T searchVendorDelegate<T>(string vendorId);

        private UserInformationProperties _userSessionInformation;

        public CustomerManagementForm(object sessionData)
        {
            InitializeComponent();
            _userSessionInformation = (UserInformationProperties)sessionData;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //BUTTON NAME TEXT PROPERTY CHANGED TO ADD VENDOR WHEN RADIO BUTTON ADD NEW VENDOR CHECKED
        private void radioButtonAddNewVendor_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAddNewVendor.Checked == true)
            {
                textBoxCustomerId.Text = com.app.utlitiy.BusinessUtlities.getNewUniqueID("VENDOR", "VENDOR_ID");
            }
            textBoxCustomerId.ReadOnly = true;
            textBoxStatus.ReadOnly = true;
            textBoxCustomerName.ReadOnly = false;
            textBoxDiscountId.Text = "DIS5";
            textBoxDiscountRate.Text = "1";
            textBoxStatus.Text = "ACTIVE";
            buttonDynamicButton.Text = "&ADD";
            buttonSearchVendor.Enabled = false;
            buttonSearchVendor.Visible = false;
            listBoxStatus.Enabled = false;
            listBoxStatus.Visible = false;
        }

        //BUTTON NAME TEXT PROPERTY CHANGED TO MODIFY VENDOR INFO WHEN RADIO BUTTON MODIFY VENDOR CHECKED
        private void radioButtonModifyVendor_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCustomerId.ReadOnly = false;
            textBoxStatus.ReadOnly = false;
            clearFormContent();
            textBoxCustomerName.ReadOnly = true;
            buttonDynamicButton.Text = "&MODIFY";
            buttonSearchVendor.Enabled = true;
            buttonSearchVendor.Visible = true;
            listBoxStatus.Enabled = false;
            listBoxStatus.Visible = true;
        }

        //BUTTON NAME TEXT PROPERTY CHANGED TO DELETE VENDOR WHEN RADIO BUTTON DELETE VENDOR CHECKED
        private void radioButtonDeleteVendor_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCustomerId.ReadOnly = false;
            clearFormContent();
            textBoxCustomerName.ReadOnly = true;
            buttonDynamicButton.Text = "&DELETE";
            buttonSearchVendor.Enabled = true;
            buttonSearchVendor.Visible = true;
            listBoxStatus.Enabled = false;
            listBoxStatus.Visible = false; 
           textBoxStatus.ReadOnly = true;
        }

        //FORM LOAD
        private void VendorForm_Load(object sender, EventArgs e)
        {
            try
            {
                //DATA GRID VIEW HEADERS - START()
                dataGridViewVendorInformation.ColumnCount = 9;
                dataGridViewVendorInformation.Columns[0].Name = "#";
                dataGridViewVendorInformation.Columns[0].ReadOnly = true;
                dataGridViewVendorInformation.Columns[1].Name = "CUSTOMER ID";
                dataGridViewVendorInformation.Columns[1].ReadOnly = true;
                dataGridViewVendorInformation.Columns[2].Name = "NAME";
                dataGridViewVendorInformation.Columns[2].ReadOnly = true;
                dataGridViewVendorInformation.Columns[3].Name = "ADDRESS";
                dataGridViewVendorInformation.Columns[3].ReadOnly = true;
                dataGridViewVendorInformation.Columns[4].Name = "CONTACT";
                dataGridViewVendorInformation.Columns[4].ReadOnly = true;
                dataGridViewVendorInformation.Columns[5].Name = "EMAIL ID";
                dataGridViewVendorInformation.Columns[5].ReadOnly = true;
                dataGridViewVendorInformation.Columns[6].Name = "STATUS";
                dataGridViewVendorInformation.Columns[6].ReadOnly = true;
                dataGridViewVendorInformation.Columns[7].Name = "DISCOUNT ID";
                dataGridViewVendorInformation.Columns[7].ReadOnly = true;
                dataGridViewVendorInformation.Columns[8].Name = "BALANCE";
                dataGridViewVendorInformation.Columns[8].ReadOnly = true;
                //DATA GRID VIEW HEADERS - END()

                //SET RADIO BUTTON ACTIVE AS CHECKED TO RETRIEVE ACTIVE USES BY DEFAULT
                radioButtonStatusActive.Checked = true;
                radioButtonAddNewVendor.Checked = true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("CUSTOMER Form load exception", ex.Message);
            }
        }

        //DATA GRID VIEW ROWS 
        private void addDataToGridView(CustomerProperties vendorInfo, int indexNumber)
        {
            string[] vendorData = new string[] { indexNumber.ToString(), vendorInfo.Vendor_Id.ToString(),vendorInfo.Vendor_Name.ToString(),vendorInfo.Vendor_Address.ToString(),
            vendorInfo.Vendor_Contact.ToString(),vendorInfo.Vendor_EMail_Id.ToString(),vendorInfo.Vendor_Status.ToString(),vendorInfo.Vendor_Discount_ID.ToString(),vendorInfo.Vendor_Balance_Amount.ToString("c")};
            dataGridViewVendorInformation.Rows.Add(vendorData);

        }

        //RETRIEVE THE ACTIVE VENDORS
        private void radioButtonStatusActive_CheckedChanged(object sender, EventArgs e)
        {
            loadGridView();
        }

        //RETRIVE THE INACTIVE VENDORS
        private void radioButtonStatusInActive_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonStatusInActive.Checked == true)
            {
                _indexNumber = 0;
                dataGridViewVendorInformation.Rows.Clear();
                //Delegate 
                vendorListDelegate activeVendors = new vendorListDelegate(CustomerInformationHandler.getVendorsList);
                List<CustomerProperties> activeList = activeVendors.Invoke("DEACTIVATED");
                foreach (CustomerProperties props in activeList)
                {
                    ++_indexNumber;
                    addDataToGridView(props, _indexNumber);
                }
            }
        }

        //CLOSE THE WINDOW
        private void buttonCancelVender_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearchVendor_Click(object sender, EventArgs e)
        {
            
            CustomerProperties fieldValues = new CustomerProperties();
            DiscountProperties discountValues = new DiscountProperties();
            searchVendorDelegate<CustomerProperties> searchVendor = new searchVendorDelegate<CustomerProperties>(CustomerInformationHandler.searchVendor);
            searchVendorDelegate<DiscountProperties> discountInfoVendor = new searchVendorDelegate<DiscountProperties>(CustomerInformationHandler.getVendorDiscountInfo);
            
            if ((!textBoxCustomerId.Text.Equals(null) && (textBoxCustomerId.Text.Length > 0)))
            {
                fieldValues = searchVendor.Invoke(textBoxCustomerId.Text.ToUpper());
                if (fieldValues.Vendor_Id!=null) { 
                discountValues = discountInfoVendor.Invoke(fieldValues.Vendor_Discount_ID.ToUpper());
                textBoxContact.Text = fieldValues.Vendor_Contact;
                textBoxAddress.Text = fieldValues.Vendor_Address;
                textBoxCustomerName.Text = fieldValues.Vendor_Name;
                textBoxMailId.Text = fieldValues.Vendor_EMail_Id;
                textBoxDiscountRate.Text = discountValues.Discount_Rate;
                textBoxDiscountId.Text = discountValues.Discount_Id;
                        if (fieldValues.Vendor_Status == "ACTIVE")
                        {
                            listBoxStatus.Enabled = true;
                            listBoxStatus.Visible = true;
                            listBoxStatus.SelectedIndex = 0;

                        }else 
                        {
                            listBoxStatus.Enabled = true;
                            listBoxStatus.Visible = true;
                            listBoxStatus.SelectedIndex = 1;

                    
                    }
                    textBoxCustomerId.ReadOnly = true;
                }else
                {
                    
                    MessageBox.Show("INVALID VENDOR ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clearFormContent()
        {
            textBoxMailId.Clear();
            textBoxAddress.Clear();
            textBoxContact.Clear();
            textBoxDiscountId.Clear();
            textBoxDiscountRate.Clear();
            textBoxCustomerId.Clear();
            textBoxCustomerName.Clear();

        }

        private void buttonDynamicButton_Click(object sender, EventArgs e)
        {
            try { 
            if (radioButtonAddNewVendor.Checked == true)
            {
                //User defined delegate for adding new vendor in database
                vendorDelegate<CustomerProperties> addVendor = new vendorDelegate<CustomerProperties>(CustomerInformationHandler.addNewVendor);
                CustomerProperties newVendorData = new CustomerProperties();
                bool result = false;
                try
                {
                        if (!FormValidationUtilities.nullCheck(textBoxCustomerName.Text) && FormValidationUtilities.nullCheck(textBoxMailId.Text) && !FormValidationUtilities.emailCheck(textBoxMailId.Text) && FormValidationUtilities.mobileCheck(textBoxContact.Text))
                        {
                            newVendorData.Vendor_Id = textBoxCustomerId.Text.ToUpper();
                            newVendorData.Vendor_Name = textBoxCustomerName.Text.ToUpper();
                            newVendorData.Vendor_Contact = textBoxContact.Text.ToUpper();
                            newVendorData.Vendor_EMail_Id = textBoxMailId.Text.ToUpper();
                            newVendorData.Vendor_Address = textBoxAddress.Text.ToUpper();
                            newVendorData.Vendor_Discount_ID = textBoxDiscountId.Text;
                            newVendorData.Vendor_Balance_Amount = Convert.ToDouble("00.0");
                            newVendorData.Vendor_Status = textBoxStatus.Text.ToUpper();
                            //******************* testing
                            //delegate invoked
                            result = addVendor.Invoke(newVendorData, _userSessionInformation.User_Id);
                            if (result == true)
                            {
                                MessageBox.Show("New Vendor successfully".ToUpper(), "CUSTOMER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadGridView();
                            }
                            else
                            {
                                MessageBox.Show("Please provide the correct vendor details".ToUpper(), "CUSTOMER", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            }
                        }else
                        {
                            MessageBox.Show("INVALID FIELD VALUES","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Provide Appropriate values".ToUpper(), "CUSTOMER", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.StackTrace);
                        new BusinessExceptions("WRONG VENDOR NAME");
                }


            }
            else if (radioButtonModifyVendor.Checked == true)
            {
                CustomerProperties existingVendorData = new CustomerProperties();
                vendorDelegate<CustomerProperties> modifyVendor = new vendorDelegate<CustomerProperties>(CustomerInformationHandler.vendorInformationUpdate);
                bool result = false;
                try
                {
                    existingVendorData.Vendor_Id = textBoxCustomerId.Text.ToUpper();
                    existingVendorData.Vendor_Name = textBoxCustomerName.Text.ToUpper();
                    existingVendorData.Vendor_Contact = textBoxContact.Text.ToUpper();
                    existingVendorData.Vendor_EMail_Id = textBoxMailId.Text.ToUpper();
                    existingVendorData.Vendor_Address = textBoxAddress.Text.ToUpper();
                    existingVendorData.Vendor_Status = listBoxStatus.SelectedItem.ToString();
                    //******************* testing
                    //delegate invoked
                    result = modifyVendor.Invoke(existingVendorData, _userSessionInformation.User_Id);
                    if (result == true)
                    {
                        MessageBox.Show("Vendor details updated successfully".ToUpper(), "CUSTOMER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearFormContent();
                            loadGridView();
                        }
                    else
                    {
                        MessageBox.Show("Please provide the correct vendor details".ToUpper(), "CUSTOMER", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Provide Appropriate values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.StackTrace);
                }

            }
            else if (radioButtonDeleteVendor.Checked == true)
            {
                bool result = false;
                CustomerProperties existingVendorData = new CustomerProperties();
                vendorDelegate<CustomerProperties> deactivateVendor = new vendorDelegate<CustomerProperties>(CustomerInformationHandler.deactivateVendor);
                if (textBoxCustomerId.Text != null)
                {
                    existingVendorData.Vendor_Id = textBoxCustomerId.Text;
                    //********************* testing
                    //delegate invoked
                    result = deactivateVendor.Invoke(existingVendorData, _userSessionInformation.User_Id);
                    if (result == true)
                    {

                        MessageBox.Show("Vendor deactivated from system successfully".ToUpper(), "CUSTOMER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearFormContent();
                        loadGridView();

                    }
                }
            }
            clearFormContent();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        void loadGridView()
        {
            if (radioButtonStatusActive.Checked == true)
            {
                _indexNumber = 0;
                dataGridViewVendorInformation.Rows.Clear();
                //Delegate 
                vendorListDelegate activeVendors = new vendorListDelegate(CustomerInformationHandler.getVendorsList);
                List<CustomerProperties> activeList = activeVendors.Invoke("ACTIVE");
                foreach (CustomerProperties props in activeList)
                {
                    ++_indexNumber;
                    addDataToGridView(props, _indexNumber);
                }
            }
        }
    }

}
 
