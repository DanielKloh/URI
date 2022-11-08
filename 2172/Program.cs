using System;

namespace _2172
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int soma = 0;

                string[] vetor = Console.ReadLine().Split();
                int qtd = int.Parse(vetor[0]);
                int xp = int.Parse(vetor[1]);

                if (qtd == 0 && xp == 0)
                {
                    break;
                }

                soma = qtd * xp;

                Console.WriteLine(soma);
            } while (true);
        }
    }
}
