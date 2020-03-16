namespace Oficina
{
    partial class FormOficina
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
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.btnOrcamento = new System.Windows.Forms.Button();
            this.btnCarro = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.pagamentoControl = new Oficina.Views.pagamentoControl();
            this.orcamentoControl = new Oficina.Views.orcamentoControl();
            this.clienteControl = new Oficina.Views.clienteControl();
            this.carroControl = new Oficina.Views.carroControl();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.sidePanel.Controls.Add(this.btnPagamento);
            this.sidePanel.Controls.Add(this.btnOrcamento);
            this.sidePanel.Controls.Add(this.btnCarro);
            this.sidePanel.Controls.Add(this.btnCliente);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(170, 519);
            this.sidePanel.TabIndex = 0;
            // 
            // btnPagamento
            // 
            this.btnPagamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagamento.FlatAppearance.BorderSize = 0;
            this.btnPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagamento.Location = new System.Drawing.Point(0, 355);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(170, 49);
            this.btnPagamento.TabIndex = 5;
            this.btnPagamento.Text = "PAGAMENTOS";
            this.btnPagamento.UseVisualStyleBackColor = true;
            this.btnPagamento.Click += new System.EventHandler(this.btnPagamento_Click);
            // 
            // btnOrcamento
            // 
            this.btnOrcamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrcamento.FlatAppearance.BorderSize = 0;
            this.btnOrcamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrcamento.Location = new System.Drawing.Point(0, 268);
            this.btnOrcamento.Name = "btnOrcamento";
            this.btnOrcamento.Size = new System.Drawing.Size(170, 49);
            this.btnOrcamento.TabIndex = 4;
            this.btnOrcamento.Text = "ORÇAMENTOS";
            this.btnOrcamento.UseVisualStyleBackColor = true;
            this.btnOrcamento.Click += new System.EventHandler(this.btnOrcamento_Click);
            // 
            // btnCarro
            // 
            this.btnCarro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarro.FlatAppearance.BorderSize = 0;
            this.btnCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarro.Location = new System.Drawing.Point(0, 181);
            this.btnCarro.Name = "btnCarro";
            this.btnCarro.Size = new System.Drawing.Size(170, 49);
            this.btnCarro.TabIndex = 3;
            this.btnCarro.Text = "CARROS";
            this.btnCarro.UseVisualStyleBackColor = true;
            this.btnCarro.Click += new System.EventHandler(this.btnCarro_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Location = new System.Drawing.Point(0, 94);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(170, 49);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "CLIENTES";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(170, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(707, 22);
            this.headerPanel.TabIndex = 1;
            // 
            // pagamentoControl
            // 
            this.pagamentoControl.Location = new System.Drawing.Point(170, 22);
            this.pagamentoControl.Name = "pagamentoControl";
            this.pagamentoControl.Size = new System.Drawing.Size(707, 497);
            this.pagamentoControl.TabIndex = 5;
            // 
            // orcamentoControl
            // 
            this.orcamentoControl.Location = new System.Drawing.Point(170, 22);
            this.orcamentoControl.Name = "orcamentoControl";
            this.orcamentoControl.Size = new System.Drawing.Size(707, 497);
            this.orcamentoControl.TabIndex = 4;
            // 
            // clienteControl
            // 
            this.clienteControl.Location = new System.Drawing.Point(170, 22);
            this.clienteControl.Name = "clienteControl";
            this.clienteControl.Size = new System.Drawing.Size(707, 497);
            this.clienteControl.TabIndex = 3;
            // 
            // carroControl
            // 
            this.carroControl.Location = new System.Drawing.Point(170, 22);
            this.carroControl.Name = "carroControl";
            this.carroControl.Size = new System.Drawing.Size(707, 497);
            this.carroControl.TabIndex = 2;
            // 
            // FormOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 519);
            this.Controls.Add(this.pagamentoControl);
            this.Controls.Add(this.orcamentoControl);
            this.Controls.Add(this.clienteControl);
            this.Controls.Add(this.carroControl);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOficina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOficina";
            this.sidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button btnCarro;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnPagamento;
        private System.Windows.Forms.Button btnOrcamento;
        private Views.carroControl carroControl;
        private Views.clienteControl clienteControl;
        private Views.orcamentoControl orcamentoControl;
        private Views.pagamentoControl pagamentoControl;
    }
}

