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
    public partial class ManagerMainWindow : Form
    {   
        public void loadFormData(string name) {
            labelUserName.Text = name;

        }

        public ManagerMainWindow()
        {
            InitializeComponent();
        }

        private void ManagerMainWindow_Load(object sender, EventArgs e)
        {

        }

        private void ManagerMainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
