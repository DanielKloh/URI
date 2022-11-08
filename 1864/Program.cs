using System;

namespace _1864
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cada letra é equivalente a um número
            string[] x =new string[35];
            string l=x[1]="L",
                i=x[2]="I",
                f=x[3]="F",
                e=x[4]="E",
                espaco1 = x[5] = " ",
                i2=x[6]="I",
                s=x[7] = "S",
                espaco2 = x[8]=" ",
                n=x[9]="N",
                o=x[10]="O",
                t=x[11]="T",
                espaco3 = x[12]=" ",
                a = x[13]= "A",
                espaco4 = x[14]=" ",
                p =x[15] ="P",
                r=x[16] = "R",
                o2=x[17]="O",
                b=x[18]= "B",
                l2=x[19]="L",
                e2=x[20]="E",
                m=x[21]="M",
                espaco5 = x[22]=" ",
                t2 = x[23]="T",
                o3=x[24]="O",
                espaco6 =x[25] =" ",
                b2 = x[26]="B",
                e3=x[27]="E",
                espaco7=x[28]=" ",
                s2=x[29]="S",
                o4=x[30]="O",
                l3=x[31]="L",
                v=x[32]="V",
                e4=x[33]="E",
                d=x[34]="D";

            //Leitura de dados
            int contagem=int.Parse(Console.ReadLine());
            //Mostra as letras conforme o informado anteriormente 
            for(int q =1;q<=contagem;q++){
                if(q==contagem){
                    Console.WriteLine(x[q]);
                }
                else{Console.Write(x[q]);}
            }
        }
    }
}
