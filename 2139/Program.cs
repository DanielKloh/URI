using System;

namespace _2139
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                do
                {
                    int tot = 0;
                    int mes = 0;
                    int dia = 0;

                    string[] vetor = Console.ReadLine().Split();

                
                    mes = int.Parse(vetor[0]);
                    dia = int.Parse(vetor[1]);

                    if (mes == 12)
                    {
                        if (dia == 25)
                        {
                            Console.WriteLine("E natal!");
                        }
                        else if (dia == 24)
                        {
                            Console.WriteLine("E vespera de natal!");
                        }
                        else if (dia >= 26)
                        {
                            Console.WriteLine("Ja passou!");
                        }
                        else
                        {
                            dia += 0;
                        }
                    }

                    else
                    {
                        if (mes == 1)
                        {
                            tot = 360 - dia;
                        }
                        else if (mes == 2)
                        {
                            tot = 329 - dia;
                        }
                        else if (mes == 3)
                        {
                            tot = 300 - dia;
                        }
                        else if (mes == 4)
                        {
                            tot = 269 - dia;
                        }
                        else if (mes == 5)
                        {
                            tot = 239 - dia;
                        }
                        else if (mes == 6)
                        {
                            tot = 208 - dia;
                        }
                        else if (mes == 7)
                        {
                            tot = 178 - dia;
                        }
                        else if (mes == 8)
                        {
                            tot = 147 - dia;
                        }
                        else if (mes == 9)
                        {
                            tot = 116 - dia;
                        }
                        else if (mes == 10)
                        {
                            tot = 86 - dia;
                        }
                        else if (mes == 11)
                        {
                            tot = 55 - dia;
                        }
                        Console.WriteLine("Faltam " + tot + " dias para o natal!");
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
