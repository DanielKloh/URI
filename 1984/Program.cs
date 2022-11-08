using System;

namespace _1984
{
    class Program
    {
        static void Main(string[] args)
        
        {   
            //Declaração de variavel vasia
            string invertido = "";
            //Le uma string que seria os números
            string cod = Console.ReadLine();

            //Estrutura de reptção
            //(Length)retorna a quantidade de caracteres no formato char
            //(Substring)Recupera uma subcadeia de caracteres desta instância.
            //A subcadeia de caracteres começa em uma posição de caractere especificado e
            //continua até o final da cadeia de caracteres.
            for(int i=cod.Length;i>0;i--){
                string letra = cod.Substring(i - 1, 1);
                invertido += letra;
            }
            Console.WriteLine(invertido);
        }
    }
}
