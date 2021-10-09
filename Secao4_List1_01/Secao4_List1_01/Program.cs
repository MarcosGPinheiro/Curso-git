using System;

namespace Secao4_List1_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa P1 ;
            Pessoa P2;

            P1 = new Pessoa();
            P2 = new Pessoa();

            Console.WriteLine("Informe dados primeira pessoa");
            Console.Write("Nome: ");
            P1.Nome= Console.ReadLine();
            Console.Write("Idade; ");
            P1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe dados Segunda pessoa");
            Console.Write("Nome: ");
            P2.Nome = Console.ReadLine();
            Console.Write("Idade; ");
            P2.Idade = int.Parse(Console.ReadLine());


            if (P1.Idade > P2.Idade)
                Console.WriteLine($"{P1.Nome} é mais velha do que {P2.Nome}");
            else
                Console.WriteLine($"{P2.Nome} é mais velha do que {P1.Nome}");
        }
    }
}
