using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro();
            Carro carro2 = new Carro();

            Console.WriteLine("Marca: " + carro1.marca);
            carro1.marca = "Ford";
            Console.WriteLine("Marca: " + carro1.marca);

            Console.WriteLine("Luzes: " + carro1.luzes);
            carro1.abrirPorta();
            Console.WriteLine("Luzes: " + carro1.luzes);

            Console.WriteLine("\n0:Desligado\n1:Baixo\n2:Médio\n3+:Alto\n");
            Console.Write("Digite valor do farol: ");
            int val = int.Parse(Console.ReadLine());
            carro1.valor = val;
            string statusFarol = carro1.acenderFarol(carro1.valor);

            Console.WriteLine("Farol: " + statusFarol);

            Console.ReadKey();
        }
    }
}
