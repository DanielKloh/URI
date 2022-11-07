using System;
using System.Globalization;

namespace _1154
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variaveis
            double contador=1,soma=0,media;

            //leitura de valores
            int idade = int.Parse(Console.ReadLine());
            soma+=idade;

            do{
                //le a um número enquanto for maior que 0
                idade = int.Parse(Console.ReadLine());
                //Quando a idade for negativa não executa o calculo
                if(idade<0){
                    soma+=0;
                    contador+=0;
                }
                //Quando a idade for positiva executa o calculo
                else{
                soma+=idade;
                contador+=1;
                
                }
            }while(idade>0);

            //Calculo da media
            media=soma/contador;
            //Impreção de valores
            Console.WriteLine(media.ToString("F2",CultureInfo.InvariantCulture));

            
        }
    }
}
