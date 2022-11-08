using System;

namespace _2143
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int qtd = int.Parse(Console.ReadLine());
                int[] soma = new int[qtd];
                int[] num = new int[qtd];

                if (qtd == 0)
                {
                    break;
                }
                for (int i = 0; i < qtd; i++)
                {
                    num[i] = int.Parse(Console.ReadLine());
                    if (num[i] % 2 == 0)
                    {
                        soma[i] = (num[i] * 2) - 2;
                    }
                    else
                    {
                        soma[i] = (num[i] * 2) - 1;
                    }

                    Console.WriteLine(soma[i]);
                }
                for (int j = 0; j < qtd; j++) { }
            } while (true);
        }
    }
}
