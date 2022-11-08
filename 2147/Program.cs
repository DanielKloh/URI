using System;
using System.Globalization;

namespace _2147
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variavel
            int casos = 0;
            double tamanhao = 0;
            string galopeia = "";
            double soma =0;

            //Quantas veses vai execultar o codigo 
            casos = int.Parse(Console.ReadLine());

            for(int i=0;i<casos;i++){
                //Entrada de dados
                galopeia = Console.ReadLine();
                tamanhao = galopeia.Length;//Consta a quantidade de caracteres didgitados
                //Calculo da %
                soma = tamanhao/100;
                //Imprime o valor com 2 casa decimais na cultura invariante
                Console.WriteLine(soma.ToString("F2",CultureInfo.InvariantCulture));
            }
        }
    }
}
