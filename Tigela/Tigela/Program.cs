using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tigela
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());





            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + num * i);
            }
            Console.ReadKey();
        }
    }
}
