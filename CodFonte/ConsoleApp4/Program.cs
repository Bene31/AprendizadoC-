using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Listas
            List<string> marcas = new List<string>();

            marcas.Add("Fiat");
            marcas.Add("Chevrolet");
            marcas.Add("Peugeot");

            foreach(string marca in marcas)
            {
                Console.WriteLine(marca);
            }

            // Dicionario
            Dictionary<string, int> dicionario = new Dictionary<string, int>();
            dicionario.Add("T1", 128);
            dicionario.Add("T2", 256);

            Console.WriteLine(dicionario["T1"]);

            Console.ReadKey();
        }
    }
}
