using System;

namespace _1133
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração de variaveis
            int maior = 0;
            int menor = 0;
            
            //Leitura de valores
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());


            //Testa qua é o maior
            if(x>y){
                maior = x;
                menor = y+1;
            }
            if(y>x){
                maior= y;
                menor = x+1;
            }

            
            //Executa enquanto "i" menor que "maior" 
            for(int i =menor ; i<maior ; ++i){

                //Testa so o resto da divisão por 5 é igual a 3 ou 2 
                if(i%5 ==2 || i%5 ==3){
                    Console.WriteLine(i);
                }
            }
            


        }
    }
}
