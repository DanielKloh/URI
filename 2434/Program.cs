using System;

namespace _2439
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] vetor = Console.ReadLine().Split();
            int casos = int.Parse(vetor[0]);
            int saldoInicio = int.Parse(vetor[1]);

            int saldo = saldoInicio;
            int menor = saldoInicio;
            for(int i = 0; i<casos ;i++){
                int movimentacao = int.Parse(Console.ReadLine());
                saldo += movimentacao;

                if(saldo<menor){
                    menor = saldo;
                }
            }
            Console.WriteLine(menor);
        }
    }
}
