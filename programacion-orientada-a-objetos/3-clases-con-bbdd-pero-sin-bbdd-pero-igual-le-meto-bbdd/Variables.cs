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
        public Variables()
        {
            string DBHost = "localhost";
            string DBDatabse = "master";
            string DBPassword = "pass";
            string DBUsername = "sa";
            string connectionString = $"Server={DBHost};Database={DBDatabse};User Id={DBUsername};Password={DBPassword};";
        }
    }
}
