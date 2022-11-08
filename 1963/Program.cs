using System;
using System.Globalization;

namespace _1963
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leitura de dados
            string[] vetor = Console.ReadLine().Split();
            double inicial = double.Parse(vetor[0],CultureInfo.InvariantCulture);
            double final = double.Parse(vetor[1],CultureInfo.InvariantCulture);

            //Calculo
            double soma = final-inicial;
            soma /=inicial;
            soma*=100;

            //Impreção de valores
            Console.WriteLine(soma.ToString("F2",CultureInfo.InvariantCulture)+"%");
        }
    }
}
