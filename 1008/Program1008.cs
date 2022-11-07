using System;
using System.Globalization;

namespace _1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUMBER = int.Parse(Console.ReadLine());
            int HORATRABALHO = int.Parse(Console.ReadLine());
            double SALARIOHORA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double SALARY = HORATRABALHO * SALARIOHORA;

            Console.WriteLine("NUMBER = " + NUMBER);
            Console.WriteLine("SALARY = U$ " + SALARY.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
