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
using ErrosLibrary;
using System.Collections;

namespace Banco
{
    public partial class frmPrincipal : Form
    {
        //private Conta[] contas;
        //private ArrayList contas = new ArrayList();
        private List<Conta> contas = new List<Conta>();
        //private int indice = 0;
        private int indiceTransferencia = 0;
        //private int numeroContas;  //>>> Implementada a variável estática na classe base
        private Conta contaSelecionada;

        // Não é mais necessário, pois foi criado o método estático na classe base
        //public int RetornaNumeroContas()
        //{
        //    return numeroContas;
        //}

        public frmPrincipal()
        {    
            InitializeComponent();
        }

        public void AdicionaConta(Conta c)
        {
            contas.Add(c); // contas agora é um ArrayList
            //contas[numeroContas] = c;
            //numeroContas++;
            //cmbContas.Items.Add("Titular: " + c.Titular.Nome);
            cmbContas.Items.Add(c); 
            // o combo box implicitamente chama c.ToString()
            // que foi sobrescrito na classe Conta para return "Titular: " + this.Titular.Nome;
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
            try
            {
                contaSelecionada.Depositar(Convert.ToDouble(txtValor.Text));
                AtualizaDadosTela();
                MessageBox.Show("Operação realizada com sucesso!");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Argumento inválido.");
            }
            
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            cmbContas.DisplayMember = "Titular";
            cmbContaDestinoTransferencia.DisplayMember = "Titular";
            //contas = new Conta[20];  //>> o array de Conta foi transformado num ArrayList
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
            //bool statusSaque;
            //statusSaque = contaSelecionada.Sacar(Convert.ToDouble(txtValor.Text));
            //AtualizaDadosTela();
            //if (statusSaque == true)
            //{
            //    MessageBox.Show("Operação realizada com sucesso!");
            //}
            //else
            //{
            //    MessageBox.Show("Não foi possível realizar esta operação.");
            //} 
            try
            {
                contaSelecionada.Sacar(Convert.ToDouble(txtValor.Text));
                AtualizaDadosTela();
                MessageBox.Show("Operação realizada com sucesso!");
            }
            catch (SaldoInsuficienteException)
            {
                MessageBox.Show("Saldo insuficiente para realizar esta operação");
            }

        }

        private void cmbContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //indice = cmbContas.SelectedIndex;
            //contaSelecionada = (Conta) this.contas[indice];
            contaSelecionada = (Conta)cmbContas.SelectedItem;
            CarregaComboContasDestino();
            AtualizaDadosTela();
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            //contaSelecionada.Transferir(Convert.ToDouble(txtValor.Text), contas[indiceTransferencia]); //>> Array
            try
            {
                //contaSelecionada.Transferir(Convert.ToDouble(txtValor.Text), (Conta)contas[indiceTransferencia]); //>>> ArrayList, tem que forçar o cast
                contaSelecionada.Transferir(Convert.ToDouble(txtValor.Text), contas[indiceTransferencia]);
                MessageBox.Show("Operação realizada com sucesso!");
                AtualizaDadosTela();
            }
            catch (SaldoInsuficienteException)
            {
                MessageBox.Show("Saldo insuficiente para realizar esta operação");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("É preciso selecionar uma conta de destino para realizar a transferência.");
            }
            
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
            // Garante que o combo está vazio antes de adicionar as contas
            cmbContaDestinoTransferencia.Items.Clear();

            // Começa a adicionar contas no combo
            foreach (Conta conta in contas)
            {
                if (conta == null)
                {
                    break;
                }
                else
                {
                    //if (conta.Numero != contaSelecionada.Numero)
                    //{
                    //    cmbContaDestinoTransferencia.Items.Add("Titular: " + conta.Titular.Nome);
                    //}
                    if (!conta.Equals(contaSelecionada))
                    {
                        cmbContaDestinoTransferencia.Items.Add(conta);
                    }
                }
            }
        }

        private void btnCalculaImpostos_Click(object sender, EventArgs e)
        {
            TotalizadorDeTributos totalTributos = new TotalizadorDeTributos();

            foreach (ITributavel conta in contas)
            {
                if (conta is ITributavel)
                {
                    totalTributos.Adiciona((ITributavel) conta);
                }
            }

            MessageBox.Show("Total de tributos = " + totalTributos.Total.ToString());
        }
    }
}
