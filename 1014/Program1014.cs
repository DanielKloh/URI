using System;
using System.Globalization;

namespace _1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double Y = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double consumo=X/Y;

            Console.WriteLine(consumo.ToString("F3",CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
