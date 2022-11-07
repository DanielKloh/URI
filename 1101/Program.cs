using System;

namespace _1101
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            
            
            do{
                string[] vetor = Console.ReadLine().Split();
            int n = int.Parse(vetor[0]);
            int m = int.Parse(vetor[1]);

            if(n<=0 || m <=0){
                return;
            }
            else if(n>m){
                
                while(n>=m){
                    Console.Write(m+" ");
                    soma+=m;
                    m+=1;
                }
            }
            else if(n<m){
                
                while(n<=m){
                    Console.Write(n+" ");
                    
                    soma+=n;
                    n+=1;
                }
            }
            Console.WriteLine("Sum="+soma);
            soma=0;
            }while(true);
            

        }
    }
}