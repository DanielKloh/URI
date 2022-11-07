using System;

namespace _1016
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a distancia (em Km/h) ");
            int distancia = int.Parse(Console.ReadLine());
            
            double time = distancia*2;
            

            Console.WriteLine(time+" minutos");
        }
    }
}
