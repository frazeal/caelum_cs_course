using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoLibrary;

namespace Banco
{
    public partial class frmPrincipal : Form
    {
        private Conta[] contas;
        private int indice = 0;
        private int indiceTransferencia = 0;
        private int numeroContas;
        private Conta contaSelecionada;

        public int RetornaNumeroContas()
        {
            return numeroContas;
        }

        public frmPrincipal()
        {    
            InitializeComponent();
        }

        public void AdicionaConta(Conta c)
        {
            contas[numeroContas] = c;
            numeroContas++;
            cmbContas.Items.Add("Titular: " + c.Titular.Nome);
            //cmbContaDestinoTransferencia.Items.Add("Titular: " + c.Titular.Nome);
        }

        public void AtualizaDadosTela()
        {
            txtTitular.Text = contaSelecionada.Titular.Nome;
            txtNumero.Text = Convert.ToString(contaSelecionada.Numero);
            txtSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
            txtTipoConta.Text = contaSelecionada.TipoConta;
            txtValor.Text = "";
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            contaSelecionada.Depositar(Convert.ToDouble(txtValor.Text));
            MessageBox.Show("Operação realizada com sucesso!");
            AtualizaDadosTela();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            contas = new Conta[20];
            contaSelecionada = contas[cmbContas.SelectedIndex];
            Conta c1 = new ContaCorrente();
            c1.Titular = new Cliente("victor");
            c1.Numero = 1;
            this.AdicionaConta(c1);

            Conta c2 = new ContaPoupanca();
            c2.Titular = new Cliente("mauricio");
            c2.Numero = 2;
            this.AdicionaConta(c2);

            Conta c3 = new ContaCorrente();
            c3.Titular = new Cliente("osni");
            c3.Numero = 3;
            this.AdicionaConta(c3);

            Conta c4 = new ContaCorrente();
            c4.Titular = new Cliente("Francisco");
            c4.Numero = 4;
            this.AdicionaConta(c4);

        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            bool statusSaque;
            statusSaque = contaSelecionada.Sacar(Convert.ToDouble(txtValor.Text));
            if (statusSaque == true)
            {
                MessageBox.Show("Operação realizada com sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possível realizar esta operação.");
            }
            AtualizaDadosTela();
        }

        private void cmbContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice = cmbContas.SelectedIndex;
            contaSelecionada = this.contas[indice];
            CarregaComboContasDestino();
            AtualizaDadosTela();
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            contaSelecionada.Transferir(Convert.ToDouble(txtValor.Text), contas[indiceTransferencia]);
            MessageBox.Show("Operação realizada com sucesso!");
            AtualizaDadosTela();
        }

        private void cmbContaDestinoTransferencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceTransferencia = this.cmbContaDestinoTransferencia.SelectedIndex;
        }

        private void btnNovaConta_Click(object sender, EventArgs e)
        {
            frmCadastroConta formularioCadastro = new frmCadastroConta(this);
            formularioCadastro.ShowDialog();
        }

        public void CarregaComboContasDestino()
        {
            foreach (Conta conta in contas)
            {
                if (conta == null)
                {
                    break;
                }
                else
                {
                    if (conta.Numero != contaSelecionada.Numero)
                    {
                        cmbContaDestinoTransferencia.Items.Add("Titular: " + conta.Titular.Nome);
                    }
                }
            }
        }
    }
}
