using System;

namespace _3342
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variavel
            double casas = 0;
            double casa_branca = 0;
            double casas_preta = 0;

            //Entrada de dados
            double tabuleiro = double.Parse(Console.ReadLine());

            //Calculo de quadrados do tabuleiro
            casas = tabuleiro * tabuleiro;

            //se for par ou impar
            if(casas %2 == 0 ){
                casa_branca = casas / 2;
                casas_preta = casas / 2;

                Console.WriteLine(casa_branca+" casas brancas e "+ casas_preta +" casas pretas");
            }

            else{
                casas_preta = Math.Round(casas/2);
                casa_branca = casas_preta + 1;
                Console.WriteLine(casa_branca+" casas brancas e "+ casas_preta +" casas pretas");
            }
        }
    }
}
