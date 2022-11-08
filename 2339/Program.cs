using System;

namespace _2339
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int jogador,papel,quantia,soma;

            string[] vetor = Console.ReadLine().Split();
            jogador = int.Parse(vetor[0]);
            papel = int.Parse(vetor[1]);
            quantia = int.Parse(vetor[2]);

            soma = papel / quantia;

            if (soma >= jogador)
            {
                Console.WriteLine("S");
            }
            else
            {
                Console.WriteLine("N");
            }
        }
    }
}
