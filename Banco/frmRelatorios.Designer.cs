namespace Banco
{
    partial class frmRelatorios
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
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.btnFiltroSaldo = new System.Windows.Forms.Button();
            this.btnFiltroAntigas = new System.Windows.Forms.Button();
            this.grpResumo = new System.Windows.Forms.GroupBox();
            this.txtMaiorSaldo = new System.Windows.Forms.TextBox();
            this.txtSaldoTotal = new System.Windows.Forms.TextBox();
            this.lblMaiorSaldo = new System.Windows.Forms.Label();
            this.lblSaldoTotal = new System.Windows.Forms.Label();
            this.grpResumo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstResultado
            // 
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.Location = new System.Drawing.Point(12, 13);
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(449, 173);
            this.lstResultado.TabIndex = 0;
            // 
            // btnFiltroSaldo
            // 
            this.btnFiltroSaldo.Location = new System.Drawing.Point(12, 283);
            this.btnFiltroSaldo.Name = "btnFiltroSaldo";
            this.btnFiltroSaldo.Size = new System.Drawing.Size(162, 23);
            this.btnFiltroSaldo.TabIndex = 1;
            this.btnFiltroSaldo.Text = "Saldos maiores do que 5.000";
            this.btnFiltroSaldo.UseVisualStyleBackColor = true;
            this.btnFiltroSaldo.Click += new System.EventHandler(this.btnFiltroSaldo_Click);
            // 
            // btnFiltroAntigas
            // 
            this.btnFiltroAntigas.Location = new System.Drawing.Point(386, 283);
            this.btnFiltroAntigas.Name = "btnFiltroAntigas";
            this.btnFiltroAntigas.Size = new System.Drawing.Size(75, 23);
            this.btnFiltroAntigas.TabIndex = 2;
            this.btnFiltroAntigas.Text = "Antigas";
            this.btnFiltroAntigas.UseVisualStyleBackColor = true;
            this.btnFiltroAntigas.Click += new System.EventHandler(this.btnFiltroAntigas_Click);
            // 
            // grpResumo
            // 
            this.grpResumo.Controls.Add(this.txtMaiorSaldo);
            this.grpResumo.Controls.Add(this.txtSaldoTotal);
            this.grpResumo.Controls.Add(this.lblMaiorSaldo);
            this.grpResumo.Controls.Add(this.lblSaldoTotal);
            this.grpResumo.Location = new System.Drawing.Point(13, 193);
            this.grpResumo.Name = "grpResumo";
            this.grpResumo.Size = new System.Drawing.Size(448, 84);
            this.grpResumo.TabIndex = 3;
            this.grpResumo.TabStop = false;
            this.grpResumo.Text = "Resumo";
            // 
            // txtMaiorSaldo
            // 
            this.txtMaiorSaldo.Location = new System.Drawing.Point(76, 47);
            this.txtMaiorSaldo.Name = "txtMaiorSaldo";
            this.txtMaiorSaldo.ReadOnly = true;
            this.txtMaiorSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtMaiorSaldo.TabIndex = 3;
            // 
            // txtSaldoTotal
            // 
            this.txtSaldoTotal.Location = new System.Drawing.Point(76, 19);
            this.txtSaldoTotal.Name = "txtSaldoTotal";
            this.txtSaldoTotal.ReadOnly = true;
            this.txtSaldoTotal.Size = new System.Drawing.Size(100, 20);
            this.txtSaldoTotal.TabIndex = 2;
            // 
            // lblMaiorSaldo
            // 
            this.lblMaiorSaldo.AutoSize = true;
            this.lblMaiorSaldo.Location = new System.Drawing.Point(6, 50);
            this.lblMaiorSaldo.Name = "lblMaiorSaldo";
            this.lblMaiorSaldo.Size = new System.Drawing.Size(66, 13);
            this.lblMaiorSaldo.TabIndex = 1;
            this.lblMaiorSaldo.Text = "Maior Saldo:";
            // 
            // lblSaldoTotal
            // 
            this.lblSaldoTotal.AutoSize = true;
            this.lblSaldoTotal.Location = new System.Drawing.Point(6, 23);
            this.lblSaldoTotal.Name = "lblSaldoTotal";
            this.lblSaldoTotal.Size = new System.Drawing.Size(64, 13);
            this.lblSaldoTotal.TabIndex = 0;
            this.lblSaldoTotal.Text = "Saldo Total:";
            // 
            // frmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 318);
            this.Controls.Add(this.grpResumo);
            this.Controls.Add(this.btnFiltroAntigas);
            this.Controls.Add(this.btnFiltroSaldo);
            this.Controls.Add(this.lstResultado);
            this.Name = "frmRelatorios";
            this.Text = "Relatórios";
            this.Load += new System.EventHandler(this.frmRelatorios_Load);
            this.grpResumo.ResumeLayout(false);
            this.grpResumo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstResultado;
        private System.Windows.Forms.Button btnFiltroSaldo;
        private System.Windows.Forms.Button btnFiltroAntigas;
        private System.Windows.Forms.GroupBox grpResumo;
        private System.Windows.Forms.TextBox txtMaiorSaldo;
        private System.Windows.Forms.TextBox txtSaldoTotal;
        private System.Windows.Forms.Label lblMaiorSaldo;
        private System.Windows.Forms.Label lblSaldoTotal;
    }
}