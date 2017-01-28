using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLibrary
{
    public class SeguroDeVida : ITributavel
    {
        public double CalculaTributos()
        {
            return 42;
        }
    }
}
