using System;
using System.Globalization;

namespace _2311
{
    class Program
    {
        static void Main(string[] args)
        {
            
            decimal subtrair = 0;
            decimal maior = 0;
            decimal menor = 0;
            decimal soma = 0;
            int rodadas = int.Parse(Console.ReadLine());
      
            decimal[] tot = new decimal[rodadas];
            string[] nome = new string[rodadas];
            decimal[] salto = new decimal[50];
            decimal[] tot2 = new decimal[rodadas];

            for(int i = 0 ; i<rodadas ;i++){

                //nome
                nome[i] = Console.ReadLine();

                decimal grau = decimal.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);//Grau de dificuldade

                //nota
                string[] vetor = Console.ReadLine().Split();
                for(int c = 0;c<7;c++){                
                salto[c] = decimal.Parse(vetor[c],CultureInfo.InvariantCulture);
                }
               

               menor = salto[i];
                //Diz o menor e o maior e faz a soma
                for(int j =0;j<7;j++){
    
                    soma += salto[j];
                    
                    if(salto[j]>maior){
                        if(j==0){
                        maior = salto[j];
                        menor = salto[j];
                        }
                        else{
                            maior = salto[j];
                        }
                        
                        
                    }
                    else if(salto[j] < menor) {
                        menor = salto[j];
                    }

                    
                }
        
                //soma final
                subtrair = maior+menor;
                soma-=subtrair;
                soma*=grau;
                tot[i] = soma;
                tot2[i] = tot[i];

                salto[i] = 0;
                soma=0;
                grau=0;
                maior=0;
                menor=0;
                tot[i] = 0;
                
            }

            for(int g = 0;g<rodadas;g++){
                Console.WriteLine(nome[g]+" " + tot2[g].ToString("F2",CultureInfo.InvariantCulture));
            }
            
        }
    }
}