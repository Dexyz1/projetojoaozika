using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Do_João
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu;
            string loop = "S";

            while (loop == "S")
            {  
                Console.WriteLine("1 - CADASTRAR novos produtos");
                Console.WriteLine("2 - Realizar VENDA de produtos");
                Console.WriteLine("3 - Gerar RELATORIO de produtos");
                menu = int.Parse(Console.ReadLine());


                if (menu == 1)
                {
                    Console.WriteLine("Você escolheu CADASTRAR UM PRODUTO");
                }
                else if (menu == 2)
                {
                    Console.WriteLine("Você escolheu VENDER UM PRODUTO");
                }
                else if (menu == 3)
                {
                    Console.WriteLine("Você escolheu gerar UM RELATORIO DOS PRODUTOS");
                }
                else
                    Console.WriteLine("Você digitou uma opção invalida");

                Console.Write("Deseja continuar no sistema? (S/N)");
                loop = Console.ReadLine();


               
            }
            Console.Write("Pressione <enter> para finalizar...");
            Console.ReadKey();
        }


        }
    }
