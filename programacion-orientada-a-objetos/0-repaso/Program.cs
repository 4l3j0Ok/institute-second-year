using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.ejercicio_uno();
        }

        private void ejercicio_uno()
        {
            string user = "";
            string pass = "";
            string validUser = "alejo";
            string validPass = "1234";
            while (user != validUser || pass != validPass)
            {
                user = getUser();
                pass = getPass();
                if (user == "" || pass == "")
                {
                    Console.WriteLine("Por favor, ingresa sus datos de usuario");
                    continue;
                }
                if (user == validUser && pass == validPass)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Bienvenido al sistema {user}");
                    break;
                }
                Console.WriteLine();
                Console.WriteLine("Sus datos de usuario o contraseña no son válidos");
                Console.WriteLine();
            }
        }

        static string getUser()
        {
            string user;
            Console.Write("Por favor, ingrese el usuario: ");
            user = Console.ReadLine();
            return user;
        }

        static string getPass()
        {
            string pass;
            Console.Write("Por favor, ingrese la contraseña: ");
            pass = Console.ReadLine();
            return pass;
        }
    }
}
