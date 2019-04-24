namespace BancoTuiuiu
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
            this.gbOpcoes = new System.Windows.Forms.GroupBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblNumConta = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSaque = new System.Windows.Forms.Button();
            this.btnDepositio = new System.Windows.Forms.Button();
            this.pnlMensagem = new System.Windows.Forms.Panel();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.gbOpcoes.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.pnlMensagem.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOpcoes
            // 
            this.gbOpcoes.Controls.Add(this.lblSaldo);
            this.gbOpcoes.Controls.Add(this.lblNumConta);
            this.gbOpcoes.Controls.Add(this.lblNome);
            this.gbOpcoes.Controls.Add(this.txtSaldo);
            this.gbOpcoes.Controls.Add(this.txtConta);
            this.gbOpcoes.Controls.Add(this.txtNome);
            this.gbOpcoes.Location = new System.Drawing.Point(12, 92);
            this.gbOpcoes.Name = "gbOpcoes";
            this.gbOpcoes.Size = new System.Drawing.Size(283, 181);
            this.gbOpcoes.TabIndex = 0;
            this.gbOpcoes.TabStop = false;
            this.gbOpcoes.Text = "Informações do Cliente";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(6, 144);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(82, 29);
            this.lblSaldo.TabIndex = 1;
            this.lblSaldo.Text = "Saldo:";
            // 
            // lblNumConta
            // 
            this.lblNumConta.AutoSize = true;
            this.lblNumConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumConta.Location = new System.Drawing.Point(6, 89);
            this.lblNumConta.Name = "lblNumConta";
            this.lblNumConta.Size = new System.Drawing.Size(82, 29);
            this.lblNumConta.TabIndex = 1;
            this.lblNumConta.Text = "Conta:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(6, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(85, 29);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Location = new System.Drawing.Point(94, 133);
            this.txtSaldo.Multiline = true;
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(177, 40);
            this.txtSaldo.TabIndex = 2;
            // 
            // txtConta
            // 
            this.txtConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConta.Location = new System.Drawing.Point(94, 78);
            this.txtConta.Multiline = true;
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(176, 40);
            this.txtConta.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(94, 19);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(177, 40);
            this.txtNome.TabIndex = 0;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.Coral;
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Location = new System.Drawing.Point(1, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(308, 86);
            this.pnlTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTitulo.Location = new System.Drawing.Point(28, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(253, 44);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Banco Tuiuiu";
            // 
            // btnSaque
            // 
            this.btnSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaque.Location = new System.Drawing.Point(12, 338);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(109, 76);
            this.btnSaque.TabIndex = 3;
            this.btnSaque.Text = "SAQUE";
            this.btnSaque.UseVisualStyleBackColor = true;
            // 
            // btnDepositio
            // 
            this.btnDepositio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositio.Location = new System.Drawing.Point(186, 338);
            this.btnDepositio.Name = "btnDepositio";
            this.btnDepositio.Size = new System.Drawing.Size(109, 76);
            this.btnDepositio.TabIndex = 4;
            this.btnDepositio.Text = "DEPÓSITO";
            this.btnDepositio.UseVisualStyleBackColor = true;
            // 
            // pnlMensagem
            // 
            this.pnlMensagem.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlMensagem.Controls.Add(this.lblMensagem);
            this.pnlMensagem.Location = new System.Drawing.Point(1, 284);
            this.pnlMensagem.Name = "pnlMensagem";
            this.pnlMensagem.Size = new System.Drawing.Size(308, 43);
            this.pnlMensagem.TabIndex = 1;
            this.pnlMensagem.Visible = false;
            // 
            // lblMensagem
            // 
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblMensagem.Location = new System.Drawing.Point(13, 9);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(283, 25);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "msg";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensagem.Visible = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 423);
            this.Controls.Add(this.btnDepositio);
            this.Controls.Add(this.btnSaque);
            this.Controls.Add(this.pnlMensagem);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.gbOpcoes);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.gbOpcoes.ResumeLayout(false);
            this.gbOpcoes.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlMensagem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOpcoes;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSaque;
        private System.Windows.Forms.Button btnDepositio;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblNumConta;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Panel pnlMensagem;
        private System.Windows.Forms.Label lblMensagem;
    }
}

