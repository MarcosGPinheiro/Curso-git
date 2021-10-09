using System;

namespace Parte1_Exerc_02_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string Saida;
            double Entrada;
            Entrada = double.Parse(Console.ReadLine());
            if (Entrada < 0 || Entrada > 100) { Saida = "Fora do intervalo"; }
            else if (Entrada <= 25) { Saida = "Intervalo (0,25)"; }
            else if (Entrada <= 50) { Saida = "Intervalo (26, 50)"; }
            else if (Entrada <= 75) { Saida = "Intervalo (51, 75)"; }
            else  { Saida = "Intervalo (76, 100)"; }
            Console.WriteLine(Saida);
        }
    }
}
