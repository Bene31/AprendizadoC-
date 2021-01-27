using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.model
{
    class Moto : Veiculo
    {
        public int rodas = 2;

        public override void Mover()
        {
            Console.WriteLine("Mover da moto");
            base.Mover();

        }
    }
}
