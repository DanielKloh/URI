using System;

namespace _1145
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variavel
            int contador = 0;
            string[] vetor = Console.ReadLine().Split();
            int x = int.Parse(vetor[0]);
            int y = int.Parse(vetor[1]);

            //Executa conforme foi informado na segunde posição do vetor
            for(int i = 1;i<=y;++i){
                
                contador+=1;
                
                //Na executa antes da quebra de linha
                if(contador!=x){
                    Console.Write(i+" ");
                }
                
                    
                
                
                //Ma execução  antes da quebra de linha imprime sem o espaço no final
                if(contador==x){
                    Console.Write(i);
                    Console.WriteLine();
                    contador=0;
                }
                
            }
        }
    }
}
