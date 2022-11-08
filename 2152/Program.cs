using System;

namespace _2152
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variavel
            int ocorrencia = 0;
            int hora = 0;
            int min =0;
            

            int casos = int.Parse(Console.ReadLine());

            for(int i =0;i<casos;i++){
                string[] horario = Console.ReadLine().Split();
                hora = int.Parse(horario[0]);
                min = int.Parse(horario[1]);
                ocorrencia = int.Parse(horario[2]);

                

                if(ocorrencia==1){
                    //.ToString("D'x'") adiciono zers a esquerda, onde 'x' é a quantidade de caracteres
                    Console.WriteLine(hora.ToString("D2")+":"+min.ToString("D2")+" - A porta abriu!");
                }
                else{
                    Console.WriteLine(hora.ToString("D2")+":"+min.ToString("D2")+" - A porta fechou!");
                }
            }

        }
    }
}
