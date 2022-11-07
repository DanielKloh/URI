using System;

namespace _1097
{
    class Program
    {
        static void Main(string[] args)
        {
            //Valor de I e J
            int I = 1;
            int J = 7;
            int contador = 0;
            Console.WriteLine("I=" + I + " J=" + J);

            //Estrotura de reptção. Se repete 13 vezes
            for (int i = 0; i < 13; ++i)
            {
                //Na primeira execução, se repeta apenas 2 vezes, pois ja começa diminuindo 1
                if(i==1){
                    J -= 1;
                Console.WriteLine("I=" + I + " J=" + J);//Imprime valores
                

                if (contador>=1)
                {
                    J += 5;
                    I += 2;
                    contador=0;
                }
                contador+=1;
                

                }
                J -= 1;//J vai diminuir em 1 tda vez que for executado
                Console.WriteLine("I=" + I + " J=" + J);//Imprime valores
                

                //Quando se repetir 3 vezes , J aumenta em 5 e I em 2
                if (contador>=3)
                {
                    J += 5;
                    I += 2;
                    contador=0;
                }
                
                contador+=1;
                
            }
        }
    }
}
