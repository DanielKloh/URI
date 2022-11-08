using System;

namespace _2060
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variavel
            int a=0,b=0,c=0,d=0;

            int n = int.Parse(Console.ReadLine());//quantas veses vai se repitir
            string[] vetor = Console.ReadLine().Split();

            int[] num = new int[n];

            for(int i =0; i<n ;i++){
                num[i]=int.Parse(vetor[i]);//Entrada de valores
            }

            //Testes
            for(int j =0 ;j<n; j++){
                if(num[j]%2==0){
                    a +=1;
                }

                if(num[j]%3==0){
                    b +=1;
                }

                if(num[j]%4==0){
                    c +=1;
                }

                if(num[j]%5==0){
                    d +=1;
                }
            }

            //Impreção de valore
            Console.WriteLine(a+" Multiplo(s) de 2");
            Console.WriteLine(b+" Multiplo(s) de 3");
            Console.WriteLine(c+" Multiplo(s) de 4");
            Console.WriteLine(d+" Multiplo(s) de 5");
        }
    }
}
