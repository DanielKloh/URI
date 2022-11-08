using System;

namespace _3302
{
    class Program
    {
        static void Main(string[] args)
        {
            int perguntas = int.Parse(Console.ReadLine());
            int[] resposta = new int[perguntas];

            for(int i =0;i<perguntas;i++){
                resposta[i] = int.Parse(Console.ReadLine());
            }

            for(int j =0; j<perguntas;j++){
                int k = j +1;
                Console.WriteLine("resposta "+k+": "+resposta[j]);
            }
        }
    }
}
