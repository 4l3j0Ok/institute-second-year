using System.Data;
using System.Diagnostics;
using Microsoft.Data.SqlClient;

namespace _04_sql_to_combo
{
    public static class Database
    {
        private static SqlConnection connection = new SqlConnection(Environment.GetEnvironmentVariable("SQLSERVER_CONNECTION_STRING"));
        public static void OpenDatabase()
        {
            try
            {
                if (connection.State.Equals(ConnectionState.Open))
                    throw new Exception("La conexión a la base de datos ya está abierta.");
                Debug.WriteLine($"Conectando a la base de datos con la cadena de conexión: {connection}");
                connection.Open();
            }
            catch (Exception ex)
            {
                throw new MessageException($"Error al conectar a la base de datos: {ex.Message}");
            }
        }

        public static void CreateInitialTables()
        {
            if (!connection.State.Equals(ConnectionState.Open))
                throw new MessageException("La conexión a la base de datos no está abierta.");
            // si no existe la tabla de usuarios, la crea
            string database = "ClasesGlobales";
            string table = "ComboBox";
            string query = @$"
            IF NOT EXISTS(SELECT * FROM sys.databases WHERE name='{database}')
            BEGIN
	            CREATE DATABASE {database}
            END
        ";
            Execute(query);
            query = @$"
            USE {database};
            IF NOT EXISTS(SELECT * FROM sys.tables WHERE name='{table}')
            BEGIN
                CREATE TABLE {table}(
                    id INT PRIMARY KEY IDENTITY(1,1),
                    nombre VARCHAR(50) NOT NULL,
                    apellidos VARCHAR(50) NOT NULL,
                    edad INT NOT NULL
                )
            END
        ";
            Execute(query);
        }
        public static void CloseDatabase()
        {
            try
            {
                if (connection.State.Equals(ConnectionState.Closed))
                    throw new Exception("La conexión a la base de datos ya está cerrada.");
                connection.Close();
            }
            catch (Exception ex)
            {
                throw new MessageException($"Error al cerrar la conexión a la base de datos: {ex.Message}");
            }
        }
        public static DataTable ExecuteRead(string query)
        {
            if (!connection.State.Equals(ConnectionState.Open))
                throw new MessageException("La conexión a la base de datos no está abierta.");
            // Crea un comando SQL en base a una query y una conexión para ejecutarla en la base de datos.
            SqlCommand command = new SqlCommand(query, connection);
            DataTable dt = new DataTable();
            using (SqlDataReader reader = command.ExecuteReader())
                dt.Load(reader);
            return dt;
        }
        public static void Execute(string query)
        {
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
        }
    }
}

