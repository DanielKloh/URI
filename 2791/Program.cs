using System;

namespace _2729
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variavel
            int a, b, c, d;
            
            
            string[] vetor = Console.ReadLine().Split();
            a = int.Parse(vetor[0]);
            b = int.Parse(vetor[1]);
            c = int.Parse(vetor[2]);
            d = int.Parse(vetor[3]);
            
            //Testa em qual pote vai estar
            if (a == 1)
            {
                Console.WriteLine("1");
            }
            else if (b == 1)
            {
                Console.WriteLine("2");
            }
            else if (c == 1)
            {
                Console.WriteLine("3");
            }
            else if (d == 1)
            {
                Console.WriteLine("4");
            }
        }
    }
}
