using System;
using System.Globalization;

namespace _3346
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração de variavel
            double conta = 0;

            //entrada de valores
            string[] vetor = Console.ReadLine().Split();
            double PIB1 = double.Parse(vetor[0],CultureInfo.InvariantCulture);
            double PIB2 = double.Parse(vetor[1],CultureInfo.InvariantCulture);            

            //formula
            conta = ((((1.0 + PIB1/100.00) * (1.0 + PIB2/100.00)) - 1.0) * 100.0);

            //exibição de valores
            Console.WriteLine(conta.ToString("F6",CultureInfo.InvariantCulture));
        }
    }
}
