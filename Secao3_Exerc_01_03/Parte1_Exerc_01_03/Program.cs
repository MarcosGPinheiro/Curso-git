using System;

namespace Parte1_Exerc_01_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, Diferenca;
            Console.Write("Informe o valor inteiro de A: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor inteiro de B: ");
            B = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor inteiro de C: ");
            C = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor inteiro de D: ");
            D = int.Parse(Console.ReadLine());

            Diferenca = (A * B - C * D);
            Console.WriteLine($"Diferenca entre os produto {A} x {B} e {C} x {D} = " + Diferenca);
        }
    }
}
