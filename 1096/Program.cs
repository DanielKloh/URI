using System;

namespace _1096
{
    class Program
    {
        static void Main(string[] args)
        {
            //Valor de I e J
            int I=1;
            int J = 7;

            //Estrotura de reptção. Se repete 14 vezes
            for(int i =0;i<=14;++i){
                
                Console.WriteLine("I="+I+" J="+J);
                J-=1;

                //Quando J for igual a 5, volta a valer 7.
                if(J<=4){
                    J=7;
                    I+=2;
                }
            }
        }
    }
}
