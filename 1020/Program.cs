using System;

namespace _1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int anos, mes, dias, resto;
            string[] vet = Console.ReadLine().Split();
            int idade = int.Parse(vet[0]);

            anos = idade/365;
            resto= idade%365;
            mes = resto/30;
            dias = resto%30;

            Console.WriteLine(anos+" ano(s)");
            Console.WriteLine(mes+" mes(es)");
            Console.WriteLine(dias+" dia(s)");

        }
    }
}
