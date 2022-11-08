using System;

namespace _1858
{
    class Program
    {
        static void Main(string[] args)
        {
            int posicao = 0;
            int menor =1000;
       
            int[] x = new int[100];
            int t = int.Parse(Console.ReadLine());
            string[] vetor = Console.ReadLine().Split();

            for(int i=0;i<t;i++){
                x[i] = int.Parse(vetor[i]);
                if(x[i]<menor){
                    menor = x[i];
                    posicao=i+1;
                }
            }
            Console.WriteLine(posicao);
        }
    }
}
