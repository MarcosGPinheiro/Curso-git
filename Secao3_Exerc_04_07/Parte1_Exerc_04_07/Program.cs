using System;

namespace Parte1_Exerc_04_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i.ToString() + " " + (i * i).ToString() + " " + (i * i * i).ToString());
            }

        }
    }
}
