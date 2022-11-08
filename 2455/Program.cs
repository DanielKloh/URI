using System;

namespace _2455
{
    class Program
    {
        static void Main(string[] args)
        {
            int p1,c1,p2,c2,lado1,lado2;

            string[] vetor = Console.ReadLine().Split();
            p1 = int.Parse(vetor[0]);
            c1 = int.Parse(vetor[1]);
            p2 = int.Parse(vetor[2]);
            c2 = int.Parse(vetor[3]);

            lado1 = p1*c1;
            lado2 = p2*c2;

            if(lado1==lado2){
                Console.WriteLine("0");
            }
            else if(lado1>lado2){
                Console.WriteLine("-1");
            }
            else if(lado1<lado2){
                Console.WriteLine("1");
            }
        }
    }
}
