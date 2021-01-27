using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite seu ano de nascimento: ");
            int AnoNascimento = int.Parse(Console.ReadLine());

            int idade = DateTime.Now.Year - AnoNascimento;

            Console.WriteLine("Eu sou " + nome + " e tenho " + idade + " anos.");
            Console.ReadKey();
        }
    }
}
