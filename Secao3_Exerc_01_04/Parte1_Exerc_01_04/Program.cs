using System;

namespace Parte1_Exerc_01_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int Registro;
            float HorasTrabalhadas;
            float ValorHora;
            float Salario;
            Console.Write("Informe o número do funcionario: ");
            Registro=int.Parse( Console.ReadLine());
            Console.Write("Informe a quantidade de horas trabalhadas: ");
            HorasTrabalhadas = float.Parse(Console.ReadLine());
            Console.Write("Informe o valor por hora recebido: ");
            ValorHora = float.Parse(Console.ReadLine());
            Salario = ValorHora * HorasTrabalhadas;
            Console.WriteLine("Funcionario registro :" + Registro);
            Console.WriteLine($"Recebe um salario de {Salario:C2}");
        }
    }
}
