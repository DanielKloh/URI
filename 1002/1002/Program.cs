using System;
using System.Globalization;

namespace _1002
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaro varaibel
            // leitura do teclado
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // calculo
            double area = 3.14159 * (raio * raio);

            // impressao do resultado
            // 4 casas decimais
            // com ponto
            Console.WriteLine("A=" + area.ToString("F4",CultureInfo.InvariantCulture));
        }
    }
}
