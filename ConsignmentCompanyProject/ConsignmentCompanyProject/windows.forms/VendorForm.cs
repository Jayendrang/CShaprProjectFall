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
namespace ConsignmentCompanyProject
{
    /*
     * CREATED BY JAYENDRAN GURUMOORTHY
     * */

    public partial class VendorForm : Form
    {
        // DATA GRID INDEX NUMBER 
        private int _indexNumber = 0;
        //DELEGATE FOR GET VENDOR LIST FROM DB
        private delegate List<VendorProperties> vendorListDelegate(string status);

        //GENERIC DELEGATE FOR ADDING NEW VENDOR INTO DB
        private delegate bool vendorDelegate<T>(T input1, string input2);
        public VendorForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //BUTTON NAME WILL CHANGE BASED ON 
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonAddNewVendor.Checked == true)
            {
                //User defined delegate for adding new vendor in database
                vendorDelegate<VendorProperties> addVendor = new vendorDelegate<VendorProperties>(VendorBusinessHandler.addNewVendor);
                VendorProperties newVendorData = new VendorProperties();
                try
                {
                    newVendorData.Vendor_Id = textBoxVendorId.Text;
                    newVendorData.Vendor_Name = textBoxVendorName.Text;
                    newVendorData.Vendor_Contact = textBoxContact.Text;
                    newVendorData.Vendor_EMail_Id = textBoxMailId.Text;
                    newVendorData.Vendor_Address = textBoxAddress.Text;
                    newVendorData.Vendor_Discount_ID = textBoxDiscountId.Text;
                    newVendorData.Vendor_Balance_Amount = Convert.ToDouble("00.0");
                    newVendorData.Vendor_Status = "ACTIVE";
                    //******************* testing
                    //delegate invoked
                    addVendor.Invoke(newVendorData, "JaY2234");

                }catch(Exception ex) { MessageBox.Show("Provide Appropriate values","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Console.WriteLine(ex.StackTrace); }


            }else if (radioButtonModifyVendor.Checked == true)
            {

            }else if(radioButtonDeleteVendor.Checked == true)
            {

            }
        }

        //BUTTON NAME TEXT PROPERTY CHANGED TO ADD VENDOR WHEN RADIO BUTTON ADD NEW VENDOR CHECKED
        private void radioButtonAddNewVendor_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAddNewVendor.Checked == true)
            {
                textBoxVendorId.Text = com.app.utlitiy.BusinessUtlities.getNewUniqueID("VENDOR", "VENDOR_ID");
            }
            textBoxVendorId.ReadOnly = true;
            textBoxVendorName.ReadOnly = false;
            textBoxDiscountId.Text = "DIS5";
            textBoxDiscountRate.Text = "1";
            buttonDynamicButton.Text = "&ADD VENDOR";
        }

        //BUTTON NAME TEXT PROPERTY CHANGED TO MODIFY VENDOR INFO WHEN RADIO BUTTON MODIFY VENDOR CHECKED
        private void radioButtonModifyVendor_CheckedChanged(object sender, EventArgs e)
        {
            textBoxVendorId.ReadOnly = false;
            textBoxVendorId.Text = "";
            textBoxDiscountId.Text = "";
            textBoxDiscountRate.Text = "";
            textBoxVendorName.ReadOnly = true;
            buttonDynamicButton.Text = "&MODIFY VENDOR";
        }

        //BUTTON NAME TEXT PROPERTY CHANGED TO DELETE VENDOR WHEN RADIO BUTTON DELETE VENDOR CHECKED
        private void radioButtonDeleteVendor_CheckedChanged(object sender, EventArgs e)
        {
            textBoxVendorId.ReadOnly = false;
            textBoxVendorId.Text = "";
            textBoxDiscountId.Text = "";
            textBoxDiscountRate.Text = "";
            textBoxVendorName.ReadOnly = true;
            buttonDynamicButton.Text = "&DELETE VENDOR";
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
                dataGridViewVendorInformation.Columns[1].Name = "VENDOR ID";
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
                
            }
            catch(Exception ex)
            {
                Console.WriteLine("Vendor Form load exception", ex.Message);
            }
        }

        //DATA GRID VIEW ROWS 
        private void addDataToGridView(VendorProperties vendorInfo, int indexNumber)
        {
            string[] vendorData = new string[] { indexNumber.ToString(), vendorInfo.Vendor_Id.ToString(),vendorInfo.Vendor_Name.ToString(),vendorInfo.Vendor_Address.ToString(),
            vendorInfo.Vendor_Contact.ToString(),vendorInfo.Vendor_EMail_Id.ToString(),vendorInfo.Vendor_Status.ToString(),vendorInfo.Vendor_Discount_ID.ToString(),vendorInfo.Vendor_Balance_Amount.ToString("c")};
            dataGridViewVendorInformation.Rows.Add(vendorData);

        }

        //RETRIEVE THE ACTIVE VENDORS
        private void radioButtonStatusActive_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonStatusActive.Checked == true)
            {
                _indexNumber = 0;
                dataGridViewVendorInformation.Rows.Clear();
                //Delegate 
                vendorListDelegate activeVendors = new vendorListDelegate(VendorBusinessHandler.getVendorsList);
                List<VendorProperties> activeList= activeVendors.Invoke("ACTIVE");
                foreach(VendorProperties props in activeList)
                {
                    ++_indexNumber;
                    addDataToGridView(props, _indexNumber);
                }
            }
        }

        //RETRIVE THE INACTIVE VENDORS
        private void radioButtonStatusInActive_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonStatusInActive.Checked == true)
            {
                _indexNumber = 0;
                dataGridViewVendorInformation.Rows.Clear();
                //Delegate 
                vendorListDelegate activeVendors = new vendorListDelegate(VendorBusinessHandler.getVendorsList);
                List<VendorProperties> activeList = activeVendors.Invoke("INACTIVE");
                foreach (VendorProperties props in activeList)
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
    }
}
