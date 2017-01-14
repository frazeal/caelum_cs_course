using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLibrary
{
    public abstract class Conta
    {

        public int Numero { get; set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }
        public abstract string TipoConta { get; protected set; }

        protected Conta()
        {

        }

        protected Conta(double saldoInicial)
        {
            Saldo = saldoInicial;
        }

        public abstract bool Sacar(double valor);

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public void Transferir(double valor, Conta contaDestino)
        {
            if (this.Sacar(valor) == true)
            {
                contaDestino.Depositar(valor);
            }
        }

    }
}
