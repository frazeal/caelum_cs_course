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
    public partial class frmCadastroConta : Form
    {
        private frmPrincipal formularioConta;

        public frmCadastroConta(frmPrincipal formulario)
        {
            this.formularioConta = formulario;
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            Conta novaConta = FactoryConta.CriarConta(cmbTipoConta.SelectedIndex);
            novaConta.Titular = new Cliente(txtNomeTitular.Text);
            novaConta.Numero = Convert.ToInt32(txtNumero.Text);

            this.formularioConta.AdicionaConta(novaConta);
            this.Close();
        }

        private void frmCadastroConta_Load(object sender, EventArgs e)
        {
            //txtNumero.Text = (this.formularioConta.RetornaNumeroContas() + 1).ToString();
            txtNumero.Text = Convert.ToString(Conta.ProximaConta());
        }

    }
}
