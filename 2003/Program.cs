using System;

namespace _2003
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                do
                {
                    string[] vetor = Console.ReadLine().Split(':');

                    int h = int.Parse(vetor[0]);
                    int m = int.Parse(vetor[1]);

                    if (h < 7)
                    {
                        m = 0;
                        Console.WriteLine("Atraso maximo: " + m);
                    }

                    else if (h == 7)
                    {
                        Console.WriteLine("Atraso maximo: " + m);
                    }

                    if (h == 8)
                    {
                        m += 60;
                        Console.WriteLine("Atraso maximo: " + m);
                    }

                    else if( h==9)
                    {
                        m += 120;
                        Console.WriteLine("Atraso maximo: " + m);
                    }
                    
                } while (true);

            }
            catch (System.Exception)
            {
                return;
                throw;
            }
        }
    }
}
