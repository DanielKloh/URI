using System;

namespace _1564
{
    class Program
    {
        static void Main(string[] args)
        {
        
        
            do{
                
                string texto = Console.ReadLine();

                //se o valor for vasio
                //if((texto == String.Empty)){
                //    break;
                //}

                //se o valor for nulo
                if((texto == null)){
                    break;
                }
                             
                    int reclamacoes = int.Parse(texto);

                if(reclamacoes==0){
                    Console.WriteLine("vai ter copa!");
                }
                else{
                    Console.WriteLine("vai ter duas!");
                }
                
                
                
            }while(true);
        }
    }
}
