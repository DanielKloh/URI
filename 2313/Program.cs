using System;

namespace _2313
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração de variavel
            double cateto1 = 0;
            double cateto2 = 0;
            double hipotenusa = 0;

            //entrada de dados
            string[] vetor = Console.ReadLine().Split();
            int x1 = int.Parse(vetor[0]);
            int x2 = int.Parse(vetor[1]);
            int x3 = int.Parse(vetor[2]);

            //Se pode formar um triangulo
            if(x1 + x2 > x3 && x1 + x3 > x2 && x2 + x3 > x1){

                cateto1 = x2*x2;
                cateto2 = x3*x3;
                hipotenusa = x1*x1;

                //triangulo equilatero
                if(x1==x2 && x2==x3){
                    Console.WriteLine("Valido-Equilatero");
                    //se é retangulo
                    if(hipotenusa == cateto1+cateto2 || cateto1 == hipotenusa+cateto2 || cateto2 == hipotenusa+cateto1){
                        Console.WriteLine("Retangulo: S");
                    }
                    else{
                        Console.WriteLine("Retangulo: N");
                    }
                    
                }

                //triagulo isoceles
                else if(x1==x2 || x2==x3 || x3==x1){
                    Console.WriteLine("Valido-Isoceles");

                    //se é retangulo
                    if(hipotenusa == cateto1+cateto2 || cateto1 == hipotenusa+cateto2 || cateto2 == hipotenusa+cateto1){
                        Console.WriteLine("Retangulo: S");
                    }

                    else{
                        Console.WriteLine("Retangulo: N");
                    }
                }

                //triangulo escaleno
                else if(x1!=x2 && x2!=x3){
                    Console.WriteLine("Valido-Escaleno");

                    //se é retangulo
                    if(hipotenusa == cateto1+cateto2 || cateto1 == hipotenusa+cateto2 || cateto2 == hipotenusa+cateto1){
                        Console.WriteLine("Retangulo: S");
                    }

                    else{
                        Console.WriteLine("Retangulo: N");
                    }
                }


            }

            //Se não pode formar um triangulo
            else{
                Console.WriteLine("Invalido");
            }
        }
    }
}
