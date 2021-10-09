using System;

namespace Secao4_Exerc_01_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Sálario Bruto: ");
            f.Salario = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Funcionário: " + f);
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            f.AumentarSalario(double.Parse(Console.ReadLine()));
            Console.WriteLine();
            Console.WriteLine("Dados atualizados:" + f);
        }
    }
}
