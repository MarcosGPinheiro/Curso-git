using System;

namespace Parte1_Exerc_02_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Entrada;
            string Saida;
            int A, B;
            Entrada = Console.ReadLine().Split(" ");
            A = int.Parse(Entrada[0]);
            B = int.Parse(Entrada[1]);
            if (A % B == 0 || B % A == 0)
            {
                Saida = "São Multiplos";
            }
            else
            {
                Saida = "Não são Muitiplos";
            }
            Console.WriteLine(Saida);
        }
    }
}
