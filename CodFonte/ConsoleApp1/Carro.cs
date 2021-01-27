using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Carro
    {
        public string marca = "Fiat";
        public string modelo;
        public string cor;
        public bool luzes = false;
        public int valor = 0;

        public void abrirPorta()
        {
            luzes = true;
        }

        public void fecharPorta()
        {
            luzes = false;
        }

        public string acenderFarol(int valor)
        {
            if(valor == 0)
            {
                return "Desligado";
            }else if(valor == 1)
            {
                return "Baixo";
            }else if(valor == 2)
            {
                return "Médio";
            }
            else
            {
                return "Alto";
            }
            
        }
    }
}
