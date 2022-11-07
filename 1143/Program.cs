using System;

namespace _1143
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração de valores
            double n1=1;
            double n2=1;
            double n3=1;
            


            //Define quantas veses o codigo se repete
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 0 ; i<n;++i){
                Console.WriteLine(n1 +" "+n2+ " "+ n3);//imprime os valores
                n1+=1;//o primeiro valor aumenta em 1
                n2=Math.Pow(n1,2);//elevado ao quadrado o primrir valor  
                n3 = Math.Pow(n1,3);//eleva ao cubo o terceiro valor
            }
            
        }
    }
}
