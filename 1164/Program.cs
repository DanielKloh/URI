using System;

namespace _1164
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variavel
            int total_imperfeito=1;
            int total_prefeito = 0;

            //Leitura de valores
            int n = int.Parse(Console.ReadLine());


            //Executa quantas vese foi informado
            for(int i =0;i<n;i++){


                //leitura de valor
                int j = int.Parse(Console.ReadLine());
                //Testa se é perfeito ou não
                for(int ii=1;ii<j;ii++){
                    if(j%ii==0){
                    total_prefeito+=ii;
                }
                
                total_imperfeito+=1;
                }


                //Se for perfeito
                if(total_prefeito==j){
                    Console.WriteLine(total_prefeito+" eh perfeito");    
                }

                //Se não for perfeito
                else{
                    Console.WriteLine(total_imperfeito+" nao eh perfeito"); 
                }

                //resta as variaveis
                total_imperfeito=1;
                total_prefeito=0;
            }
            
        }
    }
}
