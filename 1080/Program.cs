using System;

namespace _1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior;
            int posiçao=1;
            int entrada = int.Parse(Console.ReadLine());
            maior=entrada;

            for(int x =2; x <=100;x++){
                entrada = int.Parse(Console.ReadLine());
                if(entrada>maior){
                    maior=entrada;
                    posiçao=x;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(posiçao);
            Console.ReadKey();
        }
    }
}
