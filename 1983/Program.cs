using System;
using System.Globalization;

namespace _1983
{
    class Program
    {
        static void Main(string[] args)
        {
            int matricula,melhor=0;
            double nota=0,maior=0;
            int x = int.Parse(Console.ReadLine());

            

            for(int i =0;i<x;i++){
                string[] vetro = Console.ReadLine().Split();
                matricula=int.Parse(vetro[0]);
                nota=double.Parse(vetro[1],CultureInfo.InvariantCulture);

                if(nota>maior){
                    maior=nota;
                    melhor=matricula;
                }
                
            }
            
            if(maior>=8){
                Console.WriteLine(melhor);
            }
            else{
                Console.WriteLine("Minimum note not reached");
            }
            
        }
    }
}
