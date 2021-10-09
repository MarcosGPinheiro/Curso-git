using System;

namespace Secao6_ExercFixacao_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Quarto[] Pensao = new Quarto[10];
            string nome;
            string email;
            int quarto;

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Aluguel #{i + 1}:");
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Email: ");
                email = Console.ReadLine();
                Console.Write("Quarto: ");
                quarto = int.Parse(Console.ReadLine());
                Pensao[quarto] = new Quarto(nome, email);
            }
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
                if (Pensao[i] != null)
                {
                    Console.WriteLine($"{i}: {Pensao[i].Nome}, {Pensao[1].Email}");
                    Console.WriteLine($"{i}: {Pensao[i]}");
                }
            {

            }
        }
    }
}
