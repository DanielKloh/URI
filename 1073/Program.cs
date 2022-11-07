using System;

namespace _1073
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de valores
            int n = int.Parse(Console.ReadLine());
            int N=n;

            //Estrutura de reptção.
            //Para i < N ,é executado.
            for(int i=0;i<=N;++i){

                //Testa se é par ou não
                if(i%2==0 && i>=1){

                    //Eleva ao quadrado
                    double quadrado = Math.Pow(i,2);

                    //Imprime valores
                    Console.WriteLine(i+"^2 = "+ quadrado);
                }
            }
        }
    }
}
