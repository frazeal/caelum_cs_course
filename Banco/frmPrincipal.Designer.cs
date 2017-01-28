namespace Banco
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDepositar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblTitular = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.btnSacar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.grpConta = new System.Windows.Forms.GroupBox();
            this.txtTipoConta = new System.Windows.Forms.TextBox();
            this.lblTipoConta = new System.Windows.Forms.Label();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.lblConta = new System.Windows.Forms.Label();
            this.cmbContas = new System.Windows.Forms.ComboBox();
            this.grpBancoContas = new System.Windows.Forms.GroupBox();
            this.grpTransferencia = new System.Windows.Forms.GroupBox();
            this.cmbContaDestinoTransferencia = new System.Windows.Forms.ComboBox();
            this.lblContaDestinoTransferencia = new System.Windows.Forms.Label();
            this.btnNovaConta = new System.Windows.Forms.Button();
            this.btnCalculaImpostos = new System.Windows.Forms.Button();
            this.txtBuscaTitular = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBuscarTitular = new System.Windows.Forms.Label();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.grpConta.SuspendLayout();
            this.grpBancoContas.SuspendLayout();
            this.grpTransferencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(39, 149);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(75, 23);
            this.btnDepositar.TabIndex = 4;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(116, 19);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(181, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(116, 71);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.ReadOnly = true;
            this.txtTitular.Size = new System.Drawing.Size(181, 20);
            this.txtTitular.TabIndex = 2;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(116, 97);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(181, 20);
            this.txtSaldo.TabIndex = 3;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(21, 22);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 4;
            this.lblNumero.Text = "Número:";
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(21, 74);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(39, 13);
            this.lblTitular.TabIndex = 5;
            this.lblTitular.Text = "Titular:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(21, 100);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(37, 13);
            this.lblSaldo.TabIndex = 6;
            this.lblSaldo.Text = "Saldo:";
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(120, 149);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(75, 23);
            this.btnSacar.TabIndex = 5;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(116, 123);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(181, 20);
            this.txtValor.TabIndex = 3;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(24, 126);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 9;
            this.lblValor.Text = "Valor:";
            // 
            // grpConta
            // 
            this.grpConta.Controls.Add(this.txtTipoConta);
            this.grpConta.Controls.Add(this.lblTipoConta);
            this.grpConta.Controls.Add(this.btnTransferir);
            this.grpConta.Controls.Add(this.txtNumero);
            this.grpConta.Controls.Add(this.btnSacar);
            this.grpConta.Controls.Add(this.lblValor);
            this.grpConta.Controls.Add(this.btnDepositar);
            this.grpConta.Controls.Add(this.txtTitular);
            this.grpConta.Controls.Add(this.txtValor);
            this.grpConta.Controls.Add(this.lblNumero);
            this.grpConta.Controls.Add(this.lblTitular);
            this.grpConta.Controls.Add(this.lblSaldo);
            this.grpConta.Controls.Add(this.txtSaldo);
            this.grpConta.Location = new System.Drawing.Point(12, 92);
            this.grpConta.Name = "grpConta";
            this.grpConta.Size = new System.Drawing.Size(325, 182);
            this.grpConta.TabIndex = 10;
            this.grpConta.TabStop = false;
            this.grpConta.Text = "Conta";
            // 
            // txtTipoConta
            // 
            this.txtTipoConta.Location = new System.Drawing.Point(116, 45);
            this.txtTipoConta.Name = "txtTipoConta";
            this.txtTipoConta.ReadOnly = true;
            this.txtTipoConta.Size = new System.Drawing.Size(181, 20);
            this.txtTipoConta.TabIndex = 11;
            // 
            // lblTipoConta
            // 
            this.lblTipoConta.AutoSize = true;
            this.lblTipoConta.Location = new System.Drawing.Point(21, 48);
            this.lblTipoConta.Name = "lblTipoConta";
            this.lblTipoConta.Size = new System.Drawing.Size(31, 13);
            this.lblTipoConta.TabIndex = 12;
            this.lblTipoConta.Text = "Tipo:";
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(201, 149);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(75, 23);
            this.btnTransferir.TabIndex = 6;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(21, 22);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(87, 13);
            this.lblConta.TabIndex = 0;
            this.lblConta.Text = "Escolha a conta:";
            // 
            // cmbContas
            // 
            this.cmbContas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContas.FormattingEnabled = true;
            this.cmbContas.Location = new System.Drawing.Point(116, 19);
            this.cmbContas.Name = "cmbContas";
            this.cmbContas.Size = new System.Drawing.Size(181, 21);
            this.cmbContas.TabIndex = 3;
            this.cmbContas.SelectedIndexChanged += new System.EventHandler(this.cmbContas_SelectedIndexChanged);
            // 
            // grpBancoContas
            // 
            this.grpBancoContas.Controls.Add(this.lblBuscarTitular);
            this.grpBancoContas.Controls.Add(this.btnBuscar);
            this.grpBancoContas.Controls.Add(this.txtBuscaTitular);
            this.grpBancoContas.Controls.Add(this.cmbContas);
            this.grpBancoContas.Controls.Add(this.lblConta);
            this.grpBancoContas.Location = new System.Drawing.Point(12, 12);
            this.grpBancoContas.Name = "grpBancoContas";
            this.grpBancoContas.Size = new System.Drawing.Size(325, 74);
            this.grpBancoContas.TabIndex = 11;
            this.grpBancoContas.TabStop = false;
            this.grpBancoContas.Text = "Banco de Contas";
            // 
            // grpTransferencia
            // 
            this.grpTransferencia.Controls.Add(this.cmbContaDestinoTransferencia);
            this.grpTransferencia.Controls.Add(this.lblContaDestinoTransferencia);
            this.grpTransferencia.Location = new System.Drawing.Point(15, 280);
            this.grpTransferencia.Name = "grpTransferencia";
            this.grpTransferencia.Size = new System.Drawing.Size(325, 49);
            this.grpTransferencia.TabIndex = 12;
            this.grpTransferencia.TabStop = false;
            this.grpTransferencia.Text = "Conta para Transferência";
            // 
            // cmbContaDestinoTransferencia
            // 
            this.cmbContaDestinoTransferencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContaDestinoTransferencia.FormattingEnabled = true;
            this.cmbContaDestinoTransferencia.Location = new System.Drawing.Point(113, 19);
            this.cmbContaDestinoTransferencia.Name = "cmbContaDestinoTransferencia";
            this.cmbContaDestinoTransferencia.Size = new System.Drawing.Size(181, 21);
            this.cmbContaDestinoTransferencia.TabIndex = 3;
            this.cmbContaDestinoTransferencia.SelectedIndexChanged += new System.EventHandler(this.cmbContaDestinoTransferencia_SelectedIndexChanged);
            // 
            // lblContaDestinoTransferencia
            // 
            this.lblContaDestinoTransferencia.AutoSize = true;
            this.lblContaDestinoTransferencia.Location = new System.Drawing.Point(24, 22);
            this.lblContaDestinoTransferencia.Name = "lblContaDestinoTransferencia";
            this.lblContaDestinoTransferencia.Size = new System.Drawing.Size(87, 13);
            this.lblContaDestinoTransferencia.TabIndex = 0;
            this.lblContaDestinoTransferencia.Text = "Escolha a conta:";
            // 
            // btnNovaConta
            // 
            this.btnNovaConta.Location = new System.Drawing.Point(132, 335);
            this.btnNovaConta.Name = "btnNovaConta";
            this.btnNovaConta.Size = new System.Drawing.Size(75, 23);
            this.btnNovaConta.TabIndex = 7;
            this.btnNovaConta.Text = "Nova Conta";
            this.btnNovaConta.UseVisualStyleBackColor = true;
            this.btnNovaConta.Click += new System.EventHandler(this.btnNovaConta_Click);
            // 
            // btnCalculaImpostos
            // 
            this.btnCalculaImpostos.Location = new System.Drawing.Point(214, 336);
            this.btnCalculaImpostos.Name = "btnCalculaImpostos";
            this.btnCalculaImpostos.Size = new System.Drawing.Size(75, 23);
            this.btnCalculaImpostos.TabIndex = 8;
            this.btnCalculaImpostos.Text = "Impostos";
            this.btnCalculaImpostos.UseVisualStyleBackColor = true;
            this.btnCalculaImpostos.Click += new System.EventHandler(this.btnCalculaImpostos_Click);
            // 
            // txtBuscaTitular
            // 
            this.txtBuscaTitular.Location = new System.Drawing.Point(116, 46);
            this.txtBuscaTitular.Name = "txtBuscaTitular";
            this.txtBuscaTitular.Size = new System.Drawing.Size(100, 20);
            this.txtBuscaTitular.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(222, 44);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblBuscarTitular
            // 
            this.lblBuscarTitular.AutoSize = true;
            this.lblBuscarTitular.Location = new System.Drawing.Point(21, 49);
            this.lblBuscarTitular.Name = "lblBuscarTitular";
            this.lblBuscarTitular.Size = new System.Drawing.Size(93, 13);
            this.lblBuscarTitular.TabIndex = 6;
            this.lblBuscarTitular.Text = "Buscar por Titular:";
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Location = new System.Drawing.Point(51, 335);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(75, 23);
            this.btnRelatorios.TabIndex = 13;
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 363);
            this.Controls.Add(this.btnRelatorios);
            this.Controls.Add(this.btnCalculaImpostos);
            this.Controls.Add(this.btnNovaConta);
            this.Controls.Add(this.grpTransferencia);
            this.Controls.Add(this.grpBancoContas);
            this.Controls.Add(this.grpConta);
            this.Name = "frmPrincipal";
            this.Text = "Banco";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.grpConta.ResumeLayout(false);
            this.grpConta.PerformLayout();
            this.grpBancoContas.ResumeLayout(false);
            this.grpBancoContas.PerformLayout();
            this.grpTransferencia.ResumeLayout(false);
            this.grpTransferencia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.GroupBox grpConta;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.ComboBox cmbContas;
        private System.Windows.Forms.GroupBox grpBancoContas;
        private System.Windows.Forms.GroupBox grpTransferencia;
        private System.Windows.Forms.ComboBox cmbContaDestinoTransferencia;
        private System.Windows.Forms.Label lblContaDestinoTransferencia;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.Button btnNovaConta;
        private System.Windows.Forms.TextBox txtTipoConta;
        private System.Windows.Forms.Label lblTipoConta;
        private System.Windows.Forms.Button btnCalculaImpostos;
        private System.Windows.Forms.Label lblBuscarTitular;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscaTitular;
        private System.Windows.Forms.Button btnRelatorios;
    }
}

