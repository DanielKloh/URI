using System;

namespace _1047
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7 8 9 10 O JOGO DUROU 2 HORA(S) E 2 MINUTO(S)
            // 7 7 7 7 O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)
            // 7 10 8 9 O JOGO DUROU 0 HORA(S) E 59 MINUTO(S)

            int horai,
                minutoi,
                horaf,
                minutof,
                totalh,
                totalm;
            string[] Daniel = Console.ReadLine().Split();
            horai = int.Parse(Daniel[0]);
            minutoi = int.Parse(Daniel[1]);
            horaf = int.Parse(Daniel[2]);
            minutof = int.Parse(Daniel[3]);

            
            //horas
            
            if (horai < horaf)
            {
                totalh = horaf - horai;
            }
            else
            {
                totalh = 24 + (horaf - horai);
            }
            if(horaf==horai){
                totalh=0;
            }
            
            //minutos
            if (minutoi == minutof)
            {
                totalm = 0;
            }
            if (minutoi < minutof)
            {
                totalm = minutof - minutoi;
            }
            else
            {
                totalm = 60 + (minutof - minutoi);
                totalh-=1;
                if(totalh<0){
                    totalh=23;
                }
            }
            
            


            //menos que uma hora
            if ( horai==horaf )
            {
               if (minutoi == minutof)
            {
                totalm = 0;
            }
            if (minutoi < minutof)
            {
                totalm = minutof - minutoi;
            }
            else
            {
                totalm = 60 + (minutof - minutoi);
            } 
            }

            if(totalh==1 && minutoi>minutof){
                totalh-=1;
            }

            //impreção de valores
            if (horaf == horai && minutof == minutoi)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            }
            else
            {
                Console.WriteLine("O JOGO DUROU " + totalh + " HORA(S) E " + totalm + " MINUTO(S)");
            }
        }
    }
}
