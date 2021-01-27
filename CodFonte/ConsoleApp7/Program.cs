using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            model.derivada.Carro carro = new model.derivada.Carro();
            MoverVeiculo(carro);

            model.derivada.Moto moto = new model.derivada.Moto();
            MoverVeiculo(moto);

            Console.ReadKey();
        }

        public static void MoverVeiculo(model.derivada.Carro carro)
        {
            carro.Mover();
        }
        public static void MoverVeiculo(model.derivada.Moto moto)
        {
            moto.Mover();
        }
        public static void MoverVeiculo(model.derivada.Onibus bus)
        {
            bus.Mover();
        }
        public static void MoverVeiculo(model.Veiculo vei)
        {
            vei.Mover();
        }
    }
}
