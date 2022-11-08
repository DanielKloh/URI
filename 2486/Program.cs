using System;

namespace _2486
{
    class Program
    {
        static void Main(string[] args)
        {
            //suco de laranja	120 mg
            // morango fresco	85 mg
            // mamao	85 mg
            // goiaba vermelha	70 mg
            // manga	56 mg
            // laranja	50 mg
            // brocolis	34 mg


            //Declaração de variavel
            int quantidade = 0;
            string nome = "";
            double soma = 0;

            do{
                int x = int.Parse(Console.ReadLine());

                //Para o programa
               if(x<=0){
                break;
               } 

                for( int i =0; i<x;i++){
                    //Entrada de dados
                    string[] vetor = Console.ReadLine().Split();
                    quantidade = int.Parse(vetor[0]);
                    nome = vetor[1];
                
                //Testa qual o desconto
                //so le a primeira palavra de cada produto
                if(nome == "suco"){
                    soma += 120*quantidade;
                }
                else if(nome == "morango"){
                    soma += 85*quantidade;
                }
                else if(nome == "mamao"){
                    soma += 85*quantidade;
                }
                else if(nome == "goiaba"){
                    soma += 70*quantidade;
                }
                else if(nome == "manga"){
                    soma += 56*quantidade;
                }
                else if(nome == "laranja"){
                    soma += 50*quantidade;
                }
                else if(nome == "brocolis"){
                    soma += 34*quantidade;
                }
                }

                //imprime os valores finais
                if(soma > 130){
                    soma -= 130;
                    Console.WriteLine("Menos " +soma +" mg");
                }
                else if( soma<110){
                    soma -= 110;
                    soma *= -1;
                    Console.WriteLine("Mais "+soma+" mg");
                }
                else{
                    Console.WriteLine(soma + " mg");
                }
                soma = 0;

            }while(true);
        }
    }
}
