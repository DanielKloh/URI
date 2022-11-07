using System;

namespace _1132
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração de variaveis
            int soma = 0;
            int maior = 0;
            int menor = 0;
            //Leitura de valores
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            //Testa qual é o maior
            if (n1 > n2)
            {
                maior = n1+1;
                menor = n2;
            }
            if (n2 > n1)
            {
                maior = n2+1;
                menor = n1;
            }

            for (int i = menor; i < maior; ++i)
            {
                //Se não é multiplo de 13 "soma" aumenta em "i".
                if (i % 13 != 0)
                {
                    soma += i;
                }
            }
            //Impreção de valores
            Console.WriteLine(soma);
        }
    }
}
