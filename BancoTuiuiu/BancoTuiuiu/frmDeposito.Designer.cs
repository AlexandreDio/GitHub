namespace BancoTuiuiu
{
    partial class frmDeposito
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
            this.btnDepositoCancelar = new System.Windows.Forms.Button();
            this.btnDepositoConfirmar = new System.Windows.Forms.Button();
            this.gbDepositoOpcoes = new System.Windows.Forms.GroupBox();
            this.lblDepositoSaldo = new System.Windows.Forms.Label();
            this.txtDepositoSaldo = new System.Windows.Forms.TextBox();
            this.lblDepositoValor = new System.Windows.Forms.Label();
            this.txtDepositoValor = new System.Windows.Forms.TextBox();
            this.gbDepositoOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDepositoCancelar
            // 
            this.btnDepositoCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositoCancelar.Location = new System.Drawing.Point(17, 209);
            this.btnDepositoCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDepositoCancelar.Name = "btnDepositoCancelar";
            this.btnDepositoCancelar.Size = new System.Drawing.Size(227, 79);
            this.btnDepositoCancelar.TabIndex = 7;
            this.btnDepositoCancelar.Text = "CANCELAR";
            this.btnDepositoCancelar.UseVisualStyleBackColor = true;
            this.btnDepositoCancelar.Click += new System.EventHandler(this.btnDepositoCancelar_Click);
            // 
            // btnDepositoConfirmar
            // 
            this.btnDepositoConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositoConfirmar.Location = new System.Drawing.Point(340, 209);
            this.btnDepositoConfirmar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDepositoConfirmar.Name = "btnDepositoConfirmar";
            this.btnDepositoConfirmar.Size = new System.Drawing.Size(227, 79);
            this.btnDepositoConfirmar.TabIndex = 6;
            this.btnDepositoConfirmar.Text = "CONFIRMAR";
            this.btnDepositoConfirmar.UseVisualStyleBackColor = true;
            this.btnDepositoConfirmar.Click += new System.EventHandler(this.btnDepositoConfirmar_Click);
            // 
            // gbDepositoOpcoes
            // 
            this.gbDepositoOpcoes.Controls.Add(this.lblDepositoSaldo);
            this.gbDepositoOpcoes.Controls.Add(this.txtDepositoSaldo);
            this.gbDepositoOpcoes.Controls.Add(this.lblDepositoValor);
            this.gbDepositoOpcoes.Controls.Add(this.txtDepositoValor);
            this.gbDepositoOpcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDepositoOpcoes.Location = new System.Drawing.Point(17, 15);
            this.gbDepositoOpcoes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDepositoOpcoes.Name = "gbDepositoOpcoes";
            this.gbDepositoOpcoes.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDepositoOpcoes.Size = new System.Drawing.Size(549, 177);
            this.gbDepositoOpcoes.TabIndex = 5;
            this.gbDepositoOpcoes.TabStop = false;
            this.gbDepositoOpcoes.Text = "Informações do Depósito";
            // 
            // lblDepositoSaldo
            // 
            this.lblDepositoSaldo.AutoSize = true;
            this.lblDepositoSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositoSaldo.Location = new System.Drawing.Point(8, 44);
            this.lblDepositoSaldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepositoSaldo.Name = "lblDepositoSaldo";
            this.lblDepositoSaldo.Size = new System.Drawing.Size(100, 36);
            this.lblDepositoSaldo.TabIndex = 2;
            this.lblDepositoSaldo.Text = "Saldo:";
            // 
            // txtDepositoSaldo
            // 
            this.txtDepositoSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepositoSaldo.Location = new System.Drawing.Point(139, 31);
            this.txtDepositoSaldo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDepositoSaldo.Multiline = true;
            this.txtDepositoSaldo.Name = "txtDepositoSaldo";
            this.txtDepositoSaldo.Size = new System.Drawing.Size(401, 48);
            this.txtDepositoSaldo.TabIndex = 3;
            // 
            // lblDepositoValor
            // 
            this.lblDepositoValor.AutoSize = true;
            this.lblDepositoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositoValor.Location = new System.Drawing.Point(21, 123);
            this.lblDepositoValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepositoValor.Name = "lblDepositoValor";
            this.lblDepositoValor.Size = new System.Drawing.Size(94, 36);
            this.lblDepositoValor.TabIndex = 1;
            this.lblDepositoValor.Text = "Valor:";
            this.lblDepositoValor.Click += new System.EventHandler(this.lblSaqueValor_Click);
            // 
            // txtDepositoValor
            // 
            this.txtDepositoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepositoValor.Location = new System.Drawing.Point(139, 110);
            this.txtDepositoValor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDepositoValor.Multiline = true;
            this.txtDepositoValor.Name = "txtDepositoValor";
            this.txtDepositoValor.Size = new System.Drawing.Size(401, 48);
            this.txtDepositoValor.TabIndex = 0;
            this.txtDepositoValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDepositoValor_KeyPress);
            // 
            // frmDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 303);
            this.Controls.Add(this.btnDepositoCancelar);
            this.Controls.Add(this.btnDepositoConfirmar);
            this.Controls.Add(this.gbDepositoOpcoes);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDeposito";
            this.Text = "Depósito";
            this.Load += new System.EventHandler(this.frmDeposito_Load);
            this.gbDepositoOpcoes.ResumeLayout(false);
            this.gbDepositoOpcoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDepositoCancelar;
        private System.Windows.Forms.Button btnDepositoConfirmar;
        private System.Windows.Forms.GroupBox gbDepositoOpcoes;
        private System.Windows.Forms.Label lblDepositoValor;
        private System.Windows.Forms.TextBox txtDepositoValor;
        private System.Windows.Forms.Label lblDepositoSaldo;
        private System.Windows.Forms.TextBox txtDepositoSaldo;
    }
}