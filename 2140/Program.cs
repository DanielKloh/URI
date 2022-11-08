using System;

namespace _2140
{
    class Program
    {
        static void Main(string[] args)
        {
            //2, 5, 10, 20, 50 e 100.

            // 7 12 22 52 102
            // 7 15 25 55 105
            // 12 15 30 60 110
            //22 25 30 70 120
            //52 55 60 70 150
            //  102 105 110 120 150 200

            // Troco possivel: 7 12 22 52 102  15 25 55 105 30 60 110 70 120   55 120 150 200
            
            //Repete o programa
            do{
                //Declaração de variavel
            int preco = 0;
            int pago = 0;
            int soma = 0;

            //leitura de dados
            string[] vetor = Console.ReadLine().Split();
            preco = int.Parse(vetor[0]);
            pago = int.Parse(vetor[1]);
            //calculo do troco
            soma = pago - preco;

            //se os valores digitados forem 0 0 encerra o loop e o programa
            if(preco==0 && pago==0){
                break;
            }

            //Testa se é possível ou não dar o troco com duas notas
            if (
                soma - 7 == 0
                || soma - 22 == 0
                || soma - 52 == 0
                || soma - 102 == 0
                || soma - 15 == 0
                || soma - 25 == 0
                || soma - 55 == 0
                || soma - 105 == 0
                || soma - 30 == 0
                || soma - 60 == 0
                || soma - 110 == 0
                || soma - 70 == 0
                || soma - 120 == 0
                || soma - 150 == 0
                || soma - 200 == 0
                || soma - 12 ==0
            )
            {
                Console.WriteLine("possible");
            }
            else{
                Console.WriteLine("impossible");
            }
            }while(true);
            
        }
    }
}
