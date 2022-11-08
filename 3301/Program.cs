using System;

namespace _3301
{
    class Program
    {
        static void Main(string[] args)
        {
            int pato1 = 0;
            int pato2 = 0;
            int pato3 = 0;
            String zeze = "zezinho";
            String hugo = "huguinho";
            String luiz = "luisinho";
            

            string[] vetor = Console.ReadLine().Split();
            pato1 = int.Parse(vetor[0]);
            pato2 = int.Parse(vetor[1]);
            pato3 = int.Parse(vetor[2]);

            if((pato2 > pato1 && pato1> pato3) || (pato2 < pato1 && pato1 < pato3)){
                Console.WriteLine(hugo);
            }

            else if(((pato1 > pato2 && pato2 > pato3) || (pato1 < pato2 && pato2 < pato3))){
                Console.WriteLine(zeze);
            }
            
            else{
                Console.WriteLine(luiz);
            }
        }
    }
}
