using System;

namespace _1144
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração de variaveis
            int n1 = 1;
            double n2 = 1;
            double n3 = 1;
            int contador = 1;

            //Çeitura de um valor multiplicado por 2
            int N = int.Parse(Console.ReadLine());
            N = N*2;
            

            //executa enuanto i < N
            for(int i = 0;i<N;++i){
                Console.WriteLine(n1 + " " + n2 + " " + n3);//Imprime os valores
                
                
                //Quando o contador atingir 2 (for executado 2 veses,xeto na primeira execução),o primeiro valor aumenta em 1,o segundo au quadrado e o terceiro ao cubo
                if(contador==2){
                    n1+=1;
                    n2=Math.Pow(n1,2);
                    n3=Math.Pow(n1,3);
                    contador=0;
                }
              

                if(contador == 1){//Na segunda ves que for executado os valores n1 e n2 aumentam em 1
                    n2+=1;
                    n3+=1;
                }

                contador+=1;//toda ves que o for é executado o contador aumenta em 1

            }
        }
    }
}
