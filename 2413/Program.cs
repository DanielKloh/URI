using System;

namespace _2413
{
    class Program
    {
        static void Main(string[] args)
        {
            /*João fez uma pesquisa em seu site de busca predileto, e encontrou a resposta que estava procurando no terceiro link listado. Além disso, ele viu, pelo site, que t pessoas já haviam clicado neste link antes. João havia lido anteriormente, também na Internet, que o número de pessoas que clicam no segundo link listado é o dobro de número de pessoas que clicam no terceiro link listado. Nessa leitura, ele também descobriu que o número de pessoas que clicam no segundo link é a metade do número de pessoas que clicam no primeiro link.*/
            //multiplica o valor de pessoas que entrou no cite e multiplica por 4
            //Leo a qunantidade de pessoas que entraram no cite
            int x = int.Parse(Console.ReadLine());
            //calculo do exercicio
            x *= 4;
            //Mostra o resultado
            Console.WriteLine(x);
        }
    }
}
