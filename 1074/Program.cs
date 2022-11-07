using System;

namespace _1074
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int y = 0; y < n; y++)
            {
                int x = int.Parse(Console.ReadLine());

                //0=NULL

                if (x == 0)
                {
                    Console.WriteLine("NULL");
                }

                // > 0
                else if (x > 0)
                {
                    //PAR
                    if (x % 2 == 0)
                    {
                        Console.WriteLine("EVEN POSITIVE");
                    }
                    //Impar
                    else
                    {
                        Console.WriteLine("ODD POSITIVE");
                    }
                }
                //< 0
                else
                {
                    //par
                    if (x % 2 == 0)
                    {
                        Console.WriteLine("EVEN NEGATIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD NEGATIVE");
                    }
                }
            }
        }
    }
}
