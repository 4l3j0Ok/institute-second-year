using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;


namespace _3_clases_con_bbdd_pero_sin_bbdd_pero_igual_le_meto_bbdd
{
    public static class Database
    {
        private static SqlConnection connection = new SqlConnection(Variables.connectionString);
        public static void OpenDatabase()
        {
            connection.Open(); // Abre la conexión con la base de datos
        }
        public static void CloseDatabase()
        {
            connection.Close(); // Cierra la conexión con la base de datos
        }
        public static SqlDataReader ExecuteQuery(string query)
        {
            SqlCommand command = new SqlCommand(query, connection); // Crea un comando SQL en base a una query y una conexión para ejecutarla en la base de datos.
            return command.ExecuteReader(); // Ejecuta la query y devuelve un SqlDataReader con los resultados.
        }
    }
}
