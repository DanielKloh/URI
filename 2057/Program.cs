using System;

namespace _2057
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leitura de dados
            string[] vetor = Console.ReadLine().Split();
            int saida = int.Parse(vetor[0]);
            int chegada = int.Parse(vetor[1]);
            int fuso = int.Parse(vetor[2]);
            
            //Calculo do fuso horário
            int soma = saida+chegada+fuso;
            if(soma>24){
                soma-=24;
            }
            if(soma==24){
                soma=0;
            }
            if(soma<0){
                soma+=24;
            }
            //Impreção de valores
            Console.WriteLine(soma);
        }
    }
}
