using System;

namespace Parte1_Exerc_04_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int In = 0;
            int Out = 0;
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                    In++;
                else
                    Out++;
            }
            Console.WriteLine($"{In} in");
            Console.WriteLine($"{Out} out");

        }
    }
}
