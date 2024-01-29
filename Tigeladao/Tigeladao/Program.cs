using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tigeladao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero_aleatorio = 74;
            int tentativa_usuario = 0;

            while (tentativa_usuario != numero_aleatorio)
            {
                Console.Write("Digite a tentativa:");
                tentativa_usuario = int.Parse(Console.ReadLine());

                if(tentativa_usuario > numero_aleatorio)
                {
                    Console.WriteLine("O numero digitado é MAIOR que o numero sorteado!");

                } else if (tentativa_usuario < numero_aleatorio)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("O numero digitado é MENOR que o numero sorteado!");
                } else
                {
                    
                    Console.ForegroundColor= ConsoleColor.Green;
                    Console.WriteLine("Parabens você GANHOU !!!!");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");

                    
             

                    
                   
            }
            Console.ReadKey();
        }
    }
}
