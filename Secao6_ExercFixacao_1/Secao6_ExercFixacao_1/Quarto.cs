using System;
using System.Collections.Generic;
using System.Text;

namespace Secao6_ExercFixacao_1
{
    class Quarto
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Quarto(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
