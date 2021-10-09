using System;

namespace Parte1_Exerc_04_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Entrada;
            double A, B, C, Media;
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Entrada = Console.ReadLine().Split(" ");
                A = float.Parse(Entrada[0]);
                B = float.Parse(Entrada[1]);
                C = float.Parse(Entrada[2]);
                Media = ((A * 2.0) + (B * 3.0) + (C * 5.0)) / 10.0;
                Console.WriteLine(Media.ToString("F1"));
            }
        }
    }
}
