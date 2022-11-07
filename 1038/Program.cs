using System;
using System.Globalization;

namespace _1038
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1,
                valor2,
                valor3,
                valor4,
                valor5;
            string[] vetor = Console.ReadLine().Split(' ');
            int codigo = int.Parse(vetor[0], CultureInfo.InvariantCulture);
            int qtd = int.Parse(vetor[1], CultureInfo.InvariantCulture);

            if (codigo == 1)
            {
                valor1 = qtd * 4.00;
                Console.WriteLine(
                    "Total: R$ " + valor1.ToString("F2", CultureInfo.InvariantCulture)
                );
            }
            if (codigo == 2)
            {
                valor2 = qtd * 4.50;
                Console.WriteLine(
                    "Total: R$ " + valor2.ToString("F2", CultureInfo.InvariantCulture)
                );
            }
            if (codigo == 3)
            {
                valor3 = qtd * 5.00;
                Console.WriteLine(
                    "Total: R$ " + valor3.ToString("F2", CultureInfo.InvariantCulture)
                );
            }
            if (codigo == 4)
            {
                valor4 = qtd * 2.00;
                Console.WriteLine(
                    "Total: R$ " + valor4.ToString("F2", CultureInfo.InvariantCulture)
                );
            }
            if (codigo == 5)
            {
                valor5 = qtd * 1.50;
                Console.WriteLine(
                    "Total: R$ " + valor5.ToString("F2", CultureInfo.InvariantCulture)
                );
            }
        }
    }
}
