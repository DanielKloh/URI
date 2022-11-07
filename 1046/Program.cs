using System;

namespace _1046
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] vetor = Console.ReadLine().Split(' ');
            int hi, hf, horaf;
            hi = int.Parse(vetor[0]);
            hf = int.Parse(vetor[1]);

            if(hi < hf){
                horaf = hf-hi;
            }
            else{
                horaf = 24 -hi +hf;
            }
            Console.WriteLine("O JOGO DUROU " + horaf + " HORA(S)");

            

        }
    }
}
