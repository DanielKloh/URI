using System;

namespace _2061
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variavel
            int soma =0;
            string action= "";

            //Dados de entrada
            string[] vetor = Console.ReadLine().Split();
            int inicio = int.Parse(vetor[0]);
            int acao = int.Parse(vetor[1]);

            soma=inicio;
            
            //Leitura de valores
            for(int i  =0;i<acao;i++){
                action = Console.ReadLine();
                if(action=="fechou"){
                    soma-=1;
                    soma+=2;
                }
                else{
                    soma-=1;
                }
            }

            //Impreção de valores
            Console.WriteLine(soma);

        }
    }
}
