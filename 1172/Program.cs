using System;

namespace _1172
{
    class Program
    {
        static void Main(string[] args)
        {
            

            for(int i = 0;i<10;++i){
               int n = int.Parse(Console.ReadLine());
               if(n<=0){
                   Console.WriteLine("X["+i+"] = 1");
               }
               else{
                   Console.WriteLine("X["+i+"] = "+n);
               }
            }
        }
    }
}
