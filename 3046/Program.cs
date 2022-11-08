using System;

namespace _3046
{
    class Program
    {
        static void Main(string[] args)
        {
            //declara variavel
            int num = int.Parse(Console.ReadLine());
            int soma = 1;


            //faz a soma
            for(int i = 1; i<=num;i++){
                soma =soma +i+1; //aumenta em 1 pq sempre vai te uma linha a mais. EX: ao inves de 6 sao 7;
            }
            Console.WriteLine(soma);
        }
    }
}
