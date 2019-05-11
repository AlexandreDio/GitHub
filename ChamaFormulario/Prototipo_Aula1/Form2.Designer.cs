namespace Prototipo_Aula1
{
    partial class frm2
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
            this.lblFrm2Retorno = new System.Windows.Forms.Label();
            this.lblFrm2Entrada = new System.Windows.Forms.Label();
            this.txtFrm2Retorno = new System.Windows.Forms.TextBox();
            this.txtFrm2Entrada = new System.Windows.Forms.TextBox();
            this.btnFrm2Confirma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFrm2Retorno
            // 
            this.lblFrm2Retorno.AutoSize = true;
            this.lblFrm2Retorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrm2Retorno.Location = new System.Drawing.Point(246, 193);
            this.lblFrm2Retorno.Name = "lblFrm2Retorno";
            this.lblFrm2Retorno.Size = new System.Drawing.Size(83, 48);
            this.lblFrm2Retorno.TabIndex = 6;
            this.lblFrm2Retorno.Text = "Eu:";
            // 
            // lblFrm2Entrada
            // 
            this.lblFrm2Entrada.AutoSize = true;
            this.lblFrm2Entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrm2Entrada.Location = new System.Drawing.Point(178, 57);
            this.lblFrm2Entrada.Name = "lblFrm2Entrada";
            this.lblFrm2Entrada.Size = new System.Drawing.Size(151, 48);
            this.lblFrm2Entrada.TabIndex = 7;
            this.lblFrm2Entrada.Text = "Amigo:";
            // 
            // txtFrm2Retorno
            // 
            this.txtFrm2Retorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrm2Retorno.Location = new System.Drawing.Point(347, 186);
            this.txtFrm2Retorno.Name = "txtFrm2Retorno";
            this.txtFrm2Retorno.Size = new System.Drawing.Size(311, 55);
            this.txtFrm2Retorno.TabIndex = 1;
            // 
            // txtFrm2Entrada
            // 
            this.txtFrm2Entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrm2Entrada.Location = new System.Drawing.Point(347, 50);
            this.txtFrm2Entrada.Name = "txtFrm2Entrada";
            this.txtFrm2Entrada.Size = new System.Drawing.Size(311, 55);
            this.txtFrm2Entrada.TabIndex = 0;
            // 
            // btnFrm2Confirma
            // 
            this.btnFrm2Confirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrm2Confirma.Location = new System.Drawing.Point(403, 319);
            this.btnFrm2Confirma.Name = "btnFrm2Confirma";
            this.btnFrm2Confirma.Size = new System.Drawing.Size(182, 82);
            this.btnFrm2Confirma.TabIndex = 2;
            this.btnFrm2Confirma.Text = "Confirmar";
            this.btnFrm2Confirma.UseVisualStyleBackColor = true;
            this.btnFrm2Confirma.Click += new System.EventHandler(this.btnFrm2Confirma_Click);
            // 
            // frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFrm2Retorno);
            this.Controls.Add(this.lblFrm2Entrada);
            this.Controls.Add(this.txtFrm2Retorno);
            this.Controls.Add(this.txtFrm2Entrada);
            this.Controls.Add(this.btnFrm2Confirma);
            this.Name = "frm2";
            this.Text = "Amigo";
            this.Load += new System.EventHandler(this.frm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrm2Retorno;
        private System.Windows.Forms.Label lblFrm2Entrada;
        private System.Windows.Forms.TextBox txtFrm2Retorno;
        private System.Windows.Forms.TextBox txtFrm2Entrada;
        private System.Windows.Forms.Button btnFrm2Confirma;
    }
}