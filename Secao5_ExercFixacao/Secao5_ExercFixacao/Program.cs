using System;

namespace Secao5_ExercFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string Conta;
            string Nome;
            double VlMovimento;
            ContaBancaria CC;

            Console.Write("Entre o número da conta: ");
            Conta = Console.ReadLine();
            Console.Write("Entre o titular da conta: ");
            Nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? : ");
            if (Console.ReadLine().ToUpper() == "S")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                VlMovimento = double.Parse(Console.ReadLine());
                 CC = new ContaBancaria( Conta, Nome, VlMovimento);
            }
            else
                 CC = new ContaBancaria(Conta, Nome);

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(CC.ToString());
            Console.WriteLine();
            Console.Write("Entre um valor para depósito:");
            VlMovimento = double.Parse(Console.ReadLine());
            CC.Deposito(VlMovimento);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(CC.ToString());
            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            VlMovimento = double.Parse(Console.ReadLine());
            CC.Saque(VlMovimento);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(CC.ToString());
        }
    }
}
