using System;

namespace _1134
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variaveis
            int Alcool = 0;
            int gasolina = 0;
            int disel =0;

            //Leitura de valores
            int combustivel = int.Parse(Console.ReadLine());
            do{
                combustivel = int.Parse(Console.ReadLine());

               //Testa o tipo de combustivel de acordo com a tabela
                if(combustivel == 1){
                    Alcool += 1;
                }
                if(combustivel == 2){
                    gasolina+=1;
                }
                if(combustivel==3){
                    disel+=1;
                }
                //encera  o programa quando o número informado for 4 
            }while(combustivel!=4);

            //Impreção de valores
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " +Alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + disel);

        }
    }
}
