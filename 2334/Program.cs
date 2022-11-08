using System;

namespace _2334
{
    class Program
    {
        static void Main(string[] args)
        {
            //declara variavel
            decimal patinhos = 0;
            do{
                //Entrada de dado
                patinhos = decimal.Parse(Console.ReadLine());

                //Testa se vai para o loop
                if(patinhos==-1){
                    break;
                }

                //Retira 1 do valor de patinhos mas não pode ficar com -1 patinho
                if(patinhos==0){
                    patinhos = 0;
                }
                else{
                    patinhos-=1;
                }
                
                //Imprime os valores
                Console.WriteLine(patinhos);
            }while(true);
        }
    }
}
