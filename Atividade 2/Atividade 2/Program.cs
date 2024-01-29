using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string aluno1 = "Gustavo";
            //string aluno2 = "Samuel";
            //string aluno3 = "Pedro";
            //string aluno4 = "Rafaela";
            //string aluno5 = "Reryel";
            //string aluno6 = "Richard";
            //string aluno7 = "Renon";
            //string aluno8 = "Erick";
            //string aluno9 = "Lucas";
            //string aluno10 = "Monique";
            //string aluno11 = "Danilo";


            string prof1 = "Paulo";
            string prof2 = "Vagner";
            string prof3 = "Ricardo";

            string[] alunos = { "Gustavo", "Samuel", "Pedro", "Rafaela", "Reryel", "Richard", "Renon", "Erick", "Lucas", "Monique", "Danilo" };
            string[] profs = { "Paulo", "Vagner", "Ricardo" };

            float[] idades = { 19, 19, 17, 18, 23, 17, 25, 17, 18, 29, 17 };

            float media = 0;
            for (int i = 0; i < idades.Length; i++)
            {
                media += idades[i];
            }
            media = media / idades.Length;
            Console.WriteLine(media);

            float sum = 0;
            Array.ForEach(idades, contador => sum += contador);
            sum = sum / idades.Length;
            Console.WriteLine(sum);

            float total = idades.Sum() / idades.Length;
            Console.WriteLine(total);

            foreach(var meubb in alunos)
            {
                if (meubb == "Gustavo")
                {
                    Console.WriteLine("Vulgo MALVADÃO");
                }
                else if (meubb == "erick")
                {
                    Console.WriteLine("Vulgo c# de Mél");
                }
                else
                {
                    Console.WriteLine(meubb);
                }
            }





            Console.Write(alunos.Length);

            //Console.WriteLine(alunos[0]);
            //Console.WriteLine(alunos[1]);
            //Console.WriteLine(alunos[2]);
            //Console.WriteLine(alunos[3]);
            //Console.WriteLine(alunos[4]);
            //Console.WriteLine(alunos[5]);
            //Console.WriteLine(alunos[6]);
            //Console.WriteLine(alunos[7]);
            //Console.WriteLine(alunos[8]);
            //Console.WriteLine(alunos[9]);
            //Console.WriteLine(profs[0]);
            //Console.WriteLine(profs[1]);
            //Console.WriteLine(profs[2]);

            for (int i = 0; i < alunos.Length; i++)
            {
                Console.WriteLine(alunos[i]);
            }






            Console.ReadKey();
        }
    }
}
