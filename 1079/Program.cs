using System;
using System.Globalization;

namespace Nova_pasta
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for(int x =0 ;x<N;x++){
                string[] linha = Console.ReadLine().Split(' ');
                double teste1 = double.Parse(linha[0],CultureInfo.InvariantCulture);
                double teste2 = double.Parse(linha[1],CultureInfo.InvariantCulture);
                double teste3 = double.Parse(linha[2],CultureInfo.InvariantCulture);
                double media = ((teste1*2) + (teste2*3) + (teste3*5)) / 10.0;

                Console.WriteLine(media.ToString("F1",CultureInfo.InvariantCulture));
            }
        }
    }
}
