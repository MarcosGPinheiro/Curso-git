using System;

namespace Secao4_ExercFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            double CotDolar;
            double VolumeDolar;
            double ValorReais;
            Console.Write("Qual é a cotação do dólar?");
            CotDolar=double.Parse( Console.ReadLine());
            Console.Write("Quantos dólares você vai comprar?");
            VolumeDolar = double.Parse(Console.ReadLine());
            ValorReais = ConversorDeMoeda.ConverteDolar(CotDolar, VolumeDolar);
            Console.Write($"Valor a ser pago em reais = {ValorReais:C2}");
        }
    }
}
