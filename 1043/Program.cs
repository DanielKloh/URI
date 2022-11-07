using System;
using System.Globalization;

namespace _1043
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, perimetro, area;
            string[] vetor = Console.ReadLine().Split(' ');
            n1 = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            n2 = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            n3 = double.Parse(vetor[2], CultureInfo.InvariantCulture);


            if(n1> n2-n3 && n1> n3-n2 && n1<n2+n3 && n1<n3+n2){
                perimetro = n1 + n2 +n3;
                Console.WriteLine("Perimetro = "+perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else if(n2> n1-n3 && n2>n3-n1 && n2<n1+n3 && n2<n3+n1){
                perimetro = n1 + n2 +n3;
                Console.WriteLine("Perimetro = "+perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else if(n3> n2-n1 && n3>n1-n2 && n3<n2+n1 && n3<n1+n2){
                perimetro = n1 + n2 +n3;
                Console.WriteLine("Perimetro = "+perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else{
                area = ((n1 + n2)*n3)/2;
                Console.WriteLine("Area = "+area.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
