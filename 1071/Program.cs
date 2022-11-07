using System;

namespace _1071
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,
                x,
                y;
            int soma = 0;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

             if(x%2!=0){
                if(x>0){
                    x-=1;
                }
                else{
                    x+=1;
                }
             }
             if(y%2!=0){
                if(y>0){
                    y-=1;
                }
                else{
                    y+=1;
                }
             }

            if (x > y)
            {
               
                for (i = x; i > y; i--)
                {
                    if (i % 2 != 0)
                    {
                        soma += i;
                      
                    }
                }Console.WriteLine(soma);
            }
            if (x < y)
            {
                for (i = x; i < y; i++)
                {
                    if (i % 2 != 0)
                    {
                        soma += i;
                        
                    }
                }Console.WriteLine(soma);
            }
            if(x==y){
                Console.WriteLine("0");
            }
        }
    }
}
