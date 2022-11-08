using System;

namespace _1177
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variaveis
            int x=0;
            //leitura de valor
            int t=int.Parse(Console.ReadLine());

            for(int i=0;i<1000;i++){

                if(x==t){
                x=0;
                }
                //Impreção de valores
                Console.WriteLine("N["+i+"] = "+x);
                //Toda a ves que é executado "x" aumenta em d1
                x+=1;
            }
        }
    }
}
