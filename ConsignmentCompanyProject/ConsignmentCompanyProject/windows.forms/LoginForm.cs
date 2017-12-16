using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsignmentCompanyProject.com.app.utlitiy;
using ConsignmentCompanyProject.com.app.utilities;
using ConsignmentCompanyProject.com.app.business;
using ConsignmentCompanyProject.com.app.dataobjects;

namespace ConsignmentCompanyProject
{
    /*
     * Created by Jayendran Gurumoorthy
     * */

    public partial class Login : Form
    {
        LoginHandler loginHandler = new LoginHandler();
        SplashScreen splashscreen = new SplashScreen();

        public Login()
        {
            InitializeComponent();
            splashscreen.Show();
            textBoxUserName.MaxLength = 11;
            textBoxPassword.MaxLength = 20;      
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.TopMost = false;
            this.HelpButton = true;
            this.label1.Text = BusinessUtlities.getCurrentDateTime;
        }

        
        //Validate the user Credentials and load the user session information
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try { 
            UserInformationProperties _userSession = new UserInformationProperties();
            LoginProperties logindata = new LoginProperties();

            if ((FormValidationUtilities.fieldsMaxLength(textBoxUserName.Text, 12)) && (FormValidationUtilities.fieldsMaxLength(textBoxPassword.Text, 21))){ 
            if ((!FormValidationUtilities.nullCheck(textBoxUserName.Text)) && (!FormValidationUtilities.nullCheck(textBoxPassword.Text))) { 
                
            

            logindata.Username = textBoxUserName.Text.Trim();
            logindata.Password = textBoxPassword.Text.Trim();
            
                    // validating the userinformation in database and loading session data
            _userSession = loginHandler.validateUserCredentials(logindata);
            


            if (_userSession.User_Id!=null)
            {
                splashscreen.Hide();
                this.Enabled = false;
                this.Visible = false;

                if (_userSession.Role.Equals("MANAGER")) { 
                ManagerMainWindow managerWindow = new ManagerMainWindow(_userSession);
                        managerWindow.Text = "MANAGER DATASHBORD- "+_userSession.Name;
                managerWindow.Show();
                }else if(_userSession.Role.Equals("VENDOR"))
                {
                        com.windows.forms.CustomerMainWindow customerWindow = new com.windows.forms.CustomerMainWindow(_userSession);
                        customerWindow.Text = _userSession.Vendor_Name="-"+_userSession.Name;
                        customerWindow.Show();
                }
                        cancelErrorProvider();
               }
            else
            {
                        MessageBox.Show("Invalid Username/Password".ToUpper(), "Login failed".ToUpper(), MessageBoxButtons.OK,MessageBoxIcon.Error);
                        cancelErrorProvider();
            }
            }
           
            }else
            {
                errorProviderLogin.SetError(textBoxUserName, "Username should be less than 11 characters");    
            }
            }catch(BusinessExceptions loginException)
            {

                MessageBox.Show("INVALID USERNAME OR PASSWORD", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
                Console.WriteLine(loginException.Message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cancelErrorProvider()
        {
            errorProviderLogin.SetError(textBoxUserName, "");
            errorProviderLogin.SetError(textBoxPassword, "");
        }
    }
}
