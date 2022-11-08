using System;

namespace _2059
{
    class Program
    {
        static void Main(string[] args)
        {
            //1=par
            //2=impar
            int j1 = 0;
            int j2 = 0;
            int jog1 = 0;
            int jog2 = 0;
            int roubo = 0;
            int acusa = 0;
            int soma = 0;

            //Leitura de dados
            string[] vetor = Console.ReadLine().Split();
            int x = int.Parse(vetor[0]);
            j1 = int.Parse(vetor[1]);
            j2 = int.Parse(vetor[2]);
            roubo = int.Parse(vetor[3]);
            acusa = int.Parse(vetor[4]);

            //Defini o que o jogador 1 escolheu
            
            if (x == 1)
            {
                jog1 = 1;
                jog2 = 2;
            }
            else
            {
                jog1 = 2;
                jog2 = 1;
            }

            //O valor de suas jogadas
            

            //Se o jogador 1 roubo
            

            if (roubo == 1)
            {
                if (acusa == 1)
                {
                    Console.WriteLine("Jogador 2 ganha!");
                    return;
                }
                else
                {
                    Console.WriteLine("Jogador 1 ganha!");
                    return;
                }
            }
            if (roubo == 0)
            {
                if (acusa == 1)
                {
                    Console.WriteLine("Jogador 1 ganha!");
                    return;
                }
                if (acusa == 0)
                {
                    //Se a soma das jogadas for impar ou par
                    soma = j1 + j2;
                    if (soma % 2 == 0)
                    {
                        soma = 1;
                    }
                    else
                    {
                        soma = 2;
                    }

                    //imprime os valores
                    if (soma == 1)
                    {
                        if (jog1 == 1)
                        {
                            Console.WriteLine("Jogador 1 ganha!");
                        }
                        else
                        {
                            Console.WriteLine("Jogador 2 ganha!");
                        }
                    }
                    if (soma == 2)
                    {
                        if (jog1 == 1 && jog2==2)
                        {
                            Console.WriteLine("Jogador 2 ganha!");
                        }
                        else
                        {
                            Console.WriteLine("Jogador 1 ganha!");
                        }
                    }
                }
            }
        }
    }
}
