using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Pessoa pessoa = new Pessoa();
            pessoa.nome = "Arthur";
            pessoa.sexo = "M";
            pessoa.dataNasc = new DateTime(1995, 7, 20);
            pessoa.SetPosicao(20.5, 10.5);

            Console.WriteLine(pessoa.ResumoPessoa());
            Console.WriteLine("Posição: " + pessoa.PegarPosicao());*/

            Pessoa pessoa = new Pessoa("Arthur", "M", DateTime.Now, 20.0, 10.3);

            Console.WriteLine(pessoa.nome);
            Console.ReadKey();
        }
    }
}
