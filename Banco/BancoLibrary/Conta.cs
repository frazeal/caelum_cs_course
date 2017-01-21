using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLibrary
{
    public abstract class Conta
    {
        private static int numeroDeContas;

        public int Numero { get; set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }
        public abstract string TipoConta { get; }

        protected Conta()
        {
            Conta.numeroDeContas++;
            this.Numero = Conta.numeroDeContas;
        }

        public static int ProximaConta()
        {
            return Conta.numeroDeContas + 1;
        }

        //protected Conta(double saldoInicial)
        //{
        //    Saldo = saldoInicial;
        //}

        //public abstract bool Sacar(double valor);
        public abstract void Sacar(double valor);

        public abstract void Depositar(double valor);
       

        //public void Transferir(double valor, Conta contaDestino)
        //{
        //    if ((this.Sacar(valor) == true) && (contaDestino != null))
        //    {
        //        contaDestino.Depositar(valor);
        //    }
        //}
        public void Transferir(double valor, Conta contaDestino)
        {
            if (contaDestino != null)
            {
                this.Sacar(valor);
                contaDestino.Depositar(valor);
            }
            else
            {
                throw new ArgumentException("É preciso selecionar uma conta de destino para realizar a transferência.");
            }
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Conta))
            {
                return false;
            }

            Conta c = (Conta)obj;
            return (this.Numero == c.Numero);
        }

        public override string ToString()
        {
            return "Titular: " + this.Titular.Nome;
        }

    }
}
