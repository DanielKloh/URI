using System;

namespace _1150
{
    class Program
    {
        static void Main(string[] args)
        {
            int z=0;
            int contador = 0;
            int soma = 0;

            int x = int.Parse(Console.ReadLine());

            do{
                z=int.Parse(Console.ReadLine());
            }while (z<=x);

            do{
                 soma+= x;
            x+=1;
            contador+=1;
            }while(soma<=z);



            Console.WriteLine(contador);
            

           



            
                          
            

        }
    }
}
