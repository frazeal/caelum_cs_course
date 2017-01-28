using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLibrary
{
    public static class FactoryConta
    {
        private static List<Conta> tipoContas = new List<Conta>();
        static FactoryConta()
        {
            tipoContas.Add(new ContaCorrente());
            tipoContas.Add(new ContaPoupanca());
        }
        public static Conta CriarConta(int tipoConta)
        {
            return tipoContas[tipoConta];
        }
    }
}
