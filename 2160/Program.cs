using System;

namespace _2160
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int tamanho = str.Length;//Consta a quantidade de caracteres didgitados

            if(str.Length>80){
                Console.WriteLine("NO");
            }
            else{
                Console.WriteLine("YES");
            }
        }
    }
}
