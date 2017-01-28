using BancoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class frmRelatorios : Form
    {
        private frmPrincipal formularioConta;
        private List<Conta> contas;

        public frmRelatorios(frmPrincipal formulario, List<Conta> _contas)
        {
            this.formularioConta = formulario;
            this.contas = _contas;
            InitializeComponent();
        }

        private void btnFiltroSaldo_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();
            var resultado = this.contas
                            .Where(c => c.Saldo < 5000)
                            .Select(n => n.Titular.Nome)
                            .OrderBy(x => x)    ////OrderByDescending(x => x)
                            .ToArray();
            lstResultado.Items.AddRange(resultado);
            
            //var resultado = this.contas.Where(c => c.Saldo < 5000);
            //foreach (var r in resultado)
            //{
            //    lstResultado.Items.Add(r.Titular);
            //}
            //lstResultado.Items.AddRange(resultado.Select(c => c.Titular).ToArray());

        }

        private void btnFiltroAntigas_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();
            var resultado = this.contas
                                       .Where(c => c.Numero < 10)
                                       .Select(t => t.Numero.ToString())
                                       .ToArray();
            lstResultado.Items.AddRange(resultado);
        }
    }
}
