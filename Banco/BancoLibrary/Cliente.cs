using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLibrary
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public int Idade { get; set; }

        public Cliente(string nome = "sem nome")
        {
            this.Nome = nome;
        }

        public bool EhMaiorDeIdade()
        {
            if (Idade >= 18)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return "Titular: " + this.Nome;
        }
    }
}
