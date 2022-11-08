using System;
using System.Globalization;

namespace _1174
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] n = new double[100];
            for (int i = 0; i < 100; ++i)
            {
                n[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);  
            }
            for(int j=0;j<100;j++){
                if (n[j] <= 10)
                {
                    Console.WriteLine(
                        "A[" + j + "] = " + n[j].ToString("F1", CultureInfo.InvariantCulture)
                    );
                }
            }
        }
    }
}
