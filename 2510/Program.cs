using System;

namespace _2510
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variavel
            string vilao = "";

            //Entrada de dados
            int x = int.Parse(Console.ReadLine());

            for(int i =0;i<x;i++){
                //Entrada de dados
                vilao = Console.ReadLine();
                
                //Impreção de valores
                if(vilao == "Batmain"){
                    Console.WriteLine("N");
                }
                else{
                    Console.WriteLine("Y");
                }
            }
        }
    }
}
