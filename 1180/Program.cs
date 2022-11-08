using System;

namespace _1180
{
    class Program
    {
        static void Main(string[] args)
        {
            int menor=0,posicao=0;
           

            int x =int.Parse(Console.ReadLine());
            int a = x-1;
            int[] num=new int[x];
            string[] vet = Console.ReadLine().Split();

            //Leitura de valores
            for(int i=0;i<x;i++){
                 
                num[i]=int.Parse(vet[i]);
            }

            menor=num[0];
            for(int j=0;j<x;j++){
                if(num[j]<=menor){
                    menor=num[j];
                    posicao=j;
                }
                if(j==a){
                     Console.WriteLine("Menor valor: "+menor);
                    Console.WriteLine("Posicao: "+posicao);
                }
            }

        }
    }
}
