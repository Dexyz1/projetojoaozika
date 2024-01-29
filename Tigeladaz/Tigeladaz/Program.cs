using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tigeladaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int soma;



            Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            soma = num1 + num2;
            Console.WriteLine("A soma dos dois números é de {0}", soma);



            Console.ReadKey();
        }
    }
}
