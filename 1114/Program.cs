using System;

namespace _1114
{
    class Program
    {
        static void Main(string[] args)
        {
            //Senha fixa
            int senha = 2002;

            //leitura de valor
            int n = int.Parse(Console.ReadLine());

            
            //Testa se a senha é valida
            if(n!=senha){
                
                //Enquanto n for diferente de da senha, repete até a senha estar correta
                while(n!=senha){
                Console.WriteLine("Senha Invalida");
                int N = int.Parse(Console.ReadLine());
                n=N;
            }
            }
            //Imprime a mensagem de "senha correta"
            Console.WriteLine("Acesso Permitido");
            


        }
    }
}
