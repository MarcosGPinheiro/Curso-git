using System;

namespace Parte1_Exerc_02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string Saida = "IMPAR";
            int Entrada =  int.Parse(Console.ReadLine());
            if (Entrada%2 == 0)
            {
                Saida = "PAR";
            }
            Console.WriteLine(Saida);
        }
    }
}
