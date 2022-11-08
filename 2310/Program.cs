using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Nova_pasta__2_
{
    class Program
    {
        static void Main(string[] args)
        {

            double saque = 0;
            double bloqueio = 0;
            double atak = 0;
            double saqueAcrto = 0;
            double bloqueioAcrto = 0;
            double atakAcrto = 0;
            double somaSaque = 0;
            double somaBlock = 0;
            double somaAtack =0;
            double somaSaqueAcerto = 0;
            double somaBlockAcerto = 0;
            double somaAtackAcerto =0;

            //entrada de dados
            int jogadores = int.Parse(Console.ReadLine());

            for(int i = 0 ; i < jogadores ; i++){

                string nome = Console.ReadLine();

                string[] Feoitos = Console.ReadLine().Split();
                saque = int.Parse(Feoitos[0]);
                bloqueio = int.Parse(Feoitos[1]);
                atak = int.Parse(Feoitos[2]);

                string[] Acertos = Console.ReadLine().Split();
                saqueAcrto = int.Parse(Acertos[0]);
                bloqueioAcrto = int.Parse(Acertos[1]);
                atakAcrto = int.Parse(Acertos[2]);

                somaSaque += saque;
                somaSaqueAcerto += saqueAcrto;

                somaBlock += bloqueio;
                somaBlockAcerto += bloqueioAcrto;

                somaAtack += atak;
                somaAtackAcerto += atakAcrto;
            }
            somaSaqueAcerto *= 100;
            saque = somaSaqueAcerto/somaSaque;

            somaBlockAcerto *= 100;
            bloqueio = somaBlockAcerto/somaBlock;

            somaAtackAcerto *= 100;
            atak = somaAtackAcerto/somaAtack;

            Console.WriteLine("Pontos de Saque: " + saque.ToString("F2",CultureInfo.InvariantCulture) + " %.");
            Console.WriteLine("Pontos de Bloqueio: " + bloqueio.ToString("F2",CultureInfo.InvariantCulture) + " %.");
            Console.WriteLine("Pontos de Ataque: " + atak.ToString("F2",CultureInfo.InvariantCulture) + " %.");

                
        }
    }
}
