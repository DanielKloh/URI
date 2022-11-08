using System;

namespace _1837
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variavel
            int a,b,q,r;

            //Leitura de valor
            string[] vetor = Console.ReadLine().Split();
            a=int.Parse(vetor[0]);
            b=int.Parse(vetor[1]);

            //Calcuo
            if(a>0){
                q=a/b;
                r=a%b;
            }
            else{
                int x,y=0;;

                if(b<0){
                    x=b*-1;
                }
                else{
                    x=b;
                }

                for(r=0;r<x;r++){
                    y=a-r;
                    if(y%b==0){
                        break;
                    }
                }
                q = y/b;
            }
            
            

            //Impreção de valores
            Console.WriteLine(q+" "+r);
        }
    }
}
