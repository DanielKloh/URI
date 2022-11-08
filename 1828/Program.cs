using System;

namespace _1828
{
    class Program
    {
        static void Main(string[] args)
        {  //Declaração de variaveis
           string Sheldon="";
           string Raj="";

            //Leitura de dados
           int x=int.Parse(Console.ReadLine());
            
            /*
            a tesoura corta o papel;
            o papel embrulha a pedra;
            a pedra esmaga o lagarto;
            o lagarto envenena Spock;
            Spock destrói a tesoura;
            a tesoura decapita o lagarto;
            o lagarto come o papel;
            o papel contesta Spock;
            Spock vaporiza a pedra;
            a pedra quebra a tesoura.
            */


           for(int i=1;i<=x;i++){
                //Leitura de valores
                string[] vetor=Console.ReadLine().Split();
                Sheldon=vetor[0];
                Raj=vetor[1];

                //Se for empate
                if(Sheldon==Raj){
                    Console.WriteLine("Caso #"+i+": De novo!");
                }

                //Outros casos possíveis                
                else if(Sheldon=="pedra"){
                    if(Raj=="papel"){
                        Console.WriteLine("Caso #"+i+": Raj trapaceou!");
                    }
                    else if(Raj=="tesoura"){
                        Console.WriteLine("Caso #"+i+": Bazinga!");
                    }
                    else if(Raj=="lagarto"){
                        Console.WriteLine("Caso #"+i+": Bazinga!");
                    }
                    else if(Raj=="Spock"){
                        Console.WriteLine("Caso #"+i+": Raj trapaceou!");
                    }
                }


                else if(Sheldon=="papel"){
                     if(Raj=="pedra"){
                        Console.WriteLine("Caso #"+i+": Bazinga!");
                    }
                    else if(Raj=="tesoura"){
                        Console.WriteLine("Caso #"+i+": Raj trapaceou!");
                    }
                    else if(Raj=="lagarto"){
                        Console.WriteLine("Caso #"+i+": Raj trapaceou!");
                    }
                    else if(Raj=="Spock"){
                        Console.WriteLine("Caso #"+i+": Bazinga!");
                    }
                }


                else if(Sheldon=="tesoura"){
                    if(Raj=="pedra"){
                        Console.WriteLine("Caso #"+i+": Raj trapaceou!");
                    }
                    else if(Raj=="papel"){
                        Console.WriteLine("Caso #"+i+": Bazinga!");
                    }
                    else if(Raj=="lagarto"){
                        Console.WriteLine("Caso #"+i+": Bazinga!");
                    }
                    else if(Raj=="Spock"){
                        Console.WriteLine("Caso #"+i+": Raj trapaceou!");
                    }
                }


                else if(Sheldon=="lagarto"){
                    if(Raj=="pedra"){
                        Console.WriteLine("Caso #"+i+": Raj trapaceou!");
                    }
                    else if(Raj=="papel"){
                        Console.WriteLine("Caso #"+i+": Bazinga!");
                    }
                    else if(Raj=="tesoura"){
                        Console.WriteLine("Caso #"+i+": Raj trapaceou!");
                    }
                    else if(Raj=="Spock"){
                        Console.WriteLine("Caso #"+i+": Bazinga!");
                    }
                }


                else if(Sheldon=="Spock"){
                    if(Raj=="pedra"){
                        Console.WriteLine("Caso #"+i+": Bazinga!");
                    }
                    else if(Raj=="papel"){
                        Console.WriteLine("Caso #"+i+": Raj trapaceou!");
                    }
                    else if(Raj=="tesoura"){
                        Console.WriteLine("Caso #"+i+": Bazinga!");
                    }
                    else if(Raj=="lagarto"){
                        Console.WriteLine("Caso #"+i+": Raj trapaceou!");
                    }
                }


                
           }
        }
    }
}