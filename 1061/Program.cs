using System;

namespace _1061
{
    class Program
    {
        static void Main(string[] args)
        {

            // Codigo com Runtime error


            //Declaração de variavel
            int diafim,horainicio,horafim,segundoinicio,segundofim,minin,minfim;
            int totdia,toth,totm,tots;
            //dia inicio

        Console.Write("Dia ");
        int diainicio = int.Parse(Console.ReadLine());
        string line = Console.ReadLine();
        string[] tempoI = line.Split(':');
        horainicio = int.Parse(tempoI[0]);
        minin = int.Parse(tempoI[1]);
        segundoinicio = int.Parse(tempoI[2]);

        Console.Write("Dia ");
        diafim = int.Parse(Console.ReadLine());

        // vetor string dados encerramento da festa
        string line2 = Console.ReadLine();
        string[] tempoF = line2.Split(':');
        horafim = int.Parse(tempoF[0]);
        minfim = int.Parse(tempoF[1]);
        segundofim = int.Parse(tempoF[2]);


            //segundo
            if(segundofim==segundoinicio){
                tots=0;
            }
            if(segundoinicio>segundofim){
                tots=60-(minin-minfim);
            }
            else{
                tots=segundofim-segundoinicio;
            }

            //minuto

            if(minfim==minin){
                totm=0;
            }
            if(minin>minfim){
                totm=60-(horainicio-horafim);
            }
            else{
                totm=minfim-minin;
            }

            //hora e dai
            if(horafim==horainicio){
                toth=0;
            }
            if(horainicio>horafim){
                
                toth=24-(horainicio-horafim);
                totdia=(diafim-diainicio)-1;
            }
            else{
                
                toth=horafim-horainicio;
                totdia=diafim-diainicio;
            }

            //dia       

            

            Console.WriteLine(totdia+" dia(s)");
            Console.WriteLine(toth+" hora(s)");
            Console.WriteLine(totm+" minuto(s)");
            Console.WriteLine(tots+" segundo(s)");

            
            
            //Codigo sem Runtime error
            /*int W, X, Y, Z, resto, diaInicio, diaFinal, inicial, final, duracao;

            string[] dia = Console.ReadLine().Split(' ');
            diaInicio = int.Parse(dia[1]);

            string[] horas = Console.ReadLine().Split(':');
            int horaInicial = int.Parse(horas[0]);
            int minutoInicial = int.Parse(horas[1]);
            int segundoInicial = int.Parse(horas[2]);

             *  É feito o diaInicio -1 para calcular o dia de término do evento.
             *  Após isto, calculamos os valores em totalidade na sequencia -> * 24 horas * 60 minutos * 60 segundos.
             *  Em seguida, fazemos o procedimento para a hora inicial, na sequencia -> * 60 minutos * 60 segundos.
             *  Por último, este mesmo procedimento é feito para os minutos -> * 60 segundos

            inicial = (int)(diaInicio - 1) * 24 * 60 * 60 + horaInicial * 60 * 60 + minutoInicial * 60 + segundoInicial;

            dia = Console.ReadLine().Split(' ');
            diaFinal = int.Parse(dia[1]);

            horas = Console.ReadLine().Split(':');
            int horaFinal = int.Parse(horas[0]);
            int minutoFinal = int.Parse(horas[1]);
            int segundoFinal = int.Parse(horas[2]);

            final = (int)(diaFinal - 1) * 24 * 60 * 60 + horaFinal * 60 * 60 + minutoFinal * 60 + segundoFinal;

            duracao = final - inicial;

            //Divide-se a duracao de um dia pelos segundos totais de um dia (24hrs * 60min * 60seg)!
            W = duracao / (24 * 60 * 60);
            resto = duracao % (24 * 60 * 60);
            //Divide-se a duracao de uma hora pelos segundos totais da hora (60min * 60seg)!
            X = resto / (60 * 60);
            resto = resto % (60 * 60);
            //Divide-se a duracao dos minutos pelos segunsos totais do minuto.
            Y = resto / 60;
            //Usa-se o resto dos segundos, para encontrar o segundo.
            Z = resto % 60;

            Console.WriteLine(W + " dia(s)");
            Console.WriteLine(X + " hora(s)");
            Console.WriteLine(Y + " minuto(s)");
            Console.WriteLine(Z + " segundo(s)");*/

        }
    }
}
