using System;

namespace _1930
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leitura de dados
            string[] tomada = Console.ReadLine().Split();
            int t1 = int.Parse(tomada[0]);
            int t2 = int.Parse(tomada[1]);
            int t3 = int.Parse(tomada[2]);
            int t4 = int.Parse(tomada[3]);

            //soma das entradas
            int soma = t1+t2+t3+t4;
            soma-=3;
            //impreção de valores
            Console.WriteLine(soma);
        }
    }
}
