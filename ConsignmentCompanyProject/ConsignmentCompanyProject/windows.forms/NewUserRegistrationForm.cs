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
using ConsignmentCompanyProject.com.app.utilities;
namespace ConsignmentCompanyProject.windows.forms
{
    public partial class NewUserRegistrationForm : Form
    {
        private List<CustomerProperties> vendorsList = new List<CustomerProperties>();
        private com.app.business.UserInformationHandler userInformationHandler = new com.app.business.UserInformationHandler();
        private UserInformationProperties userSessionInformation;
        public NewUserRegistrationForm(object sessionData)
        {
            InitializeComponent();
            userSessionInformation = (UserInformationProperties)sessionData;

        }

        private void groupBoxNewUser_Enter(object sender, EventArgs e)
        {

        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            bool result = false;
            try{
            UserInformationProperties userInformation = new UserInformationProperties();
            userInformation.Name = textBoxName.Text.ToUpper();
                if (FormValidationUtilities.mobileCheck(textBoxContact.Text))
                {
                    userInformation.Contact = textBoxContact.Text.ToUpper();
                }
                else
                {
                    MessageBox.Show("INVALID CONTACT NUMBER", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                userInformation.Address = textBoxAddress.Text.ToUpper();
                if (FormValidationUtilities.emailCheck(textBoxEmailId.Text)) {
                    userInformation.EMail_Id = textBoxEmailId.Text.ToUpper();
                }else
                {
                    MessageBox.Show("INVALID EMAIL ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            
            userInformation.Status = "ACTIVE";
            userInformation.User_Id = textBoxGeneratedUsername.Text;
            userInformation.Password = textBoxGeneratedPassword.Text;
            
            if (radioButtonIsVendorYes.Checked == true)
            {
                comboBoxVendorName.Enabled = true;
                listBoxRoles.Enabled = false;
                userInformation.Is_Vendor = "TRUE";
                userInformation.Role = "VENDOR";
                CustomerProperties vendorDetails = userInformationHandler.getCustomerInfo(comboBoxVendorName.SelectedItem.ToString());
                userInformation.Vendor_Name = vendorDetails.Vendor_Name.ToUpper();
                userInformation.Vendor_ID = vendorDetails.Vendor_Id.ToUpper();
            }
            else if (radioButtonIsVendorNo.Checked == true)
            {
                comboBoxVendorName.Enabled = false;
                listBoxRoles.Enabled = true;
                userInformation.Is_Vendor = "FALSE";
                userInformation.Role = listBoxRoles.SelectedIndex.ToString().ToUpper();
                userInformation.Vendor_ID = "N/A";
                userInformation.Vendor_Name = "N/A";
            }
            else
            {
                MessageBox.Show("Error", "Please provide user role!", MessageBoxButtons.OK);
            }

            com.app.business.UserInformationHandler userInfoHandler = new com.app.business.UserInformationHandler();
                ///*************testing
               result= userInformationHandler.addNewUser(userInformation, userSessionInformation.User_Id);

                if (result)
                {
                    MessageBox.Show( "NEW USER ADDED SUCESSFULLY","USER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("PLEASE FILL THE DETAILS PROPERLY","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);          
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewUserRegistrationForm_Load(object sender, EventArgs e)
        {
            vendorsList = userInformationHandler.getCustomerList();
            radioButtonIsVendorYes.Checked = true;

        }

        private void radioButtonIsVendorNo_CheckedChanged(object sender, EventArgs e)
        {
            listBoxRoles.Enabled = true;
            listBoxRoles.Items.Clear();
            if (radioButtonIsVendorNo.Checked)
            {
            
                listBoxRoles.Items.Add("MANAGER");
                
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
            if ((!textBoxName.Text.Equals(null)) && (textBoxContact.Text.Length>0))
            {
                textBoxGeneratedUsername.Text = com.app.utlitiy.BusinessUtlities.generateNewUserName(textBoxName.Text, textBoxContact.Text);
                textBoxGeneratedPassword.Text = com.app.utlitiy.BusinessUtlities.generateNewPassword();
            }else
            {
                MessageBox.Show("PLEASE FILL THE REGISTRATION FORM","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
        }
    }
}
