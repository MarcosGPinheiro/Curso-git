using System;

namespace Parte1_Exerc_02_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Entrada;
            int Codigo, Qtd;
            double Saida = 0;
            Entrada = Console.ReadLine().Split(" ");
            Codigo = int.Parse(Entrada[0]);
            Qtd = int.Parse(Entrada[1]);
            if (Codigo == 1) { Saida = 4.00 * Qtd; }
            else if (Codigo == 2) { Saida = 4.5 * Qtd; }
            else if (Codigo == 3) { Saida = 5.00 * Qtd; }
            else if (Codigo == 4) { Saida = 2.00 * Qtd; }
            else if (Codigo == 5) { Saida = 1.50 * Qtd; }
            Console.WriteLine($"Total: {Saida:C2}");
        }
    }
}
