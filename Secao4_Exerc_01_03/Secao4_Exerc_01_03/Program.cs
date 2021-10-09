using System;

namespace Secao4_Exerc_01_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            Console.WriteLine("Nome do aluno: ");
            a.Nome= Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            a.Nota1 = double.Parse(Console.ReadLine());
            a.Nota2 = double.Parse(Console.ReadLine());
            a.Nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine($"NOTA FINAL {a.NotaFinal():F2}");
            Console.WriteLine(a.Situacao());
        }
    }
}
