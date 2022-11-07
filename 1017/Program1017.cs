using System;
using System.Globalization;

namespace _1017
{
    class Program
    {
        static void Main(string[] args)
        {
            double time = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double media = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double S = (time*media)/12;

            Console.WriteLine(S.ToString("F3",CultureInfo.InvariantCulture));
        }
    }
}
