using System;
using System.Globalization;

namespace _1021
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            decimal[] notas = {100.00M, 50.00M, 20.00M, 10.00M, 5.00M, 2.00M};
            int[] qtdnotas = {0, 0, 0, 0, 0, 0};
            decimal[] moedas = {1.00M, 0.50M, 0.25M, 0.10M, 0.05M, 0.01M};
            int[] qtdmoedas = {0, 0, 0, 0, 0, 0};
            decimal entrada = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //notas
            if(entrada >= notas[0]){
                //qtd notas recebeu entras/100
                qtdnotas[0] = (int)Math.Floor(entrada/100);
                entrada = entrada%100;
            }

            if(entrada >= notas[1]){
                //qtd notas recebeu entras/100
                qtdnotas[1] = (int)Math.Floor(entrada/50);
                entrada = entrada%50;
            }
            if(entrada >= notas[2]){
                //qtd notas recebeu entras/100
                qtdnotas[2] = (int)Math.Floor(entrada/20);
                entrada = entrada%20;
            }
            if(entrada >= notas[3]){
                //qtd notas recebeu entras/100
                qtdnotas[3] = (int)Math.Floor(entrada/10);
                entrada = entrada%10;
            }
            if(entrada >= notas[4]){
                //qtd notas recebeu entras/100
                qtdnotas[4] = (int)Math.Floor(entrada/5);
                entrada = entrada%5;
            }
            if(entrada >= notas[5]){
                //qtd notas recebeu entras/100
                qtdnotas[5] = (int)Math.Floor(entrada/2);
                entrada = entrada%2;
            }
            //moedas
            if(entrada >= moedas[0]){//1.00
                qtdmoedas[0] = (int)Math.Floor(entrada/moedas[0]);
                entrada = entrada%moedas[0];
            }
            if(entrada >= moedas[1]){//0.50
                qtdmoedas[1] = (int)Math.Floor(entrada/moedas[1]);
                entrada = entrada%moedas[1];
            }
            if(entrada >= moedas[2]){//0.25
                qtdmoedas[2] = (int)Math.Floor(entrada/moedas[2]);
                entrada = entrada%moedas[2];
            }
            if(entrada >= moedas[3]){//0.10
                qtdmoedas[3] = (int)Math.Floor(entrada/moedas[3]);
                entrada = entrada%moedas[3];
            }
            if(entrada >= moedas[4]){//0.05
                qtdmoedas[4] = (int)Math.Floor(entrada/moedas[4]);
                entrada = entrada%moedas[4];
            }
            if(entrada >= moedas[5]){//0.01
                qtdmoedas[5] = (int)Math.Floor(entrada/moedas[5]);
                entrada = entrada%moedas[5];
            }
            //impreção dos valores
            Console.WriteLine("NOTAS:");

            //para i=0 até q i<=5 incremente i com 1
            for(int i = 0; i <= 5; i++)
            {
                Console.WriteLine(qtdnotas[1] + " nota(s) de R$ " + notas[i].ToString("F2",CultureInfo.InvariantCulture));
            }
            
            // Console.WriteLine(qtdnotas[0] + " nota(s) de R$ 100.00");
            // Console.WriteLine(qtdnotas[1] + " nota(s) de R$ 50.00");
            // Console.WriteLine(qtdnotas[2] + " nota(s) de R$ 20.00");
            // Console.WriteLine(qtdnotas[3] + " nota(s) de R$ 10.00");
            // Console.WriteLine(qtdnotas[4] + " nota(s) de R$ 5.00");
            // Console.WriteLine(qtdnotas[5] + " nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            //para i=0 até q i<=5 incremente i com 1
            for(int i = 0; i <= 5; i++)
            {
                Console.WriteLine(qtdmoedas[i] + " nota(s) de R$ " + moedas[i].ToString("F2",CultureInfo.InvariantCulture));
            }


            // Console.WriteLine(qtdmoedas[0] + " moeda(s) de R$ 1.00");
            // Console.WriteLine(qtdmoedas[1] + " moeda(s) de R$ 0.50");
            // Console.WriteLine(qtdmoedas[2] + " moeda(s) de R$ 0.25");
            // Console.WriteLine(qtdmoedas[3] + " moeda(s) de R$ 0.10");
            // Console.WriteLine(qtdmoedas[4] + " moeda(s) de R$ 0.05");
            // Console.WriteLine(qtdmoedas[5] + " moeda(s) de R$ 0.01");
            

        }
    }
}