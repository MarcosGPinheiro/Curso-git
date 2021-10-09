using System;

namespace Parte1_Exerc_01_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Entrada;
            double A, B, C;
            double AreaTriangulo, AreaCirulo, AreaTrapezio, AreaQuadrado, AreaRetangulo;
            Entrada = Console.ReadLine().Split(" ");
            A = double.Parse(Entrada[0]);
            B = double.Parse(Entrada[1]);
            C = double.Parse(Entrada[2]);
            AreaTriangulo = (A * C) / 2;
            AreaCirulo = 3.14159 * C * C;
            AreaTrapezio = (A + B) * C / 2;
            AreaQuadrado = B * B;
            AreaRetangulo = A * B;
            Console.WriteLine($"Triangulo: { AreaTriangulo:F3}");
            Console.WriteLine("Circulo: {0:F3}",AreaCirulo);
            Console.WriteLine("Trapezio: " + AreaTrapezio.ToString("F3"));
            Console.WriteLine($"Quadrado: {AreaQuadrado:F3}");
            Console.WriteLine($"Retangulo {AreaRetangulo:F3}");
        }
    }
}
