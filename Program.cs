using System;

namespace Duas_pessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da primeira da primeira pessoa: ");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.Write("Pessoa mais velha: " + p1.Nome);
            }
            else
            {
                Console.Write("Pessoa mais velha: " + p2.Nome);
            }
        }
    }
}
