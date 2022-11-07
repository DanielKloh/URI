using System;
using System.Globalization;

namespace _1048
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0 - 400.00  15.0
            // 400.01 - 800.00    12.0
            // 800.01 - 1200.00   10.0
            // 1200.01 - 2000.00   7.0
            // Acima de 2000.00    4.0

            double sal;
            double persentual;
            sal = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if(sal <= 400){
                persentual= 15.0;
            }else if(sal <=800){
                persentual = 12.0;
            }
            else if(sal <=1200){
                persentual = 10.0;
            }
            else if(sal <= 2000){
                persentual=7.0;
            }
            else{
                persentual=4.0;
            }

            double reajuste= sal*persentual / 100;
            double novosal = sal+reajuste;

            //putros ifs

            //saida
            // Novo salario: 460.00
            // Reajuste ganho: 60.00
            // Em percentual: 15 %

            Console.WriteLine("Novo salario: " + novosal.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + persentual + " %");




        }
    }
}
