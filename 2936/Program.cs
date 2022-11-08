using System;

namespace _2936
{
    class Program
    {
        static void Main(string[] args)
        {
            /*O Curupira come 300

            O Boitatá come 1500

            O Boto come 600

            O Mapinguari 1000

            A Iara come 150

            Dona chica 225*/

            int Curupira = 300;
            int boitata = 1500;
            int boto = 600;
            int Mapinguari = 1000;
            int iara = 150;
            int chica = 225;
            int soma = 0;

            int[] qtd = new int[5];

            for (int i = 0; i < 5; i++)
            {
                qtd[i] = int.Parse(Console.ReadLine());
            }

            Curupira *= qtd[0];
            boitata *= qtd[1];
            boto *= qtd[2];
            Mapinguari *= qtd[3];
            iara *= qtd[4];

            soma = Curupira + boitata + boto + Mapinguari + iara + chica;

            Console.WriteLine(soma);
        }
    }
}
