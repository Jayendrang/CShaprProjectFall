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
using ConsignmentCompanyProject.com.app.business;
using ConsignmentCompanyProject.com.app.dataobjects;
namespace ConsignmentCompanyProject
{
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

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            UserInformationProperties _userSession = new UserInformationProperties();
            LoginProperties logindata = new LoginProperties();

            if ((textBoxUserName.Text != null) && (textBoxPassword.Text != null)) { 
            logindata.Username = textBoxUserName.Text;
            logindata.Password = textBoxPassword.Text;
            _userSession = loginHandler.validateUserCredentials(logindata);
            


            if (_userSession!=null)
            {
                splashscreen.Hide();
                this.Enabled = false;
                this.Visible = false;

                if (_userSession.Role.Equals("MANAGER")) { 
                ManagerMainWindow managerWindow = new ManagerMainWindow(_userSession);
                        managerWindow.Text = _userSession.Name;
                managerWindow.Show();
                }else if(_userSession.Role.Equals("VENDOR"))
                {
                        com.windows.forms.CustomerMainWindow customerWindow = new com.windows.forms.CustomerMainWindow(_userSession);
                        customerWindow.Text = _userSession.Vendor_Name;
                        customerWindow.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid Username/Password".ToUpper(), "Login failed".ToUpper(), MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            }
            else
            {
                MessageBox.Show("PLEASE PROVIDE USERNAME AND PASSWORD PROPERLY".ToUpper(), "Login failed".ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
