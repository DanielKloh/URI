using System;
using System.Globalization;

namespace _1118
{
    class Program
    {
        static void Main(string[] args)
        {

            double soma = 0;
            //Primeira execuão do while
            double media1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            do
            {
                if (media1 < 0 || media1 > 10)
                {
                    Console.WriteLine("nota invalida");
                    double media11 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    media1 = media11;
                }
            } while (media1 < 0 || media1 > 10);

            
            //Segunda execução do while
            double media2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            do
            {
                if (media2 < 0 || media2 > 10)
                {
                    Console.WriteLine("nota invalida");
                    double media22 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    media2 = media22;
                }
            } while (media2 < 0 || media2 > 10);

            //soma das medias
            soma = (media1 + media2)/2;
            Console.WriteLine("media = "+soma.ToString("F2",CultureInfo.InvariantCulture));

            
            
            
            //continar
            Console.WriteLine("novo calculo (1-sim 2-nao)");
            int continuar = int.Parse(Console.ReadLine());
            do{  


            if(continuar < 1 || continuar >2){
                do{
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    int continuar1 = int.Parse(Console.ReadLine());
                    continuar = continuar1;
                    
            }while(continuar < 1 || continuar >2);
            }
            
            
            
            if(continuar==1){
                
            do{
                double media3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            do
            {
                if (media3 < 0 || media3 > 10)
                {
                    Console.WriteLine("nota invalida");
                    double media33 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    media3 = media33;
                }
            } while (media3 < 0 || media3 > 10);

            

            //Segunda execução do while
            double media4 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            do
            {
                if (media4 < 0 || media4 > 10)
                {
                    Console.WriteLine("nota invalida");
                    double media44 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    media4 = media44;
                }
            } while (media4 < 0 || media4 > 10);



            //soma das medias
            soma = (media3 + media4)/2;
            Console.WriteLine("media = "+soma.ToString("F2",CultureInfo.InvariantCulture));



            Console.WriteLine("novo calculo (1-sim 2-nao)");
            int continuar2 = int.Parse(Console.ReadLine());
            if(continuar2 < 1 || continuar2 >2){
                do{
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    int continuar1 = int.Parse(Console.ReadLine());
                    continuar2 = continuar1;
                    
            }while(continuar2 < 1 || continuar2 >2);
            }
            continuar = continuar2;
         
            }while(continuar != 2);
            }
        }while(continuar != 2);
    }
}}
