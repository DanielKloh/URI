using System;

namespace _1070
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            
            int x=N+12;

            for(int n =N ;n<x; n++){
                if(n%2 !=0){
                    Console.WriteLine(n);
                }
            }

            
        }
    }
}
