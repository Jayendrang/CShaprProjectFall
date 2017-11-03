using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsignmentCompanyProject.com.app.model
{
    class DatabaseConnectionHandler
    {
        private static SqlConnection dbConnection;
        //private static DataTable schemaTable;
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

        public static List<object> executeSelectDbQuery<T>(string selectQuery, List<KeyValuePair<string,string>> fieldValues, T dataObject) {

            SqlDataReader reader = null;
            List<object> resultSet = new List<object>();
            int readerIndex = 0;
            try
            {
                openDbConnection();

                SqlCommand command = new SqlCommand(selectQuery, dbConnection);
                foreach (KeyValuePair<string, string> whereClauseValues in fieldValues)
                {
                    command.Parameters.AddWithValue(whereClauseValues.Key, whereClauseValues.Value);

                }
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //refelection         
                        object tableData = dataObject;
                        PropertyInfo[] classProperties = tableData.GetType().GetProperties();
                        
                        foreach (PropertyInfo properties in classProperties)
                        {   
                            properties.SetValue(tableData, reader[properties.Name]);
                            Console.WriteLine("Data storage Object type{0} :", tableData.GetType().Name);
                            readerIndex++;
                        }
                        resultSet.Add(tableData);

                    }
                }
                reader.Close();
                closeDbConnection();
            }
            catch (Exception e) { Console.WriteLine(e.StackTrace); }

            return resultSet;
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
