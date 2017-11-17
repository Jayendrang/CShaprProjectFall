using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsignmentCompanyProject.windows.forms;
using ConsignmentCompanyProject.com.app.dataobjects;
namespace ConsignmentCompanyProject
{
    static class Program
    {
        static UserInformationProperties userSessionData = new UserInformationProperties();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new com.windows.forms.CustomerMainWindow()); ;
            
        }
    }
}
