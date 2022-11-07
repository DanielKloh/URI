using System;
using System.Globalization;

namespace _1036
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, delta,raiz, X1 ,X2;
            string[] vetor = Console.ReadLine().Split(' ');
            A = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            B = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            C = double.Parse(vetor[2], CultureInfo.InvariantCulture);
            delta = (Math.Pow(B,2)-4*A*C);
            raiz = Math.Sqrt(delta);
            if(delta>0 && A!=0){
                X1 = ((-B) + raiz)/(2 * A);
                X2 = ((-B) - raiz)/(2 * A);
                Console.WriteLine("R1 = "+X1.ToString("F5",CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = "+X2.ToString("F5",CultureInfo.InvariantCulture));
            }
            else{
                Console.WriteLine("Impossivel calcular");
            }
        }
    }
}
