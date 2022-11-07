using System;

namespace _1072
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i =0;
            int dentro =0;
            int fora =0;
            while (i<n)
            {
                int num = int.Parse(Console.ReadLine());
                if(num>=10 && num<=20){
                    dentro+=1;
                }
                else{
                    fora+=1;
                }
                
                i += 1;
            }
            Console.WriteLine(dentro+" in");
            Console.WriteLine(fora+" out");
        }
    }
}
