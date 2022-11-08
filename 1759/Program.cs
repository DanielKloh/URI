using System;

namespace _1759
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variaveis
            int y=0;
            //Leitura de valores
            int x=int.Parse(Console.ReadLine());
            
            
            int z =x-1;
            
            do{
                //Testa se for a ultima execução do while
                if(y==z){
                    Console.WriteLine("Ho!");
                }
                //Se não for a ultima execução 
                else{
                    Console.Write("Ho ");
                    }
                
                y+=1;
            }while(y<x);
        }
    }
}
