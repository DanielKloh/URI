using System;

namespace _1159
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração de variaveis
            int soma=0;
            int cont = 0;

            //leitura de varlores
            int n = int.Parse(Console.ReadLine());


            
            do{

                do{
                    //Transforma o numero impar em par
                    if(n%2!=0){
                    n+=1;
                }


                //se o número for par a soma aumenta no múmero testado
                if(n%2==0){
                    soma+=n;
                    cont+=1;
                    n+=1;
                }
                
                }while(cont<5);
                Console.WriteLine(soma);
                

                 //zera as variaveis
                 soma=0;
                 cont=0;

                 //le outro número
                 n = int.Parse(Console.ReadLine());
            }while(n!=0);
        }
    }
}
