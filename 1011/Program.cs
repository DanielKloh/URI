using System;
using System.Globalization;

namespace _1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double V =((4/3.0)*3.14159)*(raio*raio*raio);

            Console.WriteLine("VOLUME = " + V.ToString("F3",CultureInfo.InvariantCulture));
        }
    }
}
