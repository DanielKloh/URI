using System;
using System.Globalization;

namespace _2234
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma = 0;

            string[] vetor = Console.ReadLine().Split();
            double hotdog = double.Parse(vetor[0]);
            double people = double.Parse(vetor[1]);

            soma = hotdog/people;

            Console.WriteLine(soma.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
