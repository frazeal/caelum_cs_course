using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLibrary
{
    public class Conta
    {

        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        public Conta()
        {

        }

        public Conta(double saldoInicial)
        {
            Saldo = saldoInicial;
        }

        public virtual bool Sacar(double valor)
        {
            
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;
                return true;
            }
            return false;
        }

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
