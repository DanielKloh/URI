using System;

namespace _1962
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variavel
            int soma =0;
            //Leitura de dados
            int x = int.Parse(Console.ReadLine());

            for(int i =0;i<x;i++){
                //Leitura de dados
                int num = int.Parse(Console.ReadLine());
                //testes
                soma = 2015 - num;
                if(soma>0){
                    Console.WriteLine(soma+" D.C.");
                }
                else
                {
                    soma-=1;
                    soma*=-1;
                    Console.WriteLine(soma+" A.C.");
                }
            }
        }
    }
}
