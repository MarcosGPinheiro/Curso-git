using System;

namespace Parte1_Exerc_04_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Informa um numero entre 1 e 1000: ");
            x = int.Parse(Console.ReadLine());
            while (x < 1 || x > 1000)
            {
                Console.WriteLine("Valor invalido");
                Console.Write("Informa um numero entre 1 e 1000: ");
                x = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= x; i+=2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
