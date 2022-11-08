using System;

namespace _1789
{
    class Program
    {
        static void Main(string[] args)
        {  //Declaração de variavel
             int maior=0;
            
            //Faça enunto o valor informado não for nulo
            do{
                string x=(Console.ReadLine());
                if(x==null){
                    return;
                }
               int y=int.Parse(x);
              string[] vetor = Console.ReadLine().Split();
                

            
                //recebe a velocidade das lesmas
                for(int j=0;j<y;j++){
                    
                    int lesma=int.Parse(vetor[j]);
                    if(lesma>maior){
                        maior=lesma;
                    }
                    
                }
                //testa em qual categoria a lesma se ancaixa
                /*Nível 1: Se a velocidade é menor que 10 cm/h .
                Nível 2: Se a velocidade é maior ou igual a 10 cm/h e menor que 20 cm/h .
                Nível 3: Se a velocidade é maior ou igual a 20 cm/h. */
                if(maior<10){
                    Console.WriteLine(1);
                }
                else if(maior>=10&& maior<20){
                    Console.WriteLine(2);
                }
                else{
                    Console.WriteLine(3);
                }
                //zera a variavel
                maior=0;
            }while(true);
            
               

        }
    }
}
