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

namespace ConsignmentCompanyProject.windows.forms
{
    public partial class UserProfileChangeForm : Form
    {
        /*
         * Created by Jayendran Gurumoorthy
         * */
        private delegate T userInformationDelegate<T>(string userInfo);
        private delegate bool modifyInformationDelegate<T>(T userInfo);

        private UserInformationProperties userSessionInformation;

        public UserProfileChangeForm(object session)
        {
            InitializeComponent();
            userSessionInformation = (UserInformationProperties)session;
        }

        private void UserProfileChangeForm_Load(object sender, EventArgs e)
        {
            //get the current userid from session object
            //*********Testing
            string userId = "Jay11144205";
            if (userId!=null && userId.Length > 0)
            {
                try { 
                UserInformationProperties currentUserInfo = new UserInformationProperties();
                userInformationDelegate<UserInformationProperties> getUserInfo = new userInformationDelegate<UserInformationProperties>(UserInformationHandler.getUserProfileInformation);
                currentUserInfo=getUserInfo.Invoke(userSessionInformation.User_Id);
                textBoxnName.Text = currentUserInfo.Name;
                textBoxUserId.Text = currentUserInfo.User_Id;
                textBoxContact.Text = currentUserInfo.Contact;
                textBoxAddress.Text = currentUserInfo.Address;
                textBoxEmail.Text = currentUserInfo.EMail_Id;
                textBoxStatus.Text = currentUserInfo.Status;
                textBoxVendorName.Text = currentUserInfo.Vendor_Name;
                }catch(Exception ex) { Console.WriteLine("Form load error",ex.StackTrace); }
            }
            
        }

    

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserInformationProperties userInformation = new UserInformationProperties();
            modifyInformationDelegate<UserInformationProperties> modifyProfileInformation = new modifyInformationDelegate<UserInformationProperties>(UserInformationHandler.updateUserInformation);
            bool result = false;
            try
            {
                userInformation.User_Id = textBoxUserId.Text;
                userInformation.Contact = textBoxContact.Text;
                userInformation.Address = textBoxAddress.Text.ToUpper();
                userInformation.EMail_Id = textBoxEmail.Text.ToUpper();
                result = modifyProfileInformation.Invoke(userInformation);
                if (result)
                {
                    MessageBox.Show("Profile updated successfully","Profile",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Please enter appropriate values to the fields",ex.StackTrace);
            }
        }
    }
    
}
