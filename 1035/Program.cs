using System;

namespace _1035
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada
            int A, B, C, D;

            string[] vetor  = Console.ReadLine().Split(' ');

            A = int.Parse(vetor[0]);
            B = int.Parse(vetor[1]);
            C = int.Parse(vetor[2]);
            D = int.Parse(vetor[3]);


            int soma1 = C+D;
            int soma2 = A+B;
            

            if(B>C && D>A && soma1>soma2 && C>0 && D>0 && A%2==0){
                Console.WriteLine("Valores aceitos");
            }
            else{
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}