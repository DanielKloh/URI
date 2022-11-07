using System;
using System.Globalization;

namespace _1064
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int p = 0;
            double m=0;
            double media=0;
            double x;
            while (i <= 6)
            {
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (x > 0)
                {
                    p = p+1;
                    m= m+x;
                    
                }
                media= (m)/p;
                i = i + 1;
            }
            
            Console.WriteLine(p + " valores positivos");
            Console.WriteLine(media.ToString("F1",CultureInfo.InvariantCulture));
        }
    }
}
