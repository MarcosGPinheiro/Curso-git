using System;

namespace Parte1_Exerc_01_05
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] Entrada;
            int CodigoPeca1, QtdPeca1, CodigoPeca2, QtdPeca2;
            float ValorPeca1, ValorPeca2, ValorTotal;
            Console.Write("Entrar com codigo, quantidade e valor unitario da peca 1: ");
            Entrada =  Console.ReadLine().Split(' ');
            CodigoPeca1 = int.Parse(Entrada[0]);
            QtdPeca1 = int.Parse(Entrada[1]);
            ValorPeca1 = float.Parse(Entrada[2]);
            Console.Write("Entrar com codigo, quantidade e valor unitario da paca 2: ");
            Entrada = Console.ReadLine().Split(' ');
            CodigoPeca2 = int.Parse(Entrada[0]);
            QtdPeca2 = int.Parse(Entrada[1]);
            ValorPeca2 = float.Parse(Entrada[2]);
            ValorTotal = (QtdPeca1 * ValorPeca1) + (QtdPeca2 * ValorPeca2);

            Console.WriteLine($"Valor a pagar: {ValorTotal:C2}");
        }
    }
}
