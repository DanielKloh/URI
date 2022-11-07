using System;
using System.Globalization;

namespace _1045
{
    class Program
    {
        static void Main(string[] args)
        {
            double A,
                B,
                C,
                maior;
            string[] vetor = Console.ReadLine().Split();
            A = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            B = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            C = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            if (A > B && A > C)
            {
                maior = A;
            }
            else if (B > A && B > C)
            {
                maior = B;
                B = A;
            }
            else
            {
                maior = C;
                C = A;
            }

            if (maior >= B + C)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (Math.Pow(maior, 2) > Math.Pow(B, 2) + Math.Pow(C, 2))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                if (Math.Pow(maior, 2) < Math.Pow(B, 2) + Math.Pow(C, 2))
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }
                if (Math.Pow(maior, 2) == Math.Pow(B, 2) + Math.Pow(C, 2))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                if (maior == B && maior == C && C == B)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else
                {
                    if (maior == B || B == C || C == maior )
                    {
                        Console.WriteLine("TRIANGULO ISOSCELES");
                    }
                }
            }
        }
    }
}
