using System;

namespace Secao4_List1_02
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario F1 = new Funcionario();
            Funcionario F2 = new Funcionario();

            Console.Write("Nome funcionario :");
            F1.Nome = Console.ReadLine();
            Console.Write("Salario funcionario :");
            F1.Salario = double.Parse(Console.ReadLine());
            
            Console.Write("Nome funcionario :");
            F2.Nome = Console.ReadLine();
            Console.Write("Salario funcionario :");
            F2.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Salário Médio = " + ((F1.Salario+F2.Salario)/2).ToString("C2"));
        }
    }
}
