using System;

namespace Parte1_Exerc_02_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string Saida;
            int Entrada;
            Entrada = int.Parse(Console.ReadLine());
            if (Entrada < 0)
            {
                Saida = "NEGATIVO";
            }
            else
            {
                Saida = "NAO NEGATIVO";
            }

            Console.WriteLine(Saida);
        }
    }
}
