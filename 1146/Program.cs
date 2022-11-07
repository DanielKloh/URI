using System;

namespace _1146
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variavel
            int x =0;


            //executa enquanto não informar zero
            do{
            int i = 1;
            x =int.Parse(Console.ReadLine());

            //se o número informado for 0 não executa
            if(x!=0){
             do{
                 //Se for o ultimo número da lista imprime sem o espaço no final
                if(i==x){
                    Console.Write(i);
                    Console.WriteLine();
                }
                else{//Imprime os numeros de 1 a x com espaço entre eles
                    Console.Write(i+" ");
                }
                i+=1;

            }while(i<=x);
            }
           

            }while(x>0);//quando o valor for zero encera o programa
        }
           
    }
}
