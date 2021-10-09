using System;

namespace Secao6_ExercFixacao_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, findNumeber;
            string[] entrada;
            Console.Write("Informa o numero de linhas da matriz: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Informa o numero de colunas da matriz: ");
            n = int.Parse(Console.ReadLine());
            int[,] mat = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                entrada = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                    mat[i, j] = int.Parse(entrada[j]);
            }
            findNumeber = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == findNumeber)
                    {
                        Console.WriteLine($"Position {i},{j}");
                        if (j > 0)
                            Console.WriteLine($"Left: {mat[i, j - 1]}");
                        if (i>0)
                            Console.WriteLine($"Up: {mat[i-1,j]}");
                        if (j < n - 1)
                            Console.WriteLine($"Right: {mat[i, j + 1]}");
                        if (i < m - 1)
                            Console.WriteLine($"Down: {mat[i+1, j ]}");
                    }
                }
        }
    }
}
