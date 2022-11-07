using System;

namespace _1158
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração de valores
            int soma = 0;

            //Leitura de valores
            int n = int.Parse(Console.ReadLine());

            for(int i=0;i<n;i++){

                string[] vetor = Console.ReadLine().Split();
                int x =int.Parse(vetor[0]);//le o valor inicial
                int y =int.Parse(vetor[1]);//Quantos números impares deve somar

                do{
                    
                    //Testa se é impar ou par, se for par vira impar
                    if(x%2==0){
                        x+=1;
                        
                    }

                    //Se o número for impar a soma aumenta em "x"
                    if(x%2!=0){
                        y-=1;
                        soma+=x;
                    }
                    x+=1;
                    
                }while(y>0);
                //impreção de valores
                Console.WriteLine(soma);
                
                //zera a variavel
                soma=0;
                
            }
            
        }
    }
}
