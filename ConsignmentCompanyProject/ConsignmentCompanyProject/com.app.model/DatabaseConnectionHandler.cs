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
    /* Creted by Ankeeth Patnaik and Jayendran Gurumoorthy
     * This class handles all database operations. 
     */
    //This class handles the db query requsets from different classes in static
    class DatabaseConnectionHandler
    {
        private static SqlConnection dbConnection;
        
        //Reading Connection properties from App.Config file
        private static string _CONSIGNMENT_DB_STRING = ConfigurationManager.ConnectionStrings["ConsignmentCompanyProject.Properties.Settings.CONSIGNMENTDB"].ConnectionString;  
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
        //Close database connection
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

        //EXECUTE THE INSERT QUERY
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


        //Method to execute the update queries
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

        // METHOD TO EXECUTE THE DELETE QUERY
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
      
        //METHOD TO EXECUTE THE SELECT QUERY
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
               
                connectionAdapter = new SqlDataAdapter(command);
                
               connectionAdapter.Fill(resultSet);
              
                
            }catch(Exception exception) { Console.WriteLine(exception.StackTrace); }
            


            return resultSet;
        }


      

    }
}
