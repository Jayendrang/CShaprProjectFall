using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace ConsignmentCompanyProject.com.app.model
{
    class DatabaseConnectionHandler
    {
        private static SqlConnection dbConnection;
        private const string DB_CONNECTION_STRING = "Data Source=MSI;Initial Catalog=COSIGNMENT_DATABASE;Integrated Security=True";
         
        private static void openDbConnection()
        {
            try
            {
                dbConnection = new SqlConnection(DB_CONNECTION_STRING);
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
            finally
            {
                if (dbConnection != null)
                {
                    dbConnection = null;
                    
                }
            }
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

        public static T executeSelectDbQuery<T>(string selectQuery, List<KeyValuePair<String, String>> fieldValues, T returnObject) {
            SqlDataReader reader=null;
            try
            {
                openDbConnection();
                SqlCommand command = new SqlCommand(selectQuery, dbConnection);
                foreach(KeyValuePair<String, String> whereClauseValues in fieldValues)
                {
                    command.Parameters.AddWithValue(whereClauseValues.Key, whereClauseValues.Value);
                    
                }
                 reader = command.ExecuteReader();
                 reader.Close();
                closeDbConnection();
            }catch(SqlException excep) { Console.WriteLine(excep.StackTrace); }

            return returnObject;
            

        }

        public static void executeUpdateQuery(string updateQuery, List<KeyValuePair<String, String>> tableParamsValues)
        {
            try {

                openDbConnection();
                SqlCommand command = new SqlCommand(updateQuery, dbConnection);

                foreach (KeyValuePair<String, String> param in tableParamsValues)
                {
                    command.Parameters.AddWithValue(param.Key, param.Value);
                }
                command.ExecuteNonQuery();
                closeDbConnection();
                
            }
            catch (SqlException exception) { Console.WriteLine(exception.StackTrace); }

        } 

    }
}
