using System;

namespace Parte1_Exerc_02_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Entrada;
            int HoraInicio, HoraFim, QtdHoras;
            Entrada = Console.ReadLine().Split(" ");
            HoraInicio = int.Parse(Entrada[0]);
            HoraFim = int.Parse(Entrada[1]);
            if (HoraInicio > HoraFim)
            {
                QtdHoras = 24 - HoraInicio + HoraFim;
            }
            else if (HoraInicio<HoraFim)
            {
                QtdHoras = HoraFim - HoraInicio;
            }
            else
            {
                QtdHoras = 24;
            }
            Console.WriteLine($"O JOGO DUROU {QtdHoras} HORAS" );
        }
    }
}
