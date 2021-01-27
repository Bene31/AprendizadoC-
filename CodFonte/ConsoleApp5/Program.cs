using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um nuero: ");

            try
            {
                int num = int.Parse(Console.ReadLine());
                int n = int.Parse(null);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Nao foi localizado numero");
            }
            catch (Exception e)
            {
                Console.WriteLine("Tratado");
            }
            finally
            {
                Console.WriteLine("Finally");
            }
            
            Console.ReadKey();
        }
    }
}
