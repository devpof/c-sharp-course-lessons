using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataAccessLibrary
{
    public class SqlDataAccess
    {
        // You will need to install Dapper in this project.
        // Right Click Dependencies and then Manage Nuget
        // Browse and search for Dapper always use the latest stable version.

        public List<T> LoadData<T, U>(string sqlStatement, U parameters, string connectionString)
        {
            // using statement allows you to ensure that you are closing out connections properly regardless what happens.
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                // Query is the Dapper object (Read)
                // T is a model, that represents 1 row of data. Example: FirstName, LastName, Email, Phone
                // Normally, T is IEnumerable
                // parameters = if you need an Id to filter or no parameters
                List<T> rows = connection.Query<T>(sqlStatement, parameters).ToList();
                return rows;
            }
        }

        public void SaveData<T>(string sqlStatement, T parameters, string connectionString)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                // Execute is the Dapper object (Write)
                connection.Execute(sqlStatement, parameters);
            }
        }
    }
}
