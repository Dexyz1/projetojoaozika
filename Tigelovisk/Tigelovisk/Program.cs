using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tigelovisk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu;
            string loop = "S";
            string nomeProduto1 = "", nomeProduto2 = "", nomeProduto3 = "";
            float valor1 = 0, valor2 = 1, valor3 = 2;
            int quantidade1 = 0, quantidade2 = 1, quantidade3 = 2, venda = 5;
            double compra1 = 0, compra2, compra3, precototal1 = 0, produto1, produto2, produto3;
            double valorpago1, troco1, valorpago2, troco2, valorpago3, troco3;

            Console.WriteLine(" _____  _       _                                  _           _____                   ___               \r\n/  ___|(_)     | |                                | |         /  ___|                 |_  |              \r\n\\ `--.  _  ___ | |_   ___  _ __ ___    __ _     __| |  ___    \\ `--.   ___  _   _       | |  __ _   ___  \r\n `--. \\| |/ __|| __| / _ \\| '_ ` _ \\  / _` |   / _` | / _ \\    `--. \\ / _ \\| | | |      | | / _` | / _ \\ \r\n/\\__/ /| |\\__ \\| |_ |  __/| | | | | || (_| |  | (_| || (_) |  /\\__/ /|  __/| |_| |  /\\__/ /| (_| || (_) |\r\n\\____/ |_||___/ \\__| \\___||_| |_| |_| \\__,_|   \\__,_| \\___/   \\____/  \\___| \\__,_|  \\____/  \\__,_| \\___/ \r\n                                                                                                         \r\n                                                                                                         ");

            while (loop.ToUpper() == "S")
            {
                Console.WriteLine("1 - CADASTRAR novos produtos");
                Console.WriteLine("2 - Realizar VENDA de produtos");
                Console.WriteLine("3 - Gerar RELATORIO de produtos");
                Console.WriteLine("4 - Nossa area de testes ! ! !");
                menu = int.Parse(Console.ReadLine());


                if (menu == 1)
                {
                    Console.Write("Nome do 1° Produto: ");
                    nomeProduto1 = Console.ReadLine();

                    Console.Write("Digite a quantidade em estoque do" + nomeProduto1 + ": ");
                    quantidade1 = int.Parse(Console.ReadLine());

                    Console.Write("Digite o valor do " + nomeProduto1 + ": ");
                    valor1 = float.Parse(Console.ReadLine());


                    Console.Write("Nome do 2° Produto: ");
                    nomeProduto2 = Console.ReadLine();

                    Console.Write("Digite a quantidade em estoque do" + nomeProduto2 + ": ");
                    quantidade2 = int.Parse(Console.ReadLine());

                    Console.Write("Digite o valor do " + nomeProduto2 + ": ");
                    valor2 = float.Parse(Console.ReadLine());

                    Console.Write("Nome do 3° Produto: ");
                    nomeProduto3 = Console.ReadLine();

                    Console.Write("Digite a quantidade em estoque do" + nomeProduto3 + ": ");
                    quantidade3 = int.Parse(Console.ReadLine());

                    Console.Write("Digite o valor do " + nomeProduto3 + ": ");
                    valor3 = float.Parse(Console.ReadLine());
                       
 


                }
                else if (menu == 2)
                {

                   
                    Console.WriteLine("Digite um produto");
                    int escolha_venda = int.Parse(Console.ReadLine());

                    if (escolha_venda == 1)
                    {
                        Console.WriteLine("Você escolheu vender um PRODUTO" + nomeProduto1 + ":");

                    } else if(escolha_venda == 2)

                    {
                       Console.WriteLine("Você escolheu vender um PRODUTO" + nomeProduto2 + ":");
                     
                     

                    } else if(escolha_venda == 3)
                    {
                        Console.WriteLine("Você escolheu vender um PRODUTO" + nomeProduto3 + ":");
                    }
                }
                else if (menu == 3)
                {
                    Console.WriteLine("Bem vindo ao relatorio !!!");
                    Console.WriteLine("Produto 1: " + nomeProduto1 + " - Estoque: " + quantidade1 + " - Valor: " + valor1);
                    Console.WriteLine("Produto 1: " + nomeProduto2 + " - Estoque: " + quantidade2 + " - Valor: " + valor2);
                    Console.WriteLine("Produto 1: " + nomeProduto3 + " - Estoque: " + quantidade3 + " - Valor: " + valor3);


                 
                }
                else if(venda == 1) { 
                
                    Console.WriteLine("Produto:" + nomeProduto1 + "valor" + valor1);
                    Console.WriteLine("Qual é a quantidade de:" + precototal1 + ":");
                    compra1 = int.Parse(Console.ReadLine());
                }
                if (compra1 <= quantidade1) { }

                Console.WriteLine("Deseja voltar S/N");
                loop = Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
