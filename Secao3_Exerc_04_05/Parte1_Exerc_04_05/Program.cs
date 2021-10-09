using System;

namespace Parte1_Exerc_04_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int fatorial = 1;
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                fatorial *=  i;
            }
            Console.WriteLine(fatorial);
        }
    }
}
