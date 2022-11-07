using System;

namespace _1149
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variaveis
            int x=0;
            int soma=0;
            int num1=0;
            int num2=0 ;
            int[] m= new int[100];
            string[] vetor = Console.ReadLine().Split();

            //Faça enquanto as duas variaveis não estiverem preechidas
            do{
                //Le um valor inteiro
                m[x]=int.Parse(vetor[x]);

                //So vai atender a esta condição se o "num1" ja estiver preenchido
                //e quando atender ,se outro numero informado for positivo
                //a variavel "num2" é preenchida e sai do while.    
                if(m[x]>0 && num1!=0){
                    num2=m[x];
                    
                    break;
                }

                if(m[x]>0){
                    num1=m[x];
                    
                }

                x+=1;

            }while(true);
        
        //faz a soma
        //ex: entrada 3 2
        //(3+0)+(3+1)=7
            for(int c=0;c<num2;c++){
                
                soma+=num1+c;
                
            }
            Console.WriteLine(soma);

       
           
            
        }
    }
}
