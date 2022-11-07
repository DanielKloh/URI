using System;
using System.Globalization;

namespace _1051
{
    class Program
    {
        static void Main(string[] args)
        {
            double sal = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if(sal<=2000){
                Console.WriteLine("Isento");
            }
            if(sal>2000 && sal<=3000){
                double salf=(sal-2000)*0.08;
                Console.WriteLine("R$ "+salf.ToString("F2",CultureInfo.InvariantCulture));
            }
            if(sal>3000 && sal<=4500){
                double salf=(sal-3000)*0.18+80;
                Console.WriteLine("R$ "+salf.ToString("F2",CultureInfo.InvariantCulture));
            }
            if(sal>4500){
                double salf=(sal-4500)*0.28+80+270;
                Console.WriteLine("R$ "+salf.ToString("F2",CultureInfo.InvariantCulture));
            }

        }
    }
}
