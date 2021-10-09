using System;

namespace Secao4_Exerc_01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("entre a largura e altura do retângulo:");
            r.Largura = double.Parse(Console.ReadLine());
            r.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine(r);

        }
    }
}
