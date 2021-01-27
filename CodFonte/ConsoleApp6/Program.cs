using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp6.model;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            Moto moto = new Moto();
            Veiculo vei = new Veiculo();

            carro.marca = "Fiat";
            moto.marca = "Triumph";
            vei.marca = "Airbus";

            carro.Mover();
            moto.Mover();
            vei.Mover();


            Console.ReadKey();
        }
    }
}
