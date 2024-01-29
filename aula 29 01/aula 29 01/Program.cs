using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_29_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conexao =
                 "server=localhost;user=root;password=;database=db_restaurante";

            using (MySqlConnection banco = new MySqlConnection(conexao))
            {

            }







            Console.ReadKey();

        }
    }
}
