using System;

namespace _2031
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leitura de quantas veses vai executar
            int n = int.Parse(Console.ReadLine());

            for(int i =0;i<n;i++){
                //Entrada de dados
                string p1 = Console.ReadLine(); 
                string p2 = Console.ReadLine(); 

                //Testes
                if(p1=="ataque"){
                    if(p2=="ataque"){
                        Console.WriteLine("Aniquilacao mutua");
                    }
                    if(p2=="pedra"){
                        Console.WriteLine("Jogador 1 venceu");
                    }
                    if(p2=="papel"){
                        Console.WriteLine("Jogador 1 venceu");
                    }
                }

                if(p1=="pedra"){
                    if(p2=="ataque"){
                        Console.WriteLine("Jogador 2 venceu");
                    }
                    if(p2=="pedra"){
                        Console.WriteLine("Sem ganhador");
                    }
                    if(p2=="papel"){
                        Console.WriteLine("Jogador 1 venceu");
                    }
                }

                if(p1=="papel"){
                    if(p2=="ataque"){
                        Console.WriteLine("Jogador 2 venceu");
                    }
                    if(p2=="pedra"){
                        Console.WriteLine("Jogador 2 venceu");
                    }
                    if(p2=="papel"){
                        Console.WriteLine("Ambos venceram");
                    }
                }
            }
        }
    }
}
