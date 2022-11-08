using System;
using System.Globalization;

namespace _1182
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração de variavel
            double soma=0;

            //Leitura de valor
            int coluna = int.Parse(Console.ReadLine());
            string T = (Console.ReadLine());


            //Le uma matriz [12][12]
            for(int j =0;j<12;j++){

                for (int i=0;i<12;i++){
                double indice=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                //Quando estiver na coluna informada executa a soma desses números
                if(coluna==i){
                soma+=indice;
                }
            }
            }
            
           
           //Impreção de valores
           if(T=="S"){
            Console.WriteLine(soma.ToString("F1",CultureInfo.InvariantCulture));
           }

           if(T=="M"){
            double media=soma/12;
            Console.WriteLine(media.ToString("F1",CultureInfo.InvariantCulture));
           }
        }
    }
}
