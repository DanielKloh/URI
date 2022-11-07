using System;

namespace _1151
{
    class Program
    {
        static void Main(string[] args)
        {

        

            //Declaração de valores
            double a =0;
            double b =1;
            double c=0;
            
            //Leitura de valores
            double N = double.Parse(Console.ReadLine());

            
            
            

            //Estrotura de repetção
            for (int i =0;i<N;i++){
                
                //Na ultima execução imprime sem o espaço
                if(i==N-1){
                    
                    Console.WriteLine(a);
                }
                //imprime com espaço entre os valores
                else{
                    Console.Write(a+" ");
                }

               //soma da sequencia Fibonacci 
                c=a+b;
                a=b;
                b=c;
                
                
                
                
            }
        }
    }
}
