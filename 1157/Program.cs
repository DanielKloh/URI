using System;

namespace _1157
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leitura de um valor inteiro
            int n = int.Parse(Console.ReadLine());

            for(int i =1;i<=n;i++){
                //se o "i" for multiplo de "n" imprime o número
                if(n%i==0){
                    Console.WriteLine(i);
                }
            }
        }
    }
}
