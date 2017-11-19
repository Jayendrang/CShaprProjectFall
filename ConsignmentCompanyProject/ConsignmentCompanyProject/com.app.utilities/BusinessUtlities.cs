using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsignmentCompanyProject.com.app.model;
namespace ConsignmentCompanyProject.com.app.utlitiy
{
    class BusinessUtlities
    {
        
        public static string getCurrentDateTime
        {
            get
            {
                string tempDateTime = DateTime.Now.ToString("MM/dd/yyyy");
                return tempDateTime;
            }

        }

        // Method used to retrieve last unique ID from tables
        private static string getLastUniqueID(string table, string uniqueId)
        {
            string lastUniqueKey = null;
            System.Data.DataSet dataset = new System.Data.DataSet();
            if ((table != null) && (uniqueId != null))
            {
                string queryString = "SELECT TOP 1 " + uniqueId + " FROM " + table + " ORDER BY " + uniqueId + " DESC";
                try
                {
                    dataset = DatabaseConnectionHandler.executeSelectQuery(queryString, null);

                    if (dataset != null)
                    {
                        foreach (System.Data.DataRow row in dataset.Tables[0].Rows)
                        {
                            lastUniqueKey = row[uniqueId.ToUpper()].ToString();
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
            return lastUniqueKey;
        }

        //Method used to generated new UniqueID from tables
        public static string getNewUniqueID(string table,string uniqueId)
        {
            string lastuniqueId = getLastUniqueID(table, uniqueId);
            string newuniqueId = null;
            if ((lastuniqueId != null) && (lastuniqueId.Length != 0))
            {
                int value = Convert.ToInt16(lastuniqueId.Substring(3));
                value += 1;
                string key = lastuniqueId.Substring(0, 3);
                newuniqueId =key+Convert.ToString(value);

            }else
            {
                string key = uniqueId.Substring(0, 3);
                int value = 1;
                newuniqueId = key + Convert.ToString(value);
            }
            return newuniqueId;
        }
        
        //Generate Username while registering with new user details
        public static string generateNewUserName(string name, string contact)
        {
            string userName = null;
            try
            {
                userName = name.Substring(0, 3) + com.app.utlitiy.BusinessUtlities.getCurrentDateTime.Replace("/", "").Substring(0, 3) + contact.Substring(4, 5);
            }
            catch (Exception ex) { Console.Write(ex.StackTrace); }
            return userName;
        }


        //Generate new password for new user while registration
        public static string generateNewPassword()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcedefghijklmnopqrstwxyz@!";
            return new string(Enumerable.Repeat(chars, 8)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }


    }

}
