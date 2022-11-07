using System;
using System.Globalization;

namespace _1037
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada
            // double N = double.Parse(Console.ReadLine());

            //testes


            // if (N < 0 || N >= 101)
            // {
            //     Console.WriteLine("Fora de interval");
            // }

            double N = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (N>=0&&N<=25){
                Console.WriteLine("Intervalo [0,25]");

            }
            else if (N>25&&N<=50){
                Console.WriteLine("Intervalo (25,50]");

            }
            
            else if (N>50&&N<=75){
                Console.WriteLine("Intervalo (50,75]");

            }
            else if (N>75&&N<=100){
                Console.WriteLine("Intervalo (75,100]");

            }
            else if(N<0||N>100){
                Console.WriteLine("Fora de intervalo");
                
            }


            // float entrada = float.Parse(Console.ReadLine());

            // if (entrada>=0.0&&entrada<=25.0){
            //     Console.WriteLine( "Intervalo [0,25] ");

            // }
            // else if (entrada >25.0&&entrada<=50.0){
            //     Console.WriteLine("Intervalo (25,50]");

            // }
            // else if (entrada >50.0&&entrada<=75.0){
            //     Console.WriteLine( "Intervalo (50,75] ");
            //     ;
            // }
            // else if (entrada >75.0&&entrada<=100.0){
            //     Console.WriteLine("Intervalo (75,100] ");

            // }
            // else{
            //     Console.WriteLine("Fora do intervalo");
            // }


                
        }
    }
}
