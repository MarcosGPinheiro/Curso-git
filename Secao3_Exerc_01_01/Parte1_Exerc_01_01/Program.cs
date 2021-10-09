using System;

namespace Parte1_Exerc_01._01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o primeiro numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Informe o segundo numero: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"A soma de {n1} com {n2} é = " + (n1+n2));
        }
    }
}
