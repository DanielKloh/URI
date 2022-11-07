using System;

namespace _1078
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leitura de valorres
            int n = int.Parse(Console.ReadLine());

            //estrotura de repetção
            for (int i = 1; i <= 10; ++i)
            {
                int multiplicacao = n * i;//multiplicação

                //impreção dos valores
                Console.WriteLine(i + " x " + n + " = " + multiplicacao);
            }
        }
    }
}