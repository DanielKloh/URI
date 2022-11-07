using System;

namespace _1153
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração de variaveis
            int fatorial = 1;

            //Leitura de valores
            int num = int.Parse(Console.ReadLine());

            //Calculo do fatorial
            for(int i =1; i<=num;i++){
                fatorial*=i;
                
                
            }
            Console.WriteLine(fatorial);


        }
    }
}
