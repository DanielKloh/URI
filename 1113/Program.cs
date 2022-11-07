using System;

namespace _1113
{
    class Program
    {
        static void Main(string[] args)
        {
            // variaveis
            string[] vetor;
            int x,
                y;

            //entrada
            vetor = Console.ReadLine().Split();
            x = int.Parse(vetor[0]);
            y = int.Parse(vetor[1]);

            //Enquanto x for diferente de y
            while (x != y)
            {
                //se x é menor q  y
                if (x < y)
                {
                    //saída
                    Console.WriteLine("Crescente");
                }
                else
                {
                    //saída
                    Console.WriteLine("Decrescente");
                }
                //ler valores novamente
                vetor = Console.ReadLine().Split(' ');
                x = int.Parse(vetor[0]);
                y = int.Parse(vetor[1]);
            }
        }
    }
}
