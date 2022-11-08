using System;
using System.Globalization;

namespace _2164
{
    class Program
    {
        static void Main(string[] args)
        {
            //formula:
            //https://i.ytimg.com/vi/YXIgwwYu1p0/hqdefault.jpg
            double n = int.Parse(Console.ReadLine());
            double tot = 0;

            tot= (Math.Pow(1+Math.Sqrt(5),n) - Math.Pow(1-Math.Sqrt(5),n))/ Math.Pow(2,n)*Math.Sqrt(5);

            Console.WriteLine(tot.ToString("F1", CultureInfo.InvariantCulture));

            
        }
    }
}
