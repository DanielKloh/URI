using System;

namespace _1175
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for(int i = 0;i<10;++i){
                
                
            //Leitura N
            int n = int.Parse(Console.ReadLine());
            
            //declaração de vetor e criação de instancia
            double[] valores = new double[n];
            
                
            if(i==9)
            {
            for(int j = 0;j<10;++j){
                
                Console.WriteLine("N["+ j +"] = "+valores[i]);
                }
            }
            }
            
        }
    }
}
