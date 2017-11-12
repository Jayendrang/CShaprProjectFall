using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsignmentCompanyProject.com.app.model;

namespace ConsignmentCompanyProject
{
    public partial class Manufacturer : Form
    {
        public delegate void manufacturerOpertaions();

        public Manufacturer()
        {
            InitializeComponent();
        }

      

       
        private void Manufacturer_Load(object sender, EventArgs e)
        {

      
        }

        private void buttonAddManufacturer_Click(object sender, EventArgs e)
        {
            if (radioButtonAddNewManufacturer.Checked == true)
            {
                com.app.dataobjects.ManufacturerProperties manufacturerProperties = new com.app.dataobjects.ManufacturerProperties();
                com.app.dataobjects.UserInformationProperties userinfo = new com.app.dataobjects.UserInformationProperties();

                userinfo.User_Id = "JaY2234";

                manufacturerProperties.Manufacturer_Id = textBoxManufactureId.Text;
                manufacturerProperties.Manufacturer_Name = textBoxManufacturerName.Text;
                manufacturerProperties.Manufacturer_Detail = textBoxManfacturerDescriptions.Text;

                com.app.model.InventoryDBProcessHandler inventorydb = new InventoryDBProcessHandler();
                inventorydb.addNewManufacturer(manufacturerProperties, userinfo);

            }
        }
    }
}
