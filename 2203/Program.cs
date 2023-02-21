using System;

namespace _2203
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                do
                {
                    double xf, yf, xi, yi, r1, r2, distancia, t, vi;

                    string[] vetor = Console.ReadLine().Split();
                    
                    xf = double.Parse(vetor[0]);
                    yf = double.Parse(vetor[1]);
                    xi = double.Parse(vetor[2]);
                    yi = double.Parse(vetor[3]);
                    vi = double.Parse(vetor[4]);
                    r1 = double.Parse(vetor[5]);
                    r2 = double.Parse(vetor[6]);


                    distancia =  (xf - xi)*(xf - xi) + (yf - yi)*(yf - yi);
                    distancia = Math.Sqrt(distancia);
                    t =(1.5 * vi);
                    distancia += t;


                    if (r1 + r2 >= distancia)
                    {
                        Console.WriteLine("Y");
                    }
                    else
                    {
                        Console.WriteLine("N");
                    }
                } while (true);

            }
            catch (System.Exception)
            {
                return;
                throw;
            }
        }
    }
}
