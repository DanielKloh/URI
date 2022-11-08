using System;

namespace _1175
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variavel
            int j = 19;
            int[] num = new int[20];

            //Le 20 valores e os armazena
            for (int m = 0; m <= 19; m++)
            {
                num[m] = int.Parse(Console.ReadLine());
            }

            //Imprime os valores armazenados do forma decrescente
            for (int f = 0; f <= 19; f++)
            {
                Console.WriteLine("N[" + f + "] = " + num[j]);

                j -= 1;
            }
        }
    }
}
