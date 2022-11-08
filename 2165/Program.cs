using System;

namespace _2165
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = Console.ReadLine();
            int teste = texto.Length;
            if(teste<=140){
                Console.WriteLine("TWEET");
            }
            else{
                Console.WriteLine("MUTE");
            }
        }
    }
}
