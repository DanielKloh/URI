using System;

namespace _2235
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados
            string[] vetor = Console.ReadLine().Split();
            int viagem1 = int.Parse(vetor[0]);
            int viagem2 = int.Parse(vetor[1]);
            int viagem3 = int.Parse(vetor[2]);

            //Testa se vai voltar ao presente
            if(viagem1==viagem2&&viagem2==viagem3 || viagem2==viagem3 || viagem1==viagem3 || viagem1==viagem2){
                Console.WriteLine("S");
            }

            else if((viagem1 + viagem2)==viagem3){
                Console.WriteLine("S");
            }

            else if((viagem1 + viagem3)==viagem2){
                Console.WriteLine("S");
            }

            else if((viagem3 + viagem2)==viagem1){
                Console.WriteLine("S");
            }

                else if((viagem1 - viagem2)==viagem3){
                Console.WriteLine("S");
            }

            else if((viagem1 - viagem3)==viagem2){
                Console.WriteLine("S");
            }

            else if((viagem3 - viagem2)==viagem1){
                Console.WriteLine("S");
            }

            else{
                Console.WriteLine("N");
            }
        }
    }
}
