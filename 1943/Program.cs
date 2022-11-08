using System;

namespace _1943
{
    class Program
    {
        static void Main(string[] args)
        {
            //Top N
            //1, 3, 5, 10, 25, 50 e 100
            int colocacao = int.Parse(Console.ReadLine());

            if(colocacao==1){
                Console.WriteLine("Top 1");
            }
            else if(colocacao<=3){
                Console.WriteLine("Top 3");
            }
            else if(colocacao<=5){
                Console.WriteLine("Top 5");
            }
            else if(colocacao<=10){
                Console.WriteLine("Top 10");
            }
            else if(colocacao<=25){
                Console.WriteLine("Top 25");
            }
            else if(colocacao<=50){
                Console.WriteLine("Top 50");
            }
            else{
                Console.WriteLine("Top 100");
            }

        }
    }
}
