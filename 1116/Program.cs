using System;
using System.Globalization;

namespace _1116
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; ++i)
            {
                string[] vetor = Console.ReadLine().Split();
                double n1 = int.Parse(vetor[0]);
                double n2 = int.Parse(vetor[1]);

                if (n2 == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double divisao = n1 / n2;

                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
