using System;
using System.Globalization;

namespace _1018
{
    class Program
    {
        static void Main(string[] args)
        {//576
            int cem, cinquenta, vinte, dez,cinco, dois,um, resto, valor1;
            valor1 = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            cem = valor1/100;
            // 76
            resto = valor1%100;
            valor1 = resto;

            // 1
            cinquenta = resto/50;

            //26      76/50
            resto = resto%50;
            valor1 = resto;
            // 1 
            vinte = resto/20;
            valor1 = resto;
            // 6 
            resto = resto%20;

            // 0
            dez = resto/10;
            valor1 = resto;
            
            //      6 / 10         
            resto = resto%10;

            // 1
            cinco= valor1/5;
            
            resto = resto%5;
            valor1 = resto;


            dois = valor1/2;
            resto = resto%2;
            valor1 = resto;



            um = valor1/1;
            resto = resto%1;
            

            var n = valor1;
            


            Console.WriteLine(n);
            Console.WriteLine(cem + " nota(s) de R$ 100,00");
            Console.WriteLine(cinquenta + " nota(s) de R$ 50,00");
            Console.WriteLine(vinte + " nota(s) de R$ 20,00");
            Console.WriteLine(dez + " nota(s) de R$ 10,00");
            Console.WriteLine(cinco + " nota(s) de R$ 5,00");
            Console.WriteLine(dois + " nota(s) de R$ 2,00");
            Console.WriteLine(um + " nota(s) de R$ 1,00");



            //int N, nota100, nota50, nota20, nota10, nota5, nota2, nota1, resto;

            //N = int.Parse(Console.ReadLine());

            //nota100 = N / 100;
            //resto = N % 100;

            //nota50 = resto / 50;
            //resto = resto % 50;

            //nota20 = resto / 20;
            //resto = resto % 20;

            //nota10 = resto / 10;
            //resto = resto % 10;

            //nota5 = resto / 5;
            //resto = resto % 5;

            //nota2 = resto / 2;
            //resto = resto % 2;

            //nota1 = resto / 1;
            //resto = resto % 1;

            //Console.WriteLine(N);
            //Console.WriteLine(nota100 + " nota(s) de R$ 100,00");
            //Console.WriteLine(nota50 + " nota(s) de R$ 50,00");
            //Console.WriteLine(nota20 + " nota(s) de R$ 20,00");
            //Console.WriteLine(nota10 + " nota(s) de R$ 10,00");
            //Console.WriteLine(nota5 + " nota(s) de R$ 5,00");
            //Console.WriteLine(nota2 + " nota(s) de R$ 2,00");
            //Console.WriteLine(nota1 + " nota(s) de R$ 1,00");
            
        }
        
    }
}
