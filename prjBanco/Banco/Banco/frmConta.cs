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
    public partial class frmConta : Form
    {
        //private Conta conta;
        private Conta[] contas;
        private int indice = 0;
        private int indiceTransferencia = 0;
        public frmConta()
        {    
            InitializeComponent();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            contas[indice].Depositar(Convert.ToDouble(txtValor.Text));
            txtSaldo.Text = contas[indice].Saldo.ToString();
            MessageBox.Show("Operação realizada com sucesso!");
        }

        private void frmConta_Load(object sender, EventArgs e)
        {

            contas = new Conta[4];

              this.contas[0] = new Conta();
              this.contas[0].Titular = new Cliente("victor");
              this.contas[0].Numero = 1;

              this.contas[1] = new ContaPoupanca();
              this.contas[1].Titular = new Cliente("mauricio");
              this.contas[1].Numero = 2;

              this.contas[2] = new ContaCorrente();
              this.contas[2].Titular = new Cliente("osni");
              this.contas[2].Numero = 3;

              this.contas[3] = new ContaCorrente();
              this.contas[3].Titular = new Cliente("Francisco");
              this.contas[3].Numero = 4;

              foreach (Conta conta in contas)
              {
                  cmbContas.Items.Add(conta.Titular.Nome);
                  cmbContaDestinoTransferencia.Items.Add(conta.Titular.Nome);
              }

        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            bool statusSaque;
            statusSaque = contas[indice].Sacar(Convert.ToDouble(txtValor.Text));
            txtSaldo.Text = Convert.ToString(contas[indice].Saldo);
            if (statusSaque == true)
            {
                MessageBox.Show("Operação realizada com sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possível realizar esta operação.");
            }
        }

        private void cmbContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cmbContas.SelectedIndex;
            Conta contaSelecionada = this.contas[indice];
            txtTitular.Text = contaSelecionada.Titular.Nome;
            txtNumero.Text = Convert.ToString(contaSelecionada.Numero);
            txtSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            this.contas[indice].Transferir(Convert.ToDouble(txtValor.Text), contas[indiceTransferencia]);
            MessageBox.Show("Operação realizada com sucesso!");
        }

        private void cmbContaDestinoTransferencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceTransferencia = this.cmbContaDestinoTransferencia.SelectedIndex;
        }

    }
}
