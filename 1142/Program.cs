using System;

namespace _1142
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 1;
            int n2 = 2;
            int n3 = 3;

            int n = int.Parse(Console.ReadLine());
            for(int i = 0 ;i<n;++i){
                Console.WriteLine(n1+" " + n2 +" "+ n3 + " PUM");
                n1+=4;
                n2+=4;
                n3+=4;
            }
        }
    }
}
