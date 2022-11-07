using System;

namespace _1042
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,
                n2,
                n3;
            string[] vetor = Console.ReadLine().Split(' ');
            n1 = int.Parse(vetor[0]);
            n2 = int.Parse(vetor[1]);
            n3 = int.Parse(vetor[2]);

            if (n1 < n2 && n1 < n3 && n2 < n3)
            {
                Console.WriteLine(n1);
                Console.WriteLine(n2);
                Console.WriteLine(n3);
            }
            if (n1 < n2 && n1 < n3 && n3 < n2)
            {
                Console.WriteLine(n1);
                Console.WriteLine(n3);
                Console.WriteLine(n2);
            }

            if (n2 < n1 && n2 < n3 && n1 < n3)
            {
                Console.WriteLine(n2);
                Console.WriteLine(n1);
                Console.WriteLine(n3);
            }
            if (n2 < n1 && n2 < n3 && n3 < n1)
            {
                Console.WriteLine(n2);
                Console.WriteLine(n3);
                Console.WriteLine(n1);
            }

            if (n3 < n2 && n3 < n1 && n2 < n1)
            {
                Console.WriteLine(n3);
                Console.WriteLine(n2);
                Console.WriteLine(n1);
            }
            if (n3 < n2 && n3 < n1 && n1 < n2)
            {
                Console.WriteLine(n3);
                Console.WriteLine(n1);
                Console.WriteLine(n2);
            }

            Console.WriteLine();
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
        }
    }
}
