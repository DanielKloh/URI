using System;

namespace _1044
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = Console.ReadLine().Split(' ');
            int A = int.Parse(vetor[0]);
            int B = int.Parse(vetor[1]);

            if(A%B==0||B%A==0){
                Console.WriteLine("Sao Multiplos");
            }
            else{
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
