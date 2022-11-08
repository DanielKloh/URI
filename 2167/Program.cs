using System;

namespace _2167
{
    class Program
    {
        static void Main(string[] args)
        {
            int k =0;
            int caso = int.Parse(Console.ReadLine());
            string[] vetor = Console.ReadLine().Split();
            int[] motor = new int[caso];

            for(int i =0;i<caso;i++){
                motor[i] = int.Parse(vetor[i]);
            }
            for(int j =1;j<caso;j++){
                k =  j-1;
                
                
                if(motor[k]>motor[j]){
                    j+=1;
                    k=-5;
                    Console.WriteLine(j);
                    break;
                }             
            }
            if(k!=-5){
                Console.WriteLine("0");
            }
            

        }
    }
}
