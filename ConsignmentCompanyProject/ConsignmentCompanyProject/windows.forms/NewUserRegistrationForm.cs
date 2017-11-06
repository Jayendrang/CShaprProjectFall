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
            if (radioButtonIsVendorYes.Checked == true)
            {
                comboBoxVendorName.Enabled = true;
                listBoxRoles.Enabled = false;
                userInformation.Is_Vendor = "TRUE";
                userInformation.Role = "VENDOR USER";

            }else if(radioButtonIsVendorNo.Checked==true)
            {
                comboBoxVendorName.Enabled = false;
                userInformation.Is_Vendor = "FALSE";
            }else
            {
                MessageBox.Show("Error","Please provide user role!", MessageBoxButtons.OK);
            }


            List<KeyValuePair<string, string>> kvl = new  List<KeyValuePair<string, string>>();
            string Insertquery = "INSERT INTO USER_TABLE VALUES(@NAME, @CONTACT, @ADDRESS, @EMAIL_ID, @USER_ID, @PASSWORD, @ROLE, @IS_VENDOR, @VENDOR_ID, @VENDOR_NAME, @STATUS, @CREATED_BY, @CREATED_DATE, @MODIFIED_BY, @MODIFIED_DATE)";

            kvl.Add(new KeyValuePair<string, string>("@NAME", "gurumoorthy"));
            kvl.Add(new KeyValuePair<string, string>("@CONTACT", "4795223290"));
            kvl.Add(new KeyValuePair<string, string>("@ADDRESS", "THAJAVUR"));
            kvl.Add(new KeyValuePair<string, string>("@EMAIL_ID", "RKKADO@GMAIL.COM"));
            kvl.Add(new KeyValuePair<string, string>("@USER_ID", "MANAGER50"));
            kvl.Add(new KeyValuePair<string, string>("@PASSWORD", "RAKKYRO"));
            kvl.Add(new KeyValuePair<string, string>("@ROLE", "MANAGER"));
            kvl.Add(new KeyValuePair<string, string>("@IS_VENDOR", "FALSE"));
            kvl.Add(new KeyValuePair<string, string>("@VENDOR_NAME", "N/A"));
            kvl.Add(new KeyValuePair<string, string>("@VENDOR_ID", "N/A"));
            kvl.Add(new KeyValuePair<string, string>("@STATUS", "ACTIVE"));
            kvl.Add(new KeyValuePair<string, string>("@CREATED_BY", "ADMIN123"));
            kvl.Add(new KeyValuePair<string, string>("@CREATED_DATE", "10/11/2017"));
            kvl.Add(new KeyValuePair<string, string>("@MODIFIED_BY", "ADMIN123"));
            kvl.Add(new KeyValuePair<string, string>("@MODIFIED_DATE", "10/11/2017"));

          
            DatabaseConnectionHandler.executeInsertDbQuery(Insertquery,kvl);    
                
                }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            listBoxRoles.Items.Add("STAFF");
            listBoxRoles.Items.Add("MANAGER");
            listBoxRoles.Items.Add("ADMIN");
        }
    }
}
