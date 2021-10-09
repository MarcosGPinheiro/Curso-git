using System;
using System.Collections.Generic;
using System.Text;

namespace Secao4_Exerc_01_03
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
            return (Nota1 + Nota2 + Nota3);
        }

        public string Situacao()
        {
            string status = "APROVADO";
            if (NotaFinal() < 60)
            {
                status = $"REPROVADO FALTAM {60 - NotaFinal()} PONTOS";
            }
            return status;
        }
    }
}
