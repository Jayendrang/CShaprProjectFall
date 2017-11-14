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
using System.Data.SqlClient;
namespace ConsignmentCompanyProject.windows.forms
{
    public partial class NewUserRegistrationForm : Form
    {
        List<CustomerProperties> vendorsList = new List<CustomerProperties>();
        com.app.business.UserInformationHandler userInformationHandler = new com.app.business.UserInformationHandler();

        public NewUserRegistrationForm()
        {
            InitializeComponent();
        }

        private void groupBoxNewUser_Enter(object sender, EventArgs e)
        {

        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            UserInformationProperties userInformation = new UserInformationProperties();
            userInformation.Name = textBoxName.Text;
            userInformation.Contact = textBoxContact.Text;
            userInformation.Address = textBoxAddress.Text;
            userInformation.EMail_Id = textBoxEmailId.Text;
            userInformation.Status = "ACTIVE";
            userInformation.User_Id = textBoxGeneratedUsername.Text;
            userInformation.Password = textBoxGeneratedPassword.Text;
            
            if (radioButtonIsVendorYes.Checked == true)
            {
                comboBoxVendorName.Enabled = true;
                listBoxRoles.Enabled = false;
                userInformation.Is_Vendor = "TRUE";
                userInformation.Role = "VENDOR";
                CustomerProperties vendorDetails = userInformationHandler.getVendorInfo(comboBoxVendorName.SelectedItem.ToString());
                userInformation.Vendor_Name = vendorDetails.Vendor_Name;
                userInformation.Vendor_ID = vendorDetails.Vendor_Id;
            }
            else if (radioButtonIsVendorNo.Checked == true)
            {
                comboBoxVendorName.Enabled = false;
                listBoxRoles.Enabled = true;
                userInformation.Is_Vendor = "FALSE";
                userInformation.Role = listBoxRoles.SelectedIndex.ToString();
                userInformation.Vendor_ID = "N/A";
                userInformation.Vendor_Name = "N/A";
            }
            else
            {
                MessageBox.Show("Error", "Please provide user role!", MessageBoxButtons.OK);
            }

            com.app.business.UserInformationHandler userInfoHandler = new com.app.business.UserInformationHandler();
            userInformationHandler.addNewUser(userInformation, "JaY2234");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewUserRegistrationForm_Load(object sender, EventArgs e)
        {
            vendorsList = userInformationHandler.getVendorsList();

        }

        private void radioButtonIsVendorNo_CheckedChanged(object sender, EventArgs e)
        {
            listBoxRoles.Enabled = true;
            listBoxRoles.Items.Clear();
            if (radioButtonIsVendorNo.Checked)
            {
                listBoxRoles.Items.Add("STAFF");
                listBoxRoles.Items.Add("MANAGER");
                listBoxRoles.Items.Add("ADMIN");
            }
            comboBoxVendorName.Enabled = false;
        }

        private void radioButtonIsVendorYes_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxVendorName.Enabled = true;
            comboBoxVendorName.Items.Clear();
            if (radioButtonIsVendorYes.Checked)
            {
                foreach (CustomerProperties vendor in vendorsList)
                {
                    comboBoxVendorName.Items.Add(vendor.Vendor_Name);
                }
                listBoxRoles.Enabled = false;
            }
        }

        private void buttonGenerateCreds_Click(object sender, EventArgs e)
        {
            if ((!textBoxName.Text.Equals(null)) && (!textBoxContact.Text.Equals(null)))
            {
                textBoxGeneratedUsername.Text = com.app.utlitiy.BusinessUtlities.generateNewUserName(textBoxName.Text, textBoxContact.Text);
                textBoxGeneratedPassword.Text = com.app.utlitiy.BusinessUtlities.generateNewPassword();
            }
        }
    }
}
