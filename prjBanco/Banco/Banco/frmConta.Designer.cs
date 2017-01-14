namespace Banco
{
    partial class frmConta
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.lblConta = new System.Windows.Forms.Label();
            this.cmbContas = new System.Windows.Forms.ComboBox();
            this.grpBancoContas = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbContaDestinoTransferencia = new System.Windows.Forms.ComboBox();
            this.lblContaDestinoTransferencia = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpBancoContas.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(39, 123);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(75, 23);
            this.btnDepositar.TabIndex = 5;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(113, 19);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(181, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(113, 45);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.ReadOnly = true;
            this.txtTitular.Size = new System.Drawing.Size(181, 20);
            this.txtTitular.TabIndex = 2;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(113, 71);
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
            this.lblTitular.Location = new System.Drawing.Point(21, 48);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(39, 13);
            this.lblTitular.TabIndex = 5;
            this.lblTitular.Text = "Titular:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(21, 74);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(37, 13);
            this.lblSaldo.TabIndex = 6;
            this.lblSaldo.Text = "Saldo:";
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(120, 123);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(75, 23);
            this.btnSacar.TabIndex = 6;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(113, 97);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(181, 20);
            this.txtValor.TabIndex = 4;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(24, 100);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 9;
            this.lblValor.Text = "Valor:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTransferir);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.btnSacar);
            this.groupBox1.Controls.Add(this.lblValor);
            this.groupBox1.Controls.Add(this.btnDepositar);
            this.groupBox1.Controls.Add(this.txtTitular);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.lblNumero);
            this.groupBox1.Controls.Add(this.lblTitular);
            this.groupBox1.Controls.Add(this.lblSaldo);
            this.groupBox1.Controls.Add(this.txtSaldo);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 156);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conta";
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(201, 123);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(75, 23);
            this.btnTransferir.TabIndex = 10;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(24, 22);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(87, 13);
            this.lblConta.TabIndex = 0;
            this.lblConta.Text = "Escolha a conta:";
            // 
            // cmbContas
            // 
            this.cmbContas.FormattingEnabled = true;
            this.cmbContas.Location = new System.Drawing.Point(113, 19);
            this.cmbContas.Name = "cmbContas";
            this.cmbContas.Size = new System.Drawing.Size(181, 21);
            this.cmbContas.TabIndex = 3;
            this.cmbContas.SelectedIndexChanged += new System.EventHandler(this.cmbContas_SelectedIndexChanged);
            // 
            // grpBancoContas
            // 
            this.grpBancoContas.Controls.Add(this.cmbContas);
            this.grpBancoContas.Controls.Add(this.lblConta);
            this.grpBancoContas.Location = new System.Drawing.Point(12, 12);
            this.grpBancoContas.Name = "grpBancoContas";
            this.grpBancoContas.Size = new System.Drawing.Size(325, 49);
            this.grpBancoContas.TabIndex = 11;
            this.grpBancoContas.TabStop = false;
            this.grpBancoContas.Text = "Banco de Contas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbContaDestinoTransferencia);
            this.groupBox2.Controls.Add(this.lblContaDestinoTransferencia);
            this.groupBox2.Location = new System.Drawing.Point(15, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 49);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conta para Transferência";
            // 
            // cmbContaDestinoTransferencia
            // 
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
            // frmConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 284);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpBancoContas);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConta";
            this.Text = "Banco";
            this.Load += new System.EventHandler(this.frmConta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBancoContas.ResumeLayout(false);
            this.grpBancoContas.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.ComboBox cmbContas;
        private System.Windows.Forms.GroupBox grpBancoContas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbContaDestinoTransferencia;
        private System.Windows.Forms.Label lblContaDestinoTransferencia;
        private System.Windows.Forms.Button btnTransferir;
    }
}

