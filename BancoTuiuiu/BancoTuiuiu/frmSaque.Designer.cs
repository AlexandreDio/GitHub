namespace BancoTuiuiu
{
    partial class frmSaque
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
            this.gbSaqueOpcoes = new System.Windows.Forms.GroupBox();
            this.lblSaqueSaldo = new System.Windows.Forms.Label();
            this.txtSaqueSaldo = new System.Windows.Forms.TextBox();
            this.lblSaqueValor = new System.Windows.Forms.Label();
            this.txtSaqueValor = new System.Windows.Forms.TextBox();
            this.btnSaqueConfirmar = new System.Windows.Forms.Button();
            this.btnSaqueCancelar = new System.Windows.Forms.Button();
            this.gbSaqueOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSaqueOpcoes
            // 
            this.gbSaqueOpcoes.Controls.Add(this.lblSaqueSaldo);
            this.gbSaqueOpcoes.Controls.Add(this.txtSaqueSaldo);
            this.gbSaqueOpcoes.Controls.Add(this.lblSaqueValor);
            this.gbSaqueOpcoes.Controls.Add(this.txtSaqueValor);
            this.gbSaqueOpcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSaqueOpcoes.Location = new System.Drawing.Point(16, 15);
            this.gbSaqueOpcoes.Margin = new System.Windows.Forms.Padding(4);
            this.gbSaqueOpcoes.Name = "gbSaqueOpcoes";
            this.gbSaqueOpcoes.Padding = new System.Windows.Forms.Padding(4);
            this.gbSaqueOpcoes.Size = new System.Drawing.Size(549, 177);
            this.gbSaqueOpcoes.TabIndex = 1;
            this.gbSaqueOpcoes.TabStop = false;
            this.gbSaqueOpcoes.Text = "Informações do Saque";
            // 
            // lblSaqueSaldo
            // 
            this.lblSaqueSaldo.AutoSize = true;
            this.lblSaqueSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaqueSaldo.Location = new System.Drawing.Point(8, 46);
            this.lblSaqueSaldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaqueSaldo.Name = "lblSaqueSaldo";
            this.lblSaqueSaldo.Size = new System.Drawing.Size(100, 36);
            this.lblSaqueSaldo.TabIndex = 2;
            this.lblSaqueSaldo.Text = "Saldo:";
            // 
            // txtSaqueSaldo
            // 
            this.txtSaqueSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaqueSaldo.Location = new System.Drawing.Point(125, 32);
            this.txtSaqueSaldo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSaqueSaldo.Multiline = true;
            this.txtSaqueSaldo.Name = "txtSaqueSaldo";
            this.txtSaqueSaldo.Size = new System.Drawing.Size(401, 48);
            this.txtSaqueSaldo.TabIndex = 3;
            // 
            // lblSaqueValor
            // 
            this.lblSaqueValor.AutoSize = true;
            this.lblSaqueValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaqueValor.Location = new System.Drawing.Point(15, 123);
            this.lblSaqueValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaqueValor.Name = "lblSaqueValor";
            this.lblSaqueValor.Size = new System.Drawing.Size(94, 36);
            this.lblSaqueValor.TabIndex = 1;
            this.lblSaqueValor.Text = "Valor:";
            // 
            // txtSaqueValor
            // 
            this.txtSaqueValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaqueValor.Location = new System.Drawing.Point(123, 110);
            this.txtSaqueValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtSaqueValor.Multiline = true;
            this.txtSaqueValor.Name = "txtSaqueValor";
            this.txtSaqueValor.Size = new System.Drawing.Size(401, 48);
            this.txtSaqueValor.TabIndex = 0;
            this.txtSaqueValor.Enter += new System.EventHandler(this.txtSaqueValor_Enter);
            this.txtSaqueValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaqueValor_KeyPress);
            // 
            // btnSaqueConfirmar
            // 
            this.btnSaqueConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaqueConfirmar.Location = new System.Drawing.Point(339, 209);
            this.btnSaqueConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaqueConfirmar.Name = "btnSaqueConfirmar";
            this.btnSaqueConfirmar.Size = new System.Drawing.Size(227, 79);
            this.btnSaqueConfirmar.TabIndex = 4;
            this.btnSaqueConfirmar.Text = "CONFIRMAR";
            this.btnSaqueConfirmar.UseVisualStyleBackColor = true;
            this.btnSaqueConfirmar.Click += new System.EventHandler(this.btnSaqueConfirmar_Click);
            // 
            // btnSaqueCancelar
            // 
            this.btnSaqueCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaqueCancelar.Location = new System.Drawing.Point(16, 209);
            this.btnSaqueCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaqueCancelar.Name = "btnSaqueCancelar";
            this.btnSaqueCancelar.Size = new System.Drawing.Size(227, 79);
            this.btnSaqueCancelar.TabIndex = 4;
            this.btnSaqueCancelar.Text = "CANCELAR";
            this.btnSaqueCancelar.UseVisualStyleBackColor = true;
            this.btnSaqueCancelar.Click += new System.EventHandler(this.btnSaqueCancelar_Click);
            // 
            // frmSaque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 303);
            this.Controls.Add(this.btnSaqueCancelar);
            this.Controls.Add(this.btnSaqueConfirmar);
            this.Controls.Add(this.gbSaqueOpcoes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSaque";
            this.Text = "Saque";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSaque_FormClosing);
            this.Load += new System.EventHandler(this.frmSaque_Load);
            this.gbSaqueOpcoes.ResumeLayout(false);
            this.gbSaqueOpcoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbSaqueOpcoes;
        private System.Windows.Forms.Label lblSaqueValor;
        private System.Windows.Forms.TextBox txtSaqueValor;
        private System.Windows.Forms.Button btnSaqueConfirmar;
        private System.Windows.Forms.Button btnSaqueCancelar;
        private System.Windows.Forms.Label lblSaqueSaldo;
        private System.Windows.Forms.TextBox txtSaqueSaldo;
    }
}