using System;

namespace Parte1_Exerc_03_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Entrada;
            int x, y;

            Entrada = Console.ReadLine().Split(" ");
            x = int.Parse(Entrada[0]);
            y = int.Parse(Entrada[1]);

            while (x!=0 && y != 0)
            {
                if (x>0 && y>0)
                    Console.WriteLine("Primeiro");
                else if (x>0 && y<0)
                    Console.WriteLine("Quarto");
                else if (y>0)
                    Console.WriteLine("Segundo");
                else
                    Console.WriteLine("Terceiro");
                Entrada = Console.ReadLine().Split(" ");
                x = int.Parse(Entrada[0]);
                y = int.Parse(Entrada[1]);
            }
        }
    }
}
