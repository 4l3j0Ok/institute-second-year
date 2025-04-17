using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_sql_to_combo
{
    internal class ComboController
    {
        public static DataTable GetComboData()
        {
            string query = "SELECT * FROM tabla";
            DataTable data = Database.ExecuteRead(query);
            return data;
        }
    }
}
