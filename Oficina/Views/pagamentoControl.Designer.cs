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
            this.lblValor = new System.Windows.Forms.Label();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblDataPagamento = new System.Windows.Forms.Label();
            this.txtServico = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMetodoPagamento = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDataPagamento = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtValor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDescricao = new Bunifu.Framework.UI.BunifuMaterialTextbox();
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
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(315, 109);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(46, 13);
            this.lblValor.TabIndex = 23;
            this.lblValor.Text = "VALOR:";
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Location = new System.Drawing.Point(3, 101);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(146, 13);
            this.lblMetodo.TabIndex = 21;
            this.lblMetodo.Text = "MÉTODO DE PAGAMENTO:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(289, 144);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(72, 13);
            this.lblDescricao.TabIndex = 34;
            this.lblDescricao.Text = "DESCRIÇÃO:";
            // 
            // lblDataPagamento
            // 
            this.lblDataPagamento.AutoSize = true;
            this.lblDataPagamento.Location = new System.Drawing.Point(21, 144);
            this.lblDataPagamento.Name = "lblDataPagamento";
            this.lblDataPagamento.Size = new System.Drawing.Size(128, 13);
            this.lblDataPagamento.TabIndex = 33;
            this.lblDataPagamento.Text = "DATA DE PAGAMENTO:";
            // 
            // txtServico
            // 
            this.txtServico.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServico.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtServico.HintForeColor = System.Drawing.Color.Empty;
            this.txtServico.HintText = "";
            this.txtServico.isPassword = false;
            this.txtServico.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.txtServico.LineIdleColor = System.Drawing.Color.Gray;
            this.txtServico.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.txtServico.LineThickness = 3;
            this.txtServico.Location = new System.Drawing.Point(281, 30);
            this.txtServico.Margin = new System.Windows.Forms.Padding(4);
            this.txtServico.Name = "txtServico";
            this.txtServico.Size = new System.Drawing.Size(209, 21);
            this.txtServico.TabIndex = 36;
            this.txtServico.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMetodoPagamento
            // 
            this.txtMetodoPagamento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMetodoPagamento.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMetodoPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMetodoPagamento.HintForeColor = System.Drawing.Color.Empty;
            this.txtMetodoPagamento.HintText = "";
            this.txtMetodoPagamento.isPassword = false;
            this.txtMetodoPagamento.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.txtMetodoPagamento.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMetodoPagamento.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.txtMetodoPagamento.LineThickness = 3;
            this.txtMetodoPagamento.Location = new System.Drawing.Point(156, 93);
            this.txtMetodoPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.txtMetodoPagamento.Name = "txtMetodoPagamento";
            this.txtMetodoPagamento.Size = new System.Drawing.Size(102, 21);
            this.txtMetodoPagamento.TabIndex = 37;
            this.txtMetodoPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDataPagamento
            // 
            this.txtDataPagamento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDataPagamento.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDataPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDataPagamento.HintForeColor = System.Drawing.Color.Empty;
            this.txtDataPagamento.HintText = "";
            this.txtDataPagamento.isPassword = false;
            this.txtDataPagamento.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.txtDataPagamento.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDataPagamento.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.txtDataPagamento.LineThickness = 3;
            this.txtDataPagamento.Location = new System.Drawing.Point(156, 136);
            this.txtDataPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataPagamento.Name = "txtDataPagamento";
            this.txtDataPagamento.Size = new System.Drawing.Size(102, 21);
            this.txtDataPagamento.TabIndex = 38;
            this.txtDataPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtValor
            // 
            this.txtValor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtValor.HintForeColor = System.Drawing.Color.Empty;
            this.txtValor.HintText = "";
            this.txtValor.isPassword = false;
            this.txtValor.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.txtValor.LineIdleColor = System.Drawing.Color.Gray;
            this.txtValor.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.txtValor.LineThickness = 3;
            this.txtValor.Location = new System.Drawing.Point(373, 101);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(209, 21);
            this.txtValor.TabIndex = 39;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescricao.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescricao.HintForeColor = System.Drawing.Color.Empty;
            this.txtDescricao.HintText = "";
            this.txtDescricao.isPassword = false;
            this.txtDescricao.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.txtDescricao.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDescricao.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.txtDescricao.LineThickness = 3;
            this.txtDescricao.Location = new System.Drawing.Point(373, 136);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(209, 21);
            this.txtDescricao.TabIndex = 40;
            this.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pagamentoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtDataPagamento);
            this.Controls.Add(this.txtMetodoPagamento);
            this.Controls.Add(this.txtServico);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblDataPagamento);
            this.Controls.Add(this.lblServico);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblMetodo);
            this.Name = "pagamentoControl";
            this.Size = new System.Drawing.Size(707, 497);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblDataPagamento;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtServico;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMetodoPagamento;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDataPagamento;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtValor;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDescricao;
    }
}
