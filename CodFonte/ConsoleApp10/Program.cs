using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculoJuros calc = new CalculoJuros();
            double resultado = calc.Soma(10, 20);

            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
