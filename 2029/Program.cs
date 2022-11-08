using System;
using System.Globalization;

namespace _2029
{
    class Program
    {
        static void Main(string[] args)

        {   
            //Declaração de variavel
            double circulo =0;
            double h =0;
            do{
                //Leitura de dados
                string vol = (Console.ReadLine());
                if(vol==null){ //String.Empty
                    break;
                }
                double volume = double.Parse(vol);
                //se for nulo
                
                double diametro = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                //Calculos
                double raio = diametro/2;                
                h=volume/(3.14 * Math.Pow(raio,2));
                circulo = 3.14 * Math.Pow(raio,2);
                
                //Impreção de valores
                Console.WriteLine("ALTURA = "+h.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("AREA = "+circulo.ToString("F2",CultureInfo.InvariantCulture));
                
            }while(true);
        }
    }
}
