using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual estado civil? (S - solteiro, C - casado, V - viuvo, D - divorciado) ");
            string valor = Console.ReadLine();
            switch (valor)
            {
                case "S":
                    Console.WriteLine("Solteiro");
                    break;
                case "C":
                    Console.WriteLine("Casado");
                    break;
                case "V":
                    Console.WriteLine("Viuvo");
                    break;
                case "D":
                    Console.WriteLine("Divorciado");
                    break;
            }

            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("Valor da variavel: " + i);
                i += 1;
            }

            bool repetir = false;
            do
            {
                Console.WriteLine("Entrou no fluxo 'do-while'");
            } while (repetir);
            Console.WriteLine("Saiu do fluxo");

            for(int y=0; y <= 10; y++)
            {
                Console.WriteLine("N linha: " + y);
            }

            string[] nomes = { "Arthur", "Breno", "Carlos" };
            for(int h = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("nomes: " + nomes[h]);
            }

            foreach (string nome in nomes)
            {
                Console.WriteLine("nomes: " + nome);
            }
            
            Console.ReadKey();

        }
    }
}
