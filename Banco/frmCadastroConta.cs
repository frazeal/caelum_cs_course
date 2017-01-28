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

        // Colecoes
        private ICollection<string> devedores;

        private frmPrincipal formularioConta;

        public frmCadastroConta(frmPrincipal formulario)
        {
            this.formularioConta = formulario;
            InitializeComponent();

            // Colecoes
            this.devedores = BuscaLibrary.GeradorDevedores.GeraListaT();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            bool ehDevedor = false;
            for (int i = 0; i < 300000; i++ )
            {
                ehDevedor = this.devedores.Contains(txtNomeTitular.Text);
            }
                if (!ehDevedor)
                {
                    Conta novaConta = FactoryConta.CriarConta(cmbTipoConta.SelectedIndex);
                    novaConta.Titular = new Cliente(txtNomeTitular.Text);
                    novaConta.Numero = Convert.ToInt32(txtNumero.Text);

                    this.formularioConta.AdicionaConta(novaConta);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Devedor!");
                }
        }

        private void frmCadastroConta_Load(object sender, EventArgs e)
        {
            //txtNumero.Text = (this.formularioConta.RetornaNumeroContas() + 1).ToString();
            txtNumero.Text = Convert.ToString(Conta.ProximaConta());
        }

    }
}
