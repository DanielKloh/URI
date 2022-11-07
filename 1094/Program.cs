using System;
using System.Globalization;

namespace _1094
{
    class Program
    {
        static void Main(string[] args)

        {   //leitura de um valor inteiro que diz quantas vezes o código se repete
            int n = int.Parse(Console.ReadLine());

            //Define o valor das variaveis
            int coelho =0;
            int rato =0;
            int sapo =0;
            
            //Estrotura de reptção
            for(int i =0;i<n;++i){
                
                string[] valores = Console.ReadLine().Split();// vetor de string
                int quantia = int.Parse(valores[0]);//Na posição [0], le um valor inteiro
                string tipo=(valores[1]);//Na posição [1], le uma string


                if(valores[1]=="C"){
                    coelho+=quantia;//soma da quantidade de coelhos
                }
                if(valores[1]=="R"){
                    rato+=quantia;//soma da quantidade de ratos
                }
                if(valores[1]=="S"){
                    sapo+=quantia;//soma da quantidade de sapos
                }
                
            }

            //Impreção dos valores
            int total = coelho+sapo+rato;
            double persentcoelho = (double)coelho/total*100;
            double persentrato = (double)rato/total*100;
            double persentsapo = (double)sapo/total*100;
            
            Console.WriteLine("Total: "+total+" cobaias");
            Console.WriteLine("Total de coelhos: "+coelho);
            Console.WriteLine("Total de ratos: "+rato);
            Console.WriteLine("Total de sapos: "+sapo);
            Console.WriteLine("Percentual de coelhos: "+persentcoelho.ToString("F2",CultureInfo.InvariantCulture)+" %");
            Console.WriteLine("Percentual de ratos: "+persentrato.ToString("F2",CultureInfo.InvariantCulture)+" %");
            Console.WriteLine("Percentual de sapos: "+persentsapo.ToString("F2",CultureInfo.InvariantCulture)+" %");

        }
    }
}
