using System;

namespace _1131
{
    class Program
    {
        static void Main(string[] args)
        {
            int continuar = 0;
            int totalinter = 0;
            int totalgremio = 0;
            int empate = 0;
            int somagrenal =0;

            do
            {
                //Leitura de valores
                string[] vetor = Console.ReadLine().Split();
                int inter = int.Parse(vetor[0]);
                int gremio = int.Parse(vetor[1]);

                //perguntando se quer continuar
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                continuar = int.Parse(Console.ReadLine());
                

                //se a resposta não for valida fica repetindo ate ser valida
                if(continuar<1 || continuar>2){
                    do{
                        Console.WriteLine("Novo grenal (1-sim 2-nao)");
                        continuar = int.Parse(Console.ReadLine());
                    }while(continuar<1 || continuar>2);
                }
                

                //ve qual dtime ganhou ou se empatou
                if (inter > gremio)
                {
                        totalinter += 1;
                }
                else if (gremio > inter)
                {
                    totalgremio += 1;
                }
                else if(gremio == inter)
                {
                    empate += 1;
                }

            somagrenal +=1; //total de grenais
            } while (continuar != 2);


            
            //imporeção dos valores
            Console.WriteLine(somagrenal+" grenais");
            Console.WriteLine("Inter:" + totalinter);
            Console.WriteLine("Gremio:" + totalgremio);
            Console.WriteLine("Empates:" + empate);

            if(totalgremio>totalinter){
                Console.WriteLine("Gremio venceu mais");
            }
            if(totalinter>totalgremio){
                Console.WriteLine("Inter venceu mais");
            }
            if(totalinter==totalgremio){
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}
