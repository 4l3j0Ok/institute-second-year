using System.Data;
using System.Diagnostics;
using _04_sql_to_combo.Controllers;
using Microsoft.Data.SqlClient;

namespace _04_sql_to_combo
{
    public static class Database
    {
        private static readonly string connectionString = Environment.GetEnvironmentVariable("SQL_SERVER_CONNECTION_STRING") ??
            throw new InvalidOperationException("La variable de entorno 'SQL_SERVER_CONNECTION_STRING' no se encuentra establecida");

        public static DataTable ExecuteRead(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // Crea un comando SQL en base a una query y una conexión para ejecutarla en la base de datos.
                    SqlCommand command = new SqlCommand(query, connection);
                    DataTable dt = new DataTable();
                    using (SqlDataReader reader = command.ExecuteReader())
                        dt.Load(reader);
                    return dt;
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(ex.Message);
                throw new MessageException($"Error al ejecutar la consulta SQL: {ex.Message}");
            }
        }

        public static void Execute(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                        command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(ex.Message);
                throw new MessageException($"Error al ejecutar la consulta SQL: {ex.Message}");
            }
        }
    }
}

