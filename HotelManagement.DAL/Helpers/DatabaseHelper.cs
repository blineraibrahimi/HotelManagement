using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HotelManagement.DAL.Helpers
{
    public static class DatabaseHelper
    {
        public static SqlConnection GetSQLConnection()
        {
            return new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings.Get("sqlConnection"));
        }

        //private static readonly string _connectionString;

        static DatabaseHelper()
        {
            //_connectionString = GetSQLConnection();
        }

        //private static string GetConnectionString()
        //{
        //    var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
        //    var json = File.ReadAllText(path);
        //    var jObject = JObject.Parse(json);
        //    var connectionString = (string)jObject["ConnectionString"];
        //    return connectionString;
        //}

        public static DataTable ExecuteStoredProcedure(string storedProcedureName, SqlParameter[] parameters = null)
        {
            using (var connection = GetSQLConnection())
            {
                using (var command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    var adapter = new SqlDataAdapter(command);
                    var table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }
    }
}
