using System;

namespace Parte1_Exerc_02_07
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Entrada;
            string Saida;
            float x, y;
            Entrada = Console.ReadLine().Split(" ");
            x = float.Parse(Entrada[0]);
            y = float.Parse(Entrada[1]);
            if (x == 0 && y == 0) Saida = "Origem";
            else if (x == 0) Saida = "Eixo X";
            else if (y == 0) Saida = "Eixo Y";
            else if (x > 0)
                if (y > 0) Saida = "Q1";
                else Saida = "Q4";
            else if (y > 0) Saida = "Q2";
            else Saida = "Q3";
            Console.WriteLine(Saida);
        }
    }
}
