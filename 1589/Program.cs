using System;

namespace _1589
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variaveis
            int num1=0;
            int num2=0;
            int soma=0;

            //Leitura de valores
            int x=int.Parse(Console.ReadLine());
            
            for(int i=0;i<x;i++){
                //Le os raios
                string[] vetor =Console.ReadLine().Split();
                num1=int.Parse(vetor[0]);
                num2=int.Parse(vetor[1]);

                //soma
                soma=num1+num2;

                //Impreção de valores
                Console.WriteLine(soma);

                //zera as variaveis
                soma=0;
                num1=0;
                num2=0;
            }
        }
    }
}
