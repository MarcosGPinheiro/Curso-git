using System;
using System.Collections.Generic;
using System.Text;

namespace Secao6_ExercFixacao_2
{
    class Funcionario
    {
        public int IdFunc { get; private set; }
        public string NomeFunc { get; set; }
        public double SalarioFunc { get; private set; }

        public Funcionario(int idFunc, string nomeFunc, double salarioFunc)
        {
            IdFunc = idFunc;
            NomeFunc = nomeFunc;
            SalarioFunc = salarioFunc;
        }

        public void IncreaseSalary(double pert)
        {
            SalarioFunc *= (1 + pert / 100);
        }

        public override string ToString()
        {
            return $"{IdFunc}, {NomeFunc}, {SalarioFunc:C2}";
        }
    }
}
