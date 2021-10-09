using System;

namespace Parte1_Exerc_02_08
{
    class Program
    {
        static void Main(string[] args)
        {
            double Salario, Imposto;
            string Saida;
            Console.Write("Informa o Salario: ");
            Salario = double.Parse(Console.ReadLine());
            if (Salario <= 2000.00) Imposto = 0;
            else if (Salario <= 3000.00)
                Imposto = (Salario - 2000.00) * 0.08;
            else if (Salario <= 4500.00)
                Imposto = (1000.00 * 0.08) + (Salario - 3000.00) * 0.18;
            else
                Imposto = (1000.00 * 0.08) + (1500.00 * 0.18) + (Salario - 4500.00) * 0.28;
            if (Imposto == 0) Saida = "Isento";
            else Saida = Imposto.ToString("C2");
            Console.WriteLine(Saida);
        }
    }
}
