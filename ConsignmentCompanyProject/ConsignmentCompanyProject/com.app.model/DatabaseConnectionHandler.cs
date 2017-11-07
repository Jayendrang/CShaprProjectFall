using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Configuration;
using ConsignmentCompanyProject.com.app.dataobjects;


namespace ConsignmentCompanyProject.com.app.model
{
    //This class handles the db query requsets from different classes in static
    class DatabaseConnectionHandler
    {
        private static SqlConnection dbConnection;
        //private static DataTable schemaTable;
        //private const string DB_CONNECTION_STRING = "Data Source=MSI;Initial Catalog=COSIGNMENT_DATABASE;Integrated Security=True";

        //Reading Connection properties from App.Config file
        private static string _CONSIGNMENT_DB_STRING = ConfigurationManager.ConnectionStrings["ConsignmentCompanyProject.Properties.Settings.ConsignmentStoreDBConnection"].ConnectionString;  
        // this method open the database connectivity with the mysql server .
        private static void openDbConnection()
        {
            try
            {
                dbConnection = new SqlConnection(_CONSIGNMENT_DB_STRING);
                dbConnection.Open();
                Console.WriteLine("Connection opened");
            }
            catch (Exception ex) {

                Console.WriteLine("DB Connection error",ex.StackTrace,ex.InnerException);

            }
            


        } 
        private static void closeDbConnection()
        {
            try { 
            dbConnection.Close();
                Console.WriteLine("Connection closed");
            } catch(Exception ex)
            {
                Console.WriteLine("DB connection close exception",ex.StackTrace, ex.InnerException);
            }
            finally { dbConnection = null; }
            
        }

        public static bool executeInsertDbQuery(string insertQuery, List<KeyValuePair<string, string>> tableParamsValues) {
            int numberOfRowsAffected = 0;
            try {
                openDbConnection();
                SqlCommand command = new SqlCommand(insertQuery, dbConnection);
                foreach(KeyValuePair<String,String> param in tableParamsValues)
                {
                    command.Parameters.AddWithValue(param.Key, param.Value);
                }
                numberOfRowsAffected = command.ExecuteNonQuery();
                closeDbConnection();
                Console.WriteLine("Query executed"); 
            }catch(SqlException exception)
            {
                Console.WriteLine("DB query execution exception",exception.StackTrace,exception.InnerException);
            }
            return numberOfRowsAffected <= 0 ? false : true;
          }



        public static bool executeUpdateQuery(string updateQuery, List<KeyValuePair<string, string>> tableParamsValues)
        {
            int numberofRowsUpdated=0;
            try {
                openDbConnection();
                SqlCommand command = new SqlCommand(updateQuery, dbConnection);

                foreach (KeyValuePair<string, string> param in tableParamsValues)
                {
                    command.Parameters.AddWithValue(param.Key, param.Value);
                }
                numberofRowsUpdated = command.ExecuteNonQuery();
                closeDbConnection();

            }
            catch (SqlException exception) { Console.WriteLine(exception.StackTrace); }

            return numberofRowsUpdated <= 0 ? false : true; 
        }

        public static bool executeDeleteQuery(string deleteQuery, List<KeyValuePair<string,string>> tableParamValues)
        {
            int numberofRowsDeleted = 0;
            try {
                openDbConnection();
                SqlCommand comman = new SqlCommand(deleteQuery, dbConnection);
                foreach(KeyValuePair<string,string> param in tableParamValues)
                {
                    comman.Parameters.AddWithValue(param.Key, param.Value);
                }
                numberofRowsDeleted = comman.ExecuteNonQuery();
                closeDbConnection();
            } catch(Exception ex) { Console.WriteLine(ex.StackTrace); }
            return numberofRowsDeleted <= 0 ? false : true;

        }
      
        public static DataSet executeSelectQuery(string queryString, List<KeyValuePair<string,string>> tableParams)
        {
            DataSet resultSet = new DataSet();
            DataTable dataTable = new DataTable();
            SqlConnection connection;
            SqlDataAdapter connectionAdapter;
            
            try
            {

                connection = new SqlConnection(_CONSIGNMENT_DB_STRING);
                SqlCommand command = new SqlCommand(queryString,connection);
                if (tableParams != null)
                {
                    foreach (KeyValuePair<string, string> whereClauseValues in tableParams)
                    {
                        command.Parameters.AddWithValue(whereClauseValues.Key, whereClauseValues.Value);

                    }
                }
                connection.Open();
                connectionAdapter = new SqlDataAdapter(command);
                connectionAdapter.Fill(resultSet);
                connection.Close();
                
            }catch(Exception exception) { Console.WriteLine(exception.StackTrace); }
            


            return resultSet;
        }

        protected static List<object> returnSetWithProperties (DataSet dataset, object dataObjectType)
        {
            List<object> resultProperties = new List<object>();
            
            
            if (dataObjectType is ManufacturerProperties)
            {
                
                List<ProductProperties> listOfPropperties = new List<ProductProperties>();
                foreach(DataRow row in dataset.Tables[0].Rows)
                {
                    ProductProperties propertyvalue = new ProductProperties();
                    propertyvalue.Product_Id = row["Product_Id"].ToString();
                    propertyvalue.Product_Type = row["Product_Id"].ToString();
                    propertyvalue.Product_Name = row["Product_Name"].ToString();
                    propertyvalue.Price_Per_Unit = double.Parse(row["Price_Per_Unit"].ToString());
                    propertyvalue.Product_Current_Count = int.Parse(row["Product_Current_Count"].ToString());
                    propertyvalue.Manufacturer_Name = row["Manufacturer_Name"].ToString();
                    propertyvalue.Manufacturer_Id = row["Manufacturer_Id"].ToString();    
                    
                  resultProperties.Add(propertyvalue);      
                }
                
            }

            return resultProperties;
        }

    }
}
