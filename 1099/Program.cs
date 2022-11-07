using System;

namespace n_sei_o_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; ++i)
            {
                string[] vetor = Console.ReadLine().Split();
                int n1 = int.Parse(vetor[0]);//le a posição [0]
                int n2 = int.Parse(vetor[1]);//le a posição [1]

                if (n1 == n2)//testa se n1 é igula 0
                {
                    Console.WriteLine(soma);
                }
                if (n1 > n2)//testa se n1 é maior que n2
                {
                    //n2 aumenta em uma e entra em loop até n2 ser o maior 
                    n2 += 1;
                    while (n1 > n2)
                    {
                        if (n2 % 2 != 0)//se for impar soma aumenta com o número
                        {
                            soma += n2;
                        }
                        n2 += 1;
                    }
                    Console.WriteLine(soma);
                }
                else if (n2 > n1)//testa se n2 é maior que n1
                {   
                    //n2 aumenta em uma e entra em loop até n1 ser o maior 
                    n1 += 1;
                    while (n2 > n1)
                    {
                        
                        if (n1 % 2 != 0)//se for impar soma aumenta com o número
                        {
                            soma += n1;
                        }
                        n1 += 1;
                    }
                    Console.WriteLine(soma);
                }
                soma=0;//soma recebe 0
            }
        }
    }
}
