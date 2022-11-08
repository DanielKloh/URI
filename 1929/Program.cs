using System;

namespace _1929
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = Console.ReadLine().Split();
            int a =int.Parse(vetor[0]);
            int b =int.Parse(vetor[1]);
            int c =int.Parse(vetor[2]);
            int d =int.Parse(vetor[3]);

            if(a<(b+c) && a> Math.Abs(b-c)||
              a<(b+d) && a > Math.Abs(b-d) ||
              a<(c+d) && a > Math.Abs(c-d) ||
              //
              b<(a+c) && b> Math.Abs(a-c)||
              b<(a+d) && b > Math.Abs(a-d) ||
              b<(c+d) && b > Math.Abs(c-d) ||
              //
              c<(a+b) && c> Math.Abs(a-b)||
              c<(b+d) && c > Math.Abs(b-d) ||
              c<(a+d) && c > Math.Abs(a-d) ||
              //
              d<(b+c) && d> Math.Abs(b-c)||
              d<(a+b) && d > Math.Abs(a-b) ||
              d<(a+c) && d > Math.Abs(a-c) 
              ){
                Console.WriteLine("S");
              }
              else{
                Console.WriteLine("N");
              }

        }
    }
}
