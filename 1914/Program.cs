using System;

namespace _1914
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variavel
            int soma=0;
            //Leitura de um valor inteiro de quantas veses vai se repitir o codigo
            int x = int.Parse(Console.ReadLine());
            

            for(int i=0;i<x;i++){
                //Leitura de dados
                string[] vetor = Console.ReadLine().Split();
                string nomea=vetor[0];
                string jogadaa=vetor[1];
                string nomeb=vetor[2];
                string jojgadab = vetor[3];

                string[] numero = Console.ReadLine().Split();
                int numeroa=int.Parse(numero[0]);
                int numerob=int.Parse(numero[1]);

                //soma dos números informados
                soma=numeroa+numerob;
                
                //Testa se é impar ou par
                if(jogadaa=="PAR"){
                    if(soma%2==0){
                        Console.WriteLine(nomea);
                    }
                    else{
                        Console.WriteLine(nomeb);
                    }
                }
                else if(jogadaa=="IMPAR"){
                    if(soma%2==0){
                        Console.WriteLine(nomeb);
                    }
                    else{
                        Console.WriteLine(nomea);
                    }
                }
                soma=0;
            }
        }
    }
}
