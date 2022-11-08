using System;

namespace _2483
{
    class Program
    {
        static void Main(string[] args)
        {
            //entrada de dados
            int x = int.Parse(Console.ReadLine());

            //imprime a primeira parte da frase
            Console.Write("Feliz nat");
            //imprime a quantidade de "a" 
            for(int i = 0 ;i<x;i++){
                Console.Write("a");
            }
            //imprime o final da frase
            Console.WriteLine("l!");
        }
    }
}
