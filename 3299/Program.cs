using System;

namespace _3299
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 0;
            int x =0;
            string numero = Console.ReadLine();

            foreach(char v in numero){
                
                if(v != '3'){
                    x=0;
                }

                if(v == '1'){
                    x=1;
                }
                
                if(v=='3' && x == 1){
                    
                    Console.WriteLine( numero + " es de Mala Suerte");
                    y=1;
                    break;
                }
                
            }

            if(y==0 ){
                Console.WriteLine(numero + " NO es de Mala Suerte");
            }
        }
    }
}
