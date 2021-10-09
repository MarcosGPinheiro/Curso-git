using System;

namespace Parte1_Exerc_03_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int Opcao, Alcool=0, Gasolina=0, Diesel=0;
            Console.WriteLine("Qual o seu combustivel preferido?");
            Console.Write("1 - Alcool, 2 - Gasolina, 3 - Diesel ou 4 para sair");
            Opcao = int.Parse(Console.ReadLine());
            while (Opcao != 4)
            {
                if (Opcao == 1)
                    Alcool++;
                else if (Opcao == 2)
                    Gasolina++;
                else if (Opcao==3)
                    Diesel++;
                else
                    Console.WriteLine("Codigo invalido");
                Console.WriteLine("Qual o seu combustivel preferido?");
                Console.WriteLine("1 - Alcool, 2 - Gasolina, 3 - Diesel ou 4 para sair");
                Opcao = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {Alcool}");
            Console.WriteLine($"Gasolina: {Gasolina}");
            Console.WriteLine($"Diesel: {Diesel}");
        }
    }
}
