using System;
using System.Globalization;

namespace _1041
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = Console.ReadLine().Split(' ');
            double x= double.Parse(vetor[0]);
            double y= double.Parse(vetor[1]);

            if(x>0 &&y>0){
                Console.WriteLine("Q1");
            }
            if(x<0 && y>0){
                Console.WriteLine("Q2");
            }
            if(x<0 && y<0){
                Console.WriteLine("Q3");
            }
            if(x>0 && y<0){
                Console.WriteLine("Q4");
            }
            if(x==0 && y==0){
                Console.WriteLine("Origem");
            }
            if(x==0 && y!=0){
                Console.WriteLine("Eixo Y");
            }
            if(x!=0 && y==0){
                Console.WriteLine("Eixo X");
            }

        }
    }
}
