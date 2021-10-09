using System;

namespace Parte1_Exerc_04_04
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] entrada;
            double A, B;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                entrada = Console.ReadLine().Split(" ");
                A = double.Parse(entrada[0]);
                B = double.Parse(entrada[1]);
                if (B==0)
                    Console.WriteLine("Divisão impossível");
                else
                    Console.WriteLine((A/B).ToString("F1"));
            }
        }
    }
}
