using System;

namespace _1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int p = 0;
            double x;
            while (i <= 5)
            {
                x = double.Parse(Console.ReadLine());
                if (x % 2 == 0)
                {
                    p = p + 1;
                }
                i = i + 1;
            }
            Console.WriteLine(p + " valores pares");
        }
    }
}
