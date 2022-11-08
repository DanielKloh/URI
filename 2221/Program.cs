using System;

namespace _2221
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variavel
            int bonus = 0;
            int atckD =0;
            int defD = 0;
            int nivelD = 0;
            int atckG =0;
            int defG = 0;
            int nivelG = 0;
            int somaD = 0;
            int somaG = 0;

            //Entrada de dados
            int batalhas = int.Parse(Console.ReadLine());

            
            for(int i = 0; i < batalhas ; i++){

                //Entrada de dados
                bonus = int.Parse(Console.ReadLine());

                string[] Dabriel = Console.ReadLine().Split();
                atckD = int.Parse(Dabriel[0]);
                defD = int.Parse(Dabriel[1]);
                nivelD = int.Parse(Dabriel[2]);

                string[] guarte = Console.ReadLine().Split();
                atckG = int.Parse(guarte[0]);
                defG = int.Parse(guarte[1]);
                nivelG = int.Parse(guarte[2]);

                //Testa se recebe o bonus
                if(nivelD%2==0){
                    nivelD = bonus;
                }
                else{
                    nivelD = 0;
                }
                somaD = (atckD + defD) / 2 + nivelD;

                
                if(nivelG%2==0){
                    nivelG = bonus;
                }
                else{
                    nivelG = 0;
                }
                somaG = (atckG + defG) / 2 + nivelG;

                //Mostra quem ganhou
                if(somaD == somaG){
                    Console.WriteLine("Empate");
                }
                else if(somaD > somaG){
                    Console.WriteLine("Dabriel");
                }
                else{
                    Console.WriteLine("Guarte");
                }
            }
        }
    }
}
