using System;
using System.Globalization;

namespace _1117
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração de variaveis
            int i = 0;
            double soma = 0;
            double media = 0;

            //enquanto i menor que dois, o codigo é executado
            while (i < 2)
            {
                double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//leitura de um valor double

                if (nota < 0 || nota > 10)//testa se não é valido
                {
                    Console.WriteLine("nota invalida");
                }
                else if (nota >= 0 && nota <= 10)// Testa se é valido
                {
                    soma += nota;//soma do total das notas
                    i += 1;//i aumenta em 1
                }
            }
            media = soma / 2;//calculo da media
            Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
