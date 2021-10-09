using System;

namespace Parte1_Exerc_03_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int Senha;
            Console.Write("Digite a senha: ");
            Senha = int.Parse(Console.ReadLine());
            while (Senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                Console.Write("Digite novamente a senha: ");
                Senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");

        }
    }
}
