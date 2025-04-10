using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _3_clases_con_bbdd_pero_sin_bbdd_pero_igual_le_meto_bbdd
{
    internal class Variables
    {
        private static string DBHost = Environment.GetEnvironmentVariable("DB_HOST") ?? "localhost";
        private static string DBDatabase = Environment.GetEnvironmentVariable("DB_DATABASE") ?? "db";
        private static string DBPassword = Environment.GetEnvironmentVariable("DB_PASSWORD") ?? "password";
        private static string DBUsername = Environment.GetEnvironmentVariable("DB_USERNAME") ?? "root";
        //Server=localhost,1433;Database=master;User Id=sa;Password=PerritoSalvaje;TrustServerCertificate=True
        public static string connectionString = $"Server={DBHost};Database={DBDatabase};User Id={DBUsername};Password={DBPassword};TrustServerCertificate=True";
    }
}
