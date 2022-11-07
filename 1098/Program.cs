using System;
using System.Globalization;

namespace _1098
{
    class Program
    {
        static void Main(string[] args)
        {
            double I = 0;
            double J = 1;
            int contador = 0;
            

            

            for (double i = I; I < 2; )
            {
                contador += 1;
                

                
                if (I==0 || I==1 || I==2)
                {
                    Console.WriteLine(
                        "I=" + I.ToString("F1", CultureInfo.InvariantCulture) + " J=" + J
                    );
                }
                else
                {
                    Console.WriteLine(
                        "I="
                            + I.ToString("F1", CultureInfo.InvariantCulture)
                            + " J="
                            + J.ToString("F1", CultureInfo.InvariantCulture)
                    );
                }

                if (contador >= 3)
                {
                    J = 0 + I;
                    
                }
                J += 1;
                if (contador == 3)
                {
                    I += 0.2;
                    J += 0.2;
                    contador = 0;
                }
            
            }
        }
    }
}
