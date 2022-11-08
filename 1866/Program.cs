using System;

namespace _1866
{
    class Program
    {
        static void Main(string[] args)
        {
            //leitura de dados
            int a = int.Parse(Console.ReadLine());

            for(int i=0;i<a;i++){
                //Informa o valor para testar se é impar ou par
                int x =int.Parse(Console.ReadLine());
                //se for par a soma final é 0
                if(x%2==0){
                    Console.WriteLine("0");
                }
                //Se não é impar
                else{
                    Console.WriteLine("1");
                }
            }
        }
    }
}
