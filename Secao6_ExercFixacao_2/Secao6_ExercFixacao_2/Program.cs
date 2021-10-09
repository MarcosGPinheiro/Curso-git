using System;
using System.Collections.Generic;

namespace Secao6_ExercFixacao_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int PosId;
            int newId;
            string newName;
            double newSalary;
            List<Funcionario> MyEmplyoees = new List<Funcionario>();
            Funcionario MyEmplyoee;
            Console.Write("How many employess will be registered? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("enplyee #" + i);
                Console.Write("Id: ");
                newId = int.Parse(Console.ReadLine());
                PosId = MyEmplyoees.FindIndex(x => x.IdFunc == newId);
                while (PosId != -1)
                {
                    Console.Write("This id exist en company, please try a new id: ");
                    newId = int.Parse(Console.ReadLine());
                    PosId = MyEmplyoees.FindIndex(x => x.IdFunc == newId);
                }
                Console.Write("Name: ");
                newName = Console.ReadLine();
                Console.Write("Salary: ");
                newSalary = double.Parse(Console.ReadLine());
                MyEmplyoee = new Funcionario(newId, newName, newSalary);
                MyEmplyoees.Add(MyEmplyoee);
            }
            Console.Write("Enter tye employee id that will have salary increase: ");
            newId = int.Parse(Console.ReadLine());
            PosId = MyEmplyoees.FindIndex(x => x.IdFunc == newId);
            if (PosId == -1)
            {
                Console.WriteLine("This id does not exist!");
            }
            else
            {
                Console.Write("Enter the percentage: ");
                double Perct = double.Parse(Console.ReadLine());
                MyEmplyoees[PosId].IncreaseSalary(Perct);
            }
            Console.WriteLine("Update list of employees:");
            foreach (var item in MyEmplyoees)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
