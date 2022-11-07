using System;

namespace _1067
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = int.Parse(Console.ReadLine());
            int x = 1;
            if (total <= 0 || total > 1000)
            {
                return;
            }
            else
            {
                while (x <= total)
                {
                if (x % 2 != 0)
                {
                Console.WriteLine(x);
                }
                x += 1;
                }
            }
        }
    }
}
