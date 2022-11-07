using System;

namespace _1075
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de valores
            int n = int.Parse(Console.ReadLine());
            int i =0;

            //Enquanto i<=10000
            while(i<=10000){

                //Testa se o resto da divisão por n é igual a 2
                if(i%n==2){
                    //imprimindo valor de i
                    Console.WriteLine(i);
                }
                //Quando é executado, aumenta o valor de i em 1
                i+=1;
            }
        }
    }
}
