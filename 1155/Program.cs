using System;
using System.Globalization;

namespace _1155
{
    class Program
    {
        static void Main(string[] args)
        {
            double s=0,j=1.0;
            for(int i =1;i<=100;i++){
                s+=(1/j);
                j++;
            }
            Console.WriteLine(s.ToString("F2",CultureInfo.InvariantCulture));
                    
        }
    }
}
