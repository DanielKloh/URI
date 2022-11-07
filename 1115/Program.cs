using System;

namespace _1115
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = Console.ReadLine().Split();
            int x = int.Parse(vetor[0]);
            int y = int.Parse(vetor[1]);
            if (x > 0 && y > 0)
            {
                Console.WriteLine("primeiro");
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine("segundo");
            }
            if (x < 0 && y < 0)
            {
                Console.WriteLine("terceiro");
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine("quarto");
            }
            if (x == 0 || y == 0)
            {
                return;
            }
            else
            {
                while (x != 0 || y != 0)
                {
                    string[] vetor1 = Console.ReadLine().Split();
                    int x1 = int.Parse(vetor1[0]);
                    int y1 = int.Parse(vetor1[1]);
                    if (x1 > 0 && y1 > 0)
                    {
                        Console.WriteLine("primeiro");
                    }
                    if (x1 < 0 && y1 > 0)
                    {
                        Console.WriteLine("segundo");
                    }
                    if (x1 < 0 && y1 < 0)
                    {
                        Console.WriteLine("terceiro");
                    }
                    if (x1 > 0 && y1 < 0)
                    {
                        Console.WriteLine("quarto");
                    }
                    x=x1;
                    y=y1;
                    if (x1 == 0 || y1 == 0)
                    {
                        x = 0;
                        y = 0;
                    }
                }
            }
        }
    }
}
