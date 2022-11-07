using System;

namespace _1095
{
    class Program
    {
        static void Main(string[] args)
        {
            int J=60;//Valor de J
            int I=1;//Valor de I
            Console.WriteLine("I="+I+" J="+J);

            //Estrotura de repetção
            while(J!=0){
                //I aumenta em 3 e J diminue em 5
                J-=5;
                I+=3;
                Console.WriteLine("I="+I+" J="+J);
            }
        }
    }
}
