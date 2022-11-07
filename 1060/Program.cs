using System;
using System.Globalization;

namespace _1060
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int p = 0;
            double x;
            while (i <= 6)
            {
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (x > 0)
                {
                    p = p+1;
                }
                i = i + 1;
            }
            Console.WriteLine(p + " valores positivos");
        }
    }
}
