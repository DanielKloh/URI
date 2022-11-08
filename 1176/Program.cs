using System;

namespace _1176
{
    class Program
    {
        static void Main(string[] args)
        {
            //OBS:Com os números com tipo int a partir de um determindo execução passa a ficar com valor negativo
            //Declaração de variavel
            double a=0;
            double b=1;
            double c=0;
            double exec=0;

            //leitura de valor
            double x = double.Parse(Console.ReadLine());


            //Executa quantas vesses foi informado
            for(int i =0;i<x;i++){
                double num=double.Parse(Console.ReadLine());
                do{
                    //se estiver na ultima exeecução imprime a mensagem
                    if(exec==num){
                    Console.WriteLine("Fib("+num+") = "+a);
                   }
                   c=a+b;
                   a=b;
                   b=c;
                   exec+=1;
                }while(exec<=num);    

                //zera as variaveis
                a=0;
                b=1;
                c=0;
                exec=0;
            }   
        }
    }
}
