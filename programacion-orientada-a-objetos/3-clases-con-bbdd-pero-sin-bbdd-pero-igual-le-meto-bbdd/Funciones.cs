using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// sqlite import:
using Microsoft.Data.Sqlite;

namespace _3_clases_con_bbdd_pero_sin_bbdd_pero_igual_le_meto_bbdd
{
    internal class Funciones
    {
        private static SqliteConnection sqliteConnection = new SqliteConnection("Data Source=hello.db");

        public static void CreateBaseTables()
        {
            using (sqliteConnection)
            {
                string statement = @"
                    CREATE TABLE IF NOT EXISTS user (
                        id INTEGER PRIMARY KEY,
                        name TEXT NOT NULL
                    );
                    ";
                sqliteConnection.Open();
                SqliteCommand command = new SqliteCommand(statement, sqliteConnection);
                command.ExecuteNonQuery();
            }
        }
        //    using (var connection = new SqliteConnection("Data Source=hello.db"))
        //    {
        //        connection.Open();

        //        var command = connection.CreateCommand();
        //        command.CommandText = @"
        //            SELECT name
        //            FROM user
        //            WHERE id = $id
        //        ";
        //        command.Parameters.AddWithValue("$id", id);

        //        using (var reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                var name = reader.GetString(0);

        //        Console.WriteLine($"Hello, {name}!");
        //            }
        //        }
        //    }
    }
}
