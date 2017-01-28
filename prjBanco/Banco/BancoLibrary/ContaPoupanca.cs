using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLibrary
{
    public class ContaPoupanca: Conta
    {
        public ContaPoupanca() : base()
        {
                
        }

        public ContaPoupanca(double saldoInicial) : base(saldoInicial)
        {

        }

        public override string TipoConta 
        { 
            get
            {
                return "Conta Poupança";
            }
            protected set
            {
                TipoConta = value;
            }
        }

        public override bool Sacar(double valor)
        {
             if (this.Saldo >= valor)
            {
                this.Saldo -= (valor + 1);
                return true;
            }
            return false;
        }
    }
}
