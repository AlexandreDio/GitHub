namespace Prototipo_Aula1
{
    partial class frm1
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
            this.btnFrm1Confirma = new System.Windows.Forms.Button();
            this.txtFrm1Entrada = new System.Windows.Forms.TextBox();
            this.txtFrm1Retorno = new System.Windows.Forms.TextBox();
            this.lblFrm1Entrada = new System.Windows.Forms.Label();
            this.lblFrm1Retorno = new System.Windows.Forms.Label();
            this.btnFrm1Fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFrm1Confirma
            // 
            this.btnFrm1Confirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrm1Confirma.Location = new System.Drawing.Point(450, 302);
            this.btnFrm1Confirma.Name = "btnFrm1Confirma";
            this.btnFrm1Confirma.Size = new System.Drawing.Size(182, 82);
            this.btnFrm1Confirma.TabIndex = 2;
            this.btnFrm1Confirma.Text = "Confirmar";
            this.btnFrm1Confirma.UseVisualStyleBackColor = true;
            this.btnFrm1Confirma.Click += new System.EventHandler(this.btnFrm1Confirma_Click);
            this.btnFrm1Confirma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnFrm1Confirma_KeyPress);
            // 
            // txtFrm1Entrada
            // 
            this.txtFrm1Entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrm1Entrada.Location = new System.Drawing.Point(252, 55);
            this.txtFrm1Entrada.Name = "txtFrm1Entrada";
            this.txtFrm1Entrada.Size = new System.Drawing.Size(311, 55);
            this.txtFrm1Entrada.TabIndex = 0;
            // 
            // txtFrm1Retorno
            // 
            this.txtFrm1Retorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrm1Retorno.Location = new System.Drawing.Point(252, 191);
            this.txtFrm1Retorno.Name = "txtFrm1Retorno";
            this.txtFrm1Retorno.Size = new System.Drawing.Size(311, 55);
            this.txtFrm1Retorno.TabIndex = 1;
            // 
            // lblFrm1Entrada
            // 
            this.lblFrm1Entrada.AutoSize = true;
            this.lblFrm1Entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrm1Entrada.Location = new System.Drawing.Point(154, 62);
            this.lblFrm1Entrada.Name = "lblFrm1Entrada";
            this.lblFrm1Entrada.Size = new System.Drawing.Size(83, 48);
            this.lblFrm1Entrada.TabIndex = 2;
            this.lblFrm1Entrada.Text = "Eu:";
            // 
            // lblFrm1Retorno
            // 
            this.lblFrm1Retorno.AutoSize = true;
            this.lblFrm1Retorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrm1Retorno.Location = new System.Drawing.Point(76, 198);
            this.lblFrm1Retorno.Name = "lblFrm1Retorno";
            this.lblFrm1Retorno.Size = new System.Drawing.Size(151, 48);
            this.lblFrm1Retorno.TabIndex = 2;
            this.lblFrm1Retorno.Text = "Amigo:";
            // 
            // btnFrm1Fechar
            // 
            this.btnFrm1Fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrm1Fechar.Location = new System.Drawing.Point(185, 302);
            this.btnFrm1Fechar.Name = "btnFrm1Fechar";
            this.btnFrm1Fechar.Size = new System.Drawing.Size(182, 82);
            this.btnFrm1Fechar.TabIndex = 2;
            this.btnFrm1Fechar.Text = "Fechar";
            this.btnFrm1Fechar.UseVisualStyleBackColor = true;
            this.btnFrm1Fechar.Click += new System.EventHandler(this.btnFrm1Fechar_Click);
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFrm1Retorno);
            this.Controls.Add(this.lblFrm1Entrada);
            this.Controls.Add(this.txtFrm1Retorno);
            this.Controls.Add(this.txtFrm1Entrada);
            this.Controls.Add(this.btnFrm1Fechar);
            this.Controls.Add(this.btnFrm1Confirma);
            this.Name = "frm1";
            this.Text = "Eu";
            this.Load += new System.EventHandler(this.frm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFrm1Confirma;
        private System.Windows.Forms.TextBox txtFrm1Entrada;
        private System.Windows.Forms.TextBox txtFrm1Retorno;
        private System.Windows.Forms.Label lblFrm1Entrada;
        private System.Windows.Forms.Label lblFrm1Retorno;
        private System.Windows.Forms.Button btnFrm1Fechar;
    }
}

