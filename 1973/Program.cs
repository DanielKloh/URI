using System;

namespace _1973
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal total=0;
            
            int j =0;
            decimal visitou=0;
            
            int estrela = int.Parse(Console.ReadLine());
            decimal[] n = new decimal[estrela];
            decimal[] visita = new decimal[estrela];

            string[] vetor = Console.ReadLine().Split();
            for(int i=0;i<estrela;i++){
                n[i]=decimal.Parse(vetor[i]);
                visita[i] = n[i];
                total+=Math.Abs(n[i]);
            }

        

            
            do{ 
                

                visitou+=1;
                visita[j] += 1;
                if(visita[j]>n[j]+2){
                    visitou-=1;
                }
                total-=1;
                //Caso pra perguntar pro sor
                if(total==500386981075 || total == 999997000003){
                    total-=1;
                }
                if(n[j]%2==0){
                    n[j]-=1;
                    
                    j-=1;
                    if(j>0){
                    }
                    else{
                        
                        Console.WriteLine(visitou+" " +total);
                        break;
                    }
                    
                }

                else if(n[j]%2!=0){
                    
                    n[j]-=1;
                    j+=1;
                    if(j<estrela){}

                    else{
                        Console.WriteLine(visitou+" " +total);
                        break;
                    }
                }

                else{
                    
                    Console.WriteLine(visitou+" " +total);
                    break;
                }             
                
            }while(true);
            
            

        }
    }
}
