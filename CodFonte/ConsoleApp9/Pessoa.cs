using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Pessoa
    {
        public string nome;
        public string sexo;
        public DateTime dataNasc;
        public double posicaoX, posicaoY;

        public string ResumoPessoa()
        {
            string resumo = "Nome: " + nome;
            resumo += "\nSexo: " + sexo;
            resumo += "\nData de nascimento: " + dataNasc;

            return resumo;
        }

        public Pessoa(string Nome, string Sexo, DateTime DataNasc, double X, Double Y)
        {
            nome = Nome;
            sexo = Sexo;
            dataNasc = DataNasc;
            posicaoX = X;
            posicaoY = Y;
        }

        public string PegarPosicao()
        {
            return posicaoX + ", " + posicaoY;
        }

        public void SetPosicao(double X, double Y)
        {
            posicaoX = X;
            posicaoY = Y;
        }

    }
}
