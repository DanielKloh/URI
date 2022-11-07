using System;
using System.Globalization;

namespace _1009v
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double sal = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double vendas = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double comis = (vendas*0.15)+sal;

            Console.WriteLine("TOTAL = R$ "+comis.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
