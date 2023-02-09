using System;

namespace _2523
{
    class Program
    {
        static void Main(string[] args){

            do
            {
                int controle = 0;

                string alfabeto = Console.ReadLine();


                if(string.IsNullOrEmpty(alfabeto)){
                    break;
                }

                int num = int.Parse(Console.ReadLine());

                string[] str = Console.ReadLine().Split();
                int[] posicoes = new int[num];

                for (int i = 0; i < num; i++)
                {
                    posicoes[i] = int.Parse(str[i]);
                }

                for (int i = 0; i < num; i++)
                {
                    foreach (char c in alfabeto)
                    {
                        controle += 1;

                        if (controle == posicoes[i])
                        {
                            Console.Write(c);
                        }
                    }
                    controle = 0;
                }
                Console.WriteLine();

            } while (true);
        }
    }
}
