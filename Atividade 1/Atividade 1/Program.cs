using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1- Numeros pares no intervalo \n2 sequencia da fibonacci \n3 primos no intervalo");
            int menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    Console.WriteLine("Você escolheu \"Numeros pares no intervalo\"");
                    int numero1, numero2;
                    

                    Console.WriteLine("Escolha o numero inicial: ");
                    numero1 = int.Parse(Console.ReadLine());
                    

                    Console.Write("Escolha o numero final: ");
                    numero2 = int.Parse(Console.ReadLine());

                    for (int contador = numero1; contador < numero2; contador++)
                    {
                        if (contador % 2 == 0)
                        {
                            Console.WriteLine("Numero atual: " + contador);
                        }
                        
                    }




                    break;
                    
                    case 2:
                    Console.WriteLine("Você escolheu \"Sequência de Fibonacci\"");

                    Console.Write("Digite a posição escolhida: ");
                    int posicao = int.Parse(Console.ReadLine());

                    int anterior = 0, atual = 1, temporario = 0;


                    for (int contador = 0; contador < posicao; contador++)
                    {
                        Console.WriteLine("Fibonacci posicao " + (contador + 1) + ": " + (atual));

                        temporario = anterior;

                        anterior = atual;

                        atual = temporario + atual;
                    }

                    break;

                case 3:
                    Console.WriteLine("voce escolheu \"numero primos no intervalo\"");
                    Console.WriteLine("digite um numero inteiro positivo:");
                    int n = int.Parse(Console.ReadLine());



                    Console.WriteLine("numero primo ate {0}:", n);
                    for (int i = 2; i <= n; i++)
                    {
                        //i- interacao com o loops
                        //j- contar a interacao dos loops 
                        bool primo = true;
                        for (int j = 2; j < i; j++)
                        {
                            if (i % j == 0)
                            {
                                primo = false;
                                break;

                            }
                        }
                        if (primo)
                        {
                            Console.WriteLine(i);
                        }



                    }
                    break;



                default:
                    Console.WriteLine("escolheu uma opcao valida");
                    break;













            }

            Console.ReadKey();
        }
    }
}
