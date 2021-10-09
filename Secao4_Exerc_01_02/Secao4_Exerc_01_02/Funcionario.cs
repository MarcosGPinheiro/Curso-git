using System;
using System.Collections.Generic;
using System.Text;

namespace Secao4_Exerc_01_02
{
    class Funcionario
    {

        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido()
        {
            return Salario - Imposto;
        }

        public void AumentarSalario(double percent)
        {
            Salario = Salario * (1 + percent / 100);
        }

        public override string ToString()
        {
            return $"{Nome}, {SalarioLiquido():C2}";
        }
    }
}
