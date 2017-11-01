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
using ConsignmentCompanyProject.com.app.manager;
using ConsignmentCompanyProject.com.app.dataobjects;
namespace ConsignmentCompanyProject
{
    public partial class Login : Form
    {
       
        SplashScreen splashscreen = new SplashScreen();

        public Login()
        {
            InitializeComponent();
            splashscreen.Show();            
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
            LoginProperties logindata = new LoginProperties();
            logindata.Username = textBoxUserName.Text;
            logindata.Password = textBoxPassword.Text;
            LoginHandler loginhandler = new LoginHandler(logindata);
            bool val = loginhandler.validateUser();
            if (val)
            {
                splashscreen.Hide();
                this.Enabled = false;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Improper Username/Password", "Error", MessageBoxButtons.OK);

            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
