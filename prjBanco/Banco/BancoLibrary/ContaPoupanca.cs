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

        public override bool Sacar(double valor)
        {
            return base.Sacar(valor + 0.10);
        }
    }
}
