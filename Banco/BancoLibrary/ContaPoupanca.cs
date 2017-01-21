using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErrosLibrary;

namespace BancoLibrary
{
    public class ContaPoupanca: Conta
    {
        public ContaPoupanca() : base()
        {
                
        }

        //public ContaPoupanca(double saldoInicial) : base(saldoInicial)
        //{

        //}

        public override string TipoConta 
        { 
            get
            {
                return "Conta Poupança";
            }
        }

        //public override void Sacar(double valor)
        //{
        //     if (this.Saldo >= valor)
        //    {
        //        this.Saldo -= (valor + 1);
        //        return true;
        //    }
        //    return false;
        //}

        public override void Sacar(double valor)
        {
            if ((valor + 0.1) > this.Saldo) 
            {
                //throw new Exception("O valor do saque excede o valor do saldo disponível.");
                throw new SaldoInsuficienteException();
            }
            else
            {
                this.Saldo -= (valor + 0.1);
            }
        }

        public override void Depositar(double valor)
        {
            if (valor < 0.0)
            {
                throw new ArgumentException();
            }
            else
            {
                this.Saldo += valor;
            }
        }

    }
}
