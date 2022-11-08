using System;
using System.Globalization;

namespace _1958
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados
            string valor1 = Console.ReadLine();//O valor começa em strig para saber se ele é "+0" "-0"
            double valor = double.Parse(valor1, CultureInfo.InvariantCulture);

            //Impreção de valores em formato de notação cientifica
            //Se for igual a 0
            if (valor == 0)
            {
                if (valor1 == "-0")
                {
                    Console.WriteLine("-0.0000E+00");
                }
                else
                {
                    Console.WriteLine("+0.0000E+00");
                }
            }

            else
            {
                //Maior que 0
                if (valor > 0)
                {
                    Console.WriteLine(
                        "+" + valor.ToString("#.0000E+00", CultureInfo.InvariantCulture)
                    );
                }
                //Menor que 0
                else
                {
                    Console.WriteLine(valor.ToString("#.#000E+00", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
