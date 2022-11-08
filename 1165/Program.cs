using System;

namespace _1165
{
    class Program
    {
        static void Main(string[] args)
        {
            //declração de variaveis
            int num = 0,
                primo = 0;

            //Leitura de valores
            int n = int.Parse(Console.ReadLine());

            //Executa quantas veses foi informado
            for (int i = 0; i < n; i++)
            {
                //Leitura de valores
                num = int.Parse(Console.ReadLine());

                //testa se é primo ou não
                for (int j = 2; j <= num; j++)
                {
                    if (num % j == 0)
                    {
                        primo += j;
                    }
                }

                //impreção de valores
                if (primo == num)
                {
                    Console.WriteLine(num + " eh primo");
                }
                else
                {
                    Console.WriteLine(num + " nao eh primo");
                }
                //zera a variavel
                primo = 0;
            }
        }
    }
}
