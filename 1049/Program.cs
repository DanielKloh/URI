using System;

namespace _1049
{
    class Program
    {
        static void Main(string[] args)
        {
            //MODELO QUE O CITE ACEITA:
            // string p1 = Console.ReadLine();
            // string p2 = Console.ReadLine();
            // string p3 = Console.ReadLine();

            // if (p1 == "vertebrado")
            // {
            //     if (p2 == "ave")
            //     {
            //         if (p3 == "carnivoro")
            //         {
            //             Console.WriteLine("aguia");
            //         }
            //         else
            //         {
            //             Console.WriteLine("pomba");
            //         }
            //     }
            //     else if (p2 == "mamifero")
            //     {
            //         if (p3 == "onivoro")
            //         {
            //             Console.WriteLine("homem");
            //         }
            //         else
            //         {
            //             Console.WriteLine("vaca");
            //         }
            //     }
            // }
            // if (p1 == "invertebrado")
            // {
            //     if (p2 == "inseto")
            //     {
            //         if (p3 == "herbivoro")
            //         {
            //             Console.WriteLine("lagarta");
            //         }

            //         else
            //         {
            //             Console.WriteLine("pulga");
            //         }
            //     }
            //     else if (p2 == "anelideo")
            //     {
            //         if (p3 == "hematofago")
            //         {
            //             Console.WriteLine("sanguessuga");
            //         }
            //         else
            //         {
            //             Console.WriteLine("minhoca");
            //         }
            //     }
            // }




            //MODELO QUE O CITE NÃO ACEITA    (elses)
            string p1 = Console.ReadLine();
            string p2 = Console.ReadLine();
            string p3 = Console.ReadLine();

            if (p1 == "vertebrado")
            {
                if (p2 == "ave")
                {
                    if (p3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else if (p3 == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                }
                if (p2 == "mamifero")
                {
                    if (p3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (p3 == "herbivaro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            if (p1 == "invertebrado")
            {
                if (p2 == "inseto")
                {
                    if (p3 == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                    else if (p3 == "hemetofago")
                    {
                        Console.WriteLine("pulga");
                    }
                }
                if (p2 == "anelideo")
                {
                    if (p3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (p3 == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}
