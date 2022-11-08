using System;
using System.Globalization;

namespace _1985
{
    class Program
    {
        static void Main(string[] args)
        {   
            /*1001 | R$ 1.50

            1002 | R$ 2.50

            1003 | R$ 3.50

            1004 | R$ 4.50

            1005 | R$ 5.50*/

            int x =int.Parse(Console.ReadLine());
            double tot = 0;

            for(int i = 0;i<x;i++){
                string[] vetor = Console.ReadLine().Split();
                int cod = int.Parse(vetor[0]);
                int qtd = int.Parse(vetor[1]);

                if(cod==1001){
                    tot+=qtd*1.50;
                }
                else if(cod==1002){
                    tot+=qtd*2.50;
                }
                else if(cod==1003){
                    tot+=qtd*3.50;
                }
                else if(cod==1004){
                    tot+=qtd*4.50;
                }
                else if(cod==1005){
                    tot+=qtd*5.50;
                }
            }
            Console.WriteLine(tot.ToString("F2",CultureInfo.InvariantCulture));
            tot=0;
        }
    }
}
