using System;

namespace _2540
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                do
                {
                    int quantidade = int.Parse(Console.ReadLine());
                    string[] vetor = Console.ReadLine().Split();

                    Double total = 0;
                    int[] votos = new int[quantidade];

                    for (int i = 0; i < quantidade; i++)
                    {
                        votos[i] = int.Parse(vetor[i]);

                        if (votos[i] == 1)
                        {
                            total += 1;
                        }
                    }

                    if (total >= quantidade * 0.6666)
                    {
                        Console.WriteLine("impeachment");
                    }
                    else
                    {
                        Console.WriteLine("acusacao arquivada");
                    }
                } while (true);
            }
            catch (System.Exception)
            {
                return;
            }
        }
    }
}
