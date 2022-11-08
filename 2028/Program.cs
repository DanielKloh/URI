using System;

namespace _2028
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variavel
            int car = 1;
            do
            {
                int y = 1;
                int cont = 0;
                int x = 1;
                //Lietura de valor inteiro em string
                string texto = Console.ReadLine();
                //se o valor for nulo cancala
                if ((texto == null))
                {
                    break;
                }
                //Converte o valor lido em int
                int n = int.Parse(texto);

                //Se o valor digitado for 0;
                if (n == 0)
                {
                    y = 1;
                    Console.WriteLine("Caso " + car + ": " + y + " numero");
                    Console.WriteLine(0);
                    car += 1;
                }
                
                //Se não for 0;
                else
                {
                    //descobre o numero de casos e números
                    do
                    {
                        if (n != 0)
                        {
                            y += x;
                            cont += 1;
                            x += 1;
                        }
                    } while (cont < n);

                    //Imprime os valores
                    if (n != 0)
                    {
                        Console.WriteLine("Caso " + car + ": " + y + " numeros");
                    }
                    cont = 0;
                    x = 0;
                    y = 1;
                    car += 1;
                    do
                    {
                        if (n != 0)
                        {
                            if (x == 0)
                            {
                                Console.Write(x + " ");
                                x += 1;
                            }

                            for (int i = 0; i < x; i++)
                            {
                                if (i == x - 1 && cont == n - 1)
                                {
                                    Console.Write(x);
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.Write(x + " ");
                                }
                            }
                        }
                        y += x;
                        cont += 1;
                        x += 1;
                    } while (cont < n);
                }

                Console.WriteLine();
            } while (true);
        }
    }
}
