using System;

namespace _3303
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            string texto = Console.ReadLine();

            foreach(char v in texto){
                cont += 1;
            }
            if(cont>=10){
                Console.WriteLine("palavrao");
            }
            else{
                Console.WriteLine("palavrinha");
            }
        }
    }
}
