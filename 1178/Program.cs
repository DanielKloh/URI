using System;
using System.Globalization;

namespace _1178
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Problema no aredondamento
            
            decimal num=decimal.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            for(int i =0;i<100;i++){
               
                Console.WriteLine("N["+i+"] = "+num.ToString("F4",CultureInfo.InvariantCulture));
                Math.Round(num/=2);
         
            }*/


            decimal x = decimal.Parse(Console.ReadLine());
            decimal y = 0;
            decimal[] vet = new decimal[100];

            vet[0] = x;

            Console.WriteLine("N[0] = " + vet[0].ToString("F4"));

            y = x / 2;

            for (int i = 1; i < 100; i++)
            {
                vet[i] = y;

                y = y / 2;
            }

            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine(
                    "N[" + i + "] = " + decimal.Round(vet[i], 4, MidpointRounding.ToEven)
                );
            }
        }
    }
}
