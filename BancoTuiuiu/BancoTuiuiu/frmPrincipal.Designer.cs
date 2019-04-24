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
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblNumConta = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSaque = new System.Windows.Forms.Button();
            this.btnDepositio = new System.Windows.Forms.Button();
            this.pnlMensagem = new System.Windows.Forms.Panel();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gbOpcoes.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMensagem.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOpcoes
            // 
            this.gbOpcoes.Controls.Add(this.txtSaldo);
            this.gbOpcoes.Controls.Add(this.lblSaldo);
            this.gbOpcoes.Controls.Add(this.lblNumConta);
            this.gbOpcoes.Controls.Add(this.lblNome);
            this.gbOpcoes.Controls.Add(this.txtConta);
            this.gbOpcoes.Controls.Add(this.txtNome);
            this.gbOpcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpcoes.Location = new System.Drawing.Point(16, 113);
            this.gbOpcoes.Margin = new System.Windows.Forms.Padding(4);
            this.gbOpcoes.Name = "gbOpcoes";
            this.gbOpcoes.Padding = new System.Windows.Forms.Padding(4);
            this.gbOpcoes.Size = new System.Drawing.Size(549, 250);
            this.gbOpcoes.TabIndex = 0;
            this.gbOpcoes.TabStop = false;
            this.gbOpcoes.Text = "Informações do Cliente";
            this.gbOpcoes.Enter += new System.EventHandler(this.gbOpcoes_Enter);
            // 
            // txtSaldo
            // 
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Location = new System.Drawing.Point(125, 174);
            this.txtSaldo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(401, 55);
            this.txtSaldo.TabIndex = 2;
            this.txtSaldo.Enter += new System.EventHandler(this.txtSaldo_Enter);
            this.txtSaldo.Leave += new System.EventHandler(this.txtSaldo_Leave);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(8, 185);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(100, 36);
            this.lblSaldo.TabIndex = 1;
            this.lblSaldo.Text = "Saldo:";
            // 
            // lblNumConta
            // 
            this.lblNumConta.AutoSize = true;
            this.lblNumConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumConta.Location = new System.Drawing.Point(8, 123);
            this.lblNumConta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumConta.Name = "lblNumConta";
            this.lblNumConta.Size = new System.Drawing.Size(102, 36);
            this.lblNumConta.TabIndex = 1;
            this.lblNumConta.Text = "Conta:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(8, 55);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(101, 36);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // txtConta
            // 
            this.txtConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConta.Location = new System.Drawing.Point(125, 110);
            this.txtConta.Margin = new System.Windows.Forms.Padding(4);
            this.txtConta.Multiline = true;
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(401, 48);
            this.txtConta.TabIndex = 1;
            this.txtConta.Enter += new System.EventHandler(this.txtConta_Enter);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(125, 42);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(401, 48);
            this.txtNome.TabIndex = 0;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.Coral;
            this.pnlTitulo.Controls.Add(this.pictureBox1);
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Location = new System.Drawing.Point(1, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(579, 106);
            this.pnlTitulo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BancoTuiuiu.Properties.Resources.tuiuiu3;
            this.pictureBox1.Location = new System.Drawing.Point(29, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTitulo.Location = new System.Drawing.Point(133, 23);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(386, 67);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Banco Tuiuiu";
            // 
            // btnSaque
            // 
            this.btnSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaque.Location = new System.Drawing.Point(200, 446);
            this.btnSaque.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(160, 79);
            this.btnSaque.TabIndex = 3;
            this.btnSaque.Text = "SAQUE";
            this.btnSaque.UseVisualStyleBackColor = true;
            this.btnSaque.Click += new System.EventHandler(this.btnSaque_Click);
            // 
            // btnDepositio
            // 
            this.btnDepositio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositio.Location = new System.Drawing.Point(382, 446);
            this.btnDepositio.Margin = new System.Windows.Forms.Padding(4);
            this.btnDepositio.Name = "btnDepositio";
            this.btnDepositio.Size = new System.Drawing.Size(160, 79);
            this.btnDepositio.TabIndex = 4;
            this.btnDepositio.Text = "DEPÓSITO";
            this.btnDepositio.UseVisualStyleBackColor = true;
            this.btnDepositio.Click += new System.EventHandler(this.btnDepositio_Click);
            // 
            // pnlMensagem
            // 
            this.pnlMensagem.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlMensagem.Controls.Add(this.lblMensagem);
            this.pnlMensagem.Location = new System.Drawing.Point(1, 378);
            this.pnlMensagem.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMensagem.Name = "pnlMensagem";
            this.pnlMensagem.Size = new System.Drawing.Size(579, 53);
            this.pnlMensagem.TabIndex = 1;
            this.pnlMensagem.Visible = false;
            // 
            // lblMensagem
            // 
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblMensagem.Location = new System.Drawing.Point(109, 11);
            this.lblMensagem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(377, 31);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "msg";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensagem.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 446);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 79);
            this.button1.TabIndex = 4;
            this.button1.Text = "SAIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 540);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDepositio);
            this.Controls.Add(this.btnSaque);
            this.Controls.Add(this.pnlMensagem);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.gbOpcoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Activated += new System.EventHandler(this.frmPrincipal_Activated);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Shown += new System.EventHandler(this.frmPrincipal_Shown);
            this.Enter += new System.EventHandler(this.frmPrincipal_Enter);
            this.gbOpcoes.ResumeLayout(false);
            this.gbOpcoes.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Panel pnlMensagem;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

