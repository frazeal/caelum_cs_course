using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErrosLibrary;

namespace BancoLibrary
{
    public class ContaCorrente : Conta, ITributavel
    {

        public override string TipoConta
        {
            get
            {
                return "Conta Corrente";
            }
        }
        
        //public override bool Sacar(double valor)
        //{
        //    if (this.Saldo >= valor)
        //    {
        //        this.Saldo -= valor;
        //        return true;
        //    }
        //    return false;
        //}
        public override void Sacar(double valor)
        {
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;
            }
            else
            {
                throw new SaldoInsuficienteException();
                //throw new Exception("O valor do saque excede o valor do saldo disponível.");             
            }
        }

        public override void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public double CalculaTributos()
        {
            return this.Saldo * 0.05;
        }
    }
}
