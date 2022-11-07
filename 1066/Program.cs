using System;

namespace _1066
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 1;
            int positivo = 0;
            int neg = 0;
            int par = 0;
            int impar = 0;
            while (y <= 5)
            {
                int x = int.Parse(Console.ReadLine());
                if (x > 0)
                {
                    positivo += 1;
                }
                if (x < 0)
                {
                    neg += 1;
                }
                if (x % 2 == 0)
                {
                    par += 1;
                }
                if (x % 2 != 0)
                {
                    impar += 1;
                }

                y += 1;
            }

            Console.WriteLine(par + " valor(es) par(es)");
            Console.WriteLine(impar + " valor(es) impar(es)");
            Console.WriteLine(positivo + " valor(es) positivo(s)");
            Console.WriteLine(neg + " valor(es) negativo(s)");
        }
    }
}
