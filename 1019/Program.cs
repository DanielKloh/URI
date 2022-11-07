using System;

namespace _1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora, min, seg, resto;
            string[] vetor = Console.ReadLine().Split(' ');
            int N = int.Parse(vetor[0]);

            hora=N/3600;
            resto=N%3600;

            min=resto/60;
            seg=resto%60;
            
            Console.WriteLine(hora+":"+min+":"+seg);

        }
    }
}
