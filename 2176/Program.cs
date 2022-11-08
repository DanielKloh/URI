using System;

namespace _2176
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int tamanho = str.Length;
            int[] mensage = new int[tamanho];

            for(int i =0; i<tamanho;i++){
                mensage[i] = tamanho;
            }


            for(int j = 0; j<tamanho;j++){
                 Console.WriteLine("a "+mensage[j]);
            }
        }
    }
}
