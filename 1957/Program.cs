using System;

namespace _1957
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            string hex = i.ToString("X");
            Console.WriteLine(hex);
        }
    }
}
