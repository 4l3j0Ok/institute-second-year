using System.Data;

namespace _04_sql_to_combo.Controllers
{
    internal class Combo
    {
        private static string table = "ComboBox";

        public static void CreateInitialTables()
        {
            string query = @$"
                IF NOT EXISTS(SELECT * FROM sys.tables WHERE name='{table}')
                BEGIN
                    CREATE TABLE {table}(
                        id INT PRIMARY KEY IDENTITY(1,1),
                        elemento VARCHAR(50) NOT NULL,
                    )
                END
            ";
            Database.Execute(query);
        }

        public static void InsertInitialData()
        {
            if (GetLengthData() > 0) return;
            string query = @$"
                INSERT INTO {table} (elemento) VALUES
                ('Primero'),
                ('Segundo'),
                ('Tercero'),
                ('Cuarto'),
                ('Quinto')
            ";
            Database.Execute(query);
        }

        public static DataTable GetData()
        {
            string query = @$"SELECT * FROM {table}";
            DataTable dt = Database.ExecuteRead(query);
            if (dt.Rows.Count == 0)
                throw new MessageException("No hay datos en la tabla");
            return dt;
        }

        public static int GetLengthData()
        {
            string query = @$"SELECT COUNT(*) FROM {table}";
            DataTable dt = Database.ExecuteRead(query);
            int count = 0;
            foreach (DataRow row in dt.Rows)
            {
                count = Convert.ToInt32(row[0]);
            }
            return count;
        }
    }
}
