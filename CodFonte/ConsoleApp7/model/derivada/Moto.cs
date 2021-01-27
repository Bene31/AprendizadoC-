using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.model.derivada
{
    class Moto : Veiculo
    {
        public virtual void Mover()
        {
            Console.WriteLine("Moto movendo");
        }
    }
}
