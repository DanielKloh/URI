using System;

namespace _2162
{
    class Program
    {
        static void Main(string[] args)
        {
            int caso = int.Parse(Console.ReadLine());
            string[] vetor = Console.ReadLine().Split();
            int[] obs = new int[caso];
            int teste = 0;

            for(int i = 0;i<caso;i++){
                obs[i] = int.Parse(vetor[i]);
            }

            for (int j = 1;j<caso;j++){
                int k = j-1;

                if(teste==2){
                    if(obs[j]>obs[k]){
                    teste = 0;
                    break;
                    
                }
                else{
                    teste=1;
                }
                }

                else if(teste==3){
                    if(obs[j]<obs[k]){
                        teste=0;
                        break;
                    }
                    else{
                        teste=1;
                    }
                }

                if(obs[j]==obs[k]){
                    teste=0;
                    break;
                }

                else if(obs[j]>obs[k]){
                    teste = 2;
                }

                else if(obs[j]<obs[k]){
                    teste=3;
                }
            }
            
            if(teste!=0){
                Console.WriteLine("1");
            }
            else{
                Console.WriteLine("0");
            }
            
            
           
        }
    }
}
