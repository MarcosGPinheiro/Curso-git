using System;

namespace Parte1_Exerc_01_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informar o raio do circulo: ");
            double raio = double.Parse(Console.ReadLine());

            Console.WriteLine($"A área do circulo de {raio} é igual a: " + (3.14159 * raio * raio).ToString("F4"));
        }
    }
}
