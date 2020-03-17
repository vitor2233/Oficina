namespace Oficina.Views
{
    partial class pagamentoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblServico = new System.Windows.Forms.Label();
            this.txtServico = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Location = new System.Drawing.Point(199, 38);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(57, 13);
            this.lblServico.TabIndex = 26;
            this.lblServico.Text = "SERVIÇO:";
            // 
            // txtServico
            // 
            this.txtServico.Location = new System.Drawing.Point(260, 35);
            this.txtServico.Name = "txtServico";
            this.txtServico.Size = new System.Drawing.Size(209, 20);
            this.txtServico.TabIndex = 25;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(390, 101);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(46, 13);
            this.lblValor.TabIndex = 23;
            this.lblValor.Text = "VALOR:";
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Location = new System.Drawing.Point(16, 101);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(146, 13);
            this.lblMetodo.TabIndex = 21;
            this.lblMetodo.Text = "MÉTODO DE PAGAMENTO:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(442, 98);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(222, 20);
            this.txtValor.TabIndex = 18;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(168, 98);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(209, 20);
            this.txtNome.TabIndex = 17;
            // 
            // pagamentoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblServico);
            this.Controls.Add(this.txtServico);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblMetodo);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtNome);
            this.Name = "pagamentoControl";
            this.Size = new System.Drawing.Size(707, 497);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.TextBox txtServico;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtNome;
    }
}
