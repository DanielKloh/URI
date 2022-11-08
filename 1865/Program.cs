using System;

namespace _1865
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Le quantos testes serão feitos
            int x =int.Parse(Console.ReadLine());
            
            
            for(int i =0;i<x;i++){
            string[] vetor = Console.ReadLine().Split();
            //Le o nome
            string nome = vetor[0];
            //Le a força
            int forca= int.Parse(vetor[1]);

            //Testa de é capas de levantar o martelo
            if(nome=="Thor"){
                Console.WriteLine("Y");
            }
            else{
                Console.WriteLine("N");
            }
            }
            
        }
    }
}
