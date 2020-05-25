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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOficina));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnPagamento = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnOrcamento = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCarro = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bemVindoControl1 = new Oficina.Views.bemVindoControl();
            this.pagamentoControl = new Oficina.Views.pagamentoControl();
            this.orcamentoControl = new Oficina.Views.servicoControl();
            this.clienteControl = new Oficina.Views.clienteControl();
            this.carroControl = new Oficina.Views.carroControl();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sidePanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.sidePanel.Controls.Add(this.panelSide);
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
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.panelSide.Location = new System.Drawing.Point(160, 94);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(10, 49);
            this.panelSide.TabIndex = 6;
            // 
            // btnPagamento
            // 
            this.btnPagamento.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.btnPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.btnPagamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPagamento.BorderRadius = 0;
            this.btnPagamento.ButtonText = "PAGAMENTO";
            this.btnPagamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagamento.DisabledColor = System.Drawing.Color.Gray;
            this.btnPagamento.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPagamento.Iconimage = global::Oficina.Properties.Resources.carteira;
            this.btnPagamento.Iconimage_right = null;
            this.btnPagamento.Iconimage_right_Selected = null;
            this.btnPagamento.Iconimage_Selected = null;
            this.btnPagamento.IconMarginLeft = 0;
            this.btnPagamento.IconMarginRight = 0;
            this.btnPagamento.IconRightVisible = true;
            this.btnPagamento.IconRightZoom = 0D;
            this.btnPagamento.IconVisible = true;
            this.btnPagamento.IconZoom = 50D;
            this.btnPagamento.IsTab = false;
            this.btnPagamento.Location = new System.Drawing.Point(0, 349);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.btnPagamento.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.btnPagamento.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPagamento.selected = false;
            this.btnPagamento.Size = new System.Drawing.Size(170, 49);
            this.btnPagamento.TabIndex = 8;
            this.btnPagamento.Text = "PAGAMENTO";
            this.btnPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagamento.Textcolor = System.Drawing.Color.White;
            this.btnPagamento.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagamento.Click += new System.EventHandler(this.btnPagamento_Click_1);
            // 
            // btnOrcamento
            // 
            this.btnOrcamento.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.btnOrcamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.btnOrcamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOrcamento.BorderRadius = 0;
            this.btnOrcamento.ButtonText = "SERVIÇOS";
            this.btnOrcamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrcamento.DisabledColor = System.Drawing.Color.Gray;
            this.btnOrcamento.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOrcamento.Iconimage = global::Oficina.Properties.Resources.lista;
            this.btnOrcamento.Iconimage_right = null;
            this.btnOrcamento.Iconimage_right_Selected = null;
            this.btnOrcamento.Iconimage_Selected = null;
            this.btnOrcamento.IconMarginLeft = 0;
            this.btnOrcamento.IconMarginRight = 0;
            this.btnOrcamento.IconRightVisible = true;
            this.btnOrcamento.IconRightZoom = 0D;
            this.btnOrcamento.IconVisible = true;
            this.btnOrcamento.IconZoom = 50D;
            this.btnOrcamento.IsTab = false;
            this.btnOrcamento.Location = new System.Drawing.Point(0, 264);
            this.btnOrcamento.Name = "btnOrcamento";
            this.btnOrcamento.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.btnOrcamento.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.btnOrcamento.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOrcamento.selected = false;
            this.btnOrcamento.Size = new System.Drawing.Size(170, 49);
            this.btnOrcamento.TabIndex = 9;
            this.btnOrcamento.Text = "SERVIÇOS";
            this.btnOrcamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrcamento.Textcolor = System.Drawing.Color.White;
            this.btnOrcamento.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrcamento.Click += new System.EventHandler(this.btnOrcamento_Click_1);
            // 
            // btnCarro
            // 
            this.btnCarro.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.btnCarro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.btnCarro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCarro.BorderRadius = 0;
            this.btnCarro.ButtonText = "CARROS";
            this.btnCarro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarro.DisabledColor = System.Drawing.Color.Gray;
            this.btnCarro.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCarro.Iconimage = global::Oficina.Properties.Resources.pickup_car;
            this.btnCarro.Iconimage_right = null;
            this.btnCarro.Iconimage_right_Selected = null;
            this.btnCarro.Iconimage_Selected = null;
            this.btnCarro.IconMarginLeft = 0;
            this.btnCarro.IconMarginRight = 0;
            this.btnCarro.IconRightVisible = true;
            this.btnCarro.IconRightZoom = 0D;
            this.btnCarro.IconVisible = true;
            this.btnCarro.IconZoom = 50D;
            this.btnCarro.IsTab = false;
            this.btnCarro.Location = new System.Drawing.Point(0, 179);
            this.btnCarro.Name = "btnCarro";
            this.btnCarro.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.btnCarro.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.btnCarro.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCarro.selected = false;
            this.btnCarro.Size = new System.Drawing.Size(170, 49);
            this.btnCarro.TabIndex = 7;
            this.btnCarro.Text = "CARROS";
            this.btnCarro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarro.Textcolor = System.Drawing.Color.White;
            this.btnCarro.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarro.Click += new System.EventHandler(this.btnCarro_Click_1);
            // 
            // btnCliente
            // 
            this.btnCliente.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.btnCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCliente.BorderRadius = 0;
            this.btnCliente.ButtonText = "CLIENTES";
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.DisabledColor = System.Drawing.Color.Gray;
            this.btnCliente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCliente.Iconimage = global::Oficina.Properties.Resources.do_utilizador__1_;
            this.btnCliente.Iconimage_right = null;
            this.btnCliente.Iconimage_right_Selected = null;
            this.btnCliente.Iconimage_Selected = null;
            this.btnCliente.IconMarginLeft = 0;
            this.btnCliente.IconMarginRight = 0;
            this.btnCliente.IconRightVisible = true;
            this.btnCliente.IconRightZoom = 0D;
            this.btnCliente.IconVisible = true;
            this.btnCliente.IconZoom = 50D;
            this.btnCliente.IsTab = false;
            this.btnCliente.Location = new System.Drawing.Point(0, 94);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.btnCliente.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.btnCliente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCliente.selected = false;
            this.btnCliente.Size = new System.Drawing.Size(170, 49);
            this.btnCliente.TabIndex = 6;
            this.btnCliente.Text = "CLIENTES";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Textcolor = System.Drawing.Color.White;
            this.btnCliente.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click_1);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.headerPanel.Controls.Add(this.panel2);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(170, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(707, 22);
            this.headerPanel.TabIndex = 1;
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(675, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(32, 22);
            this.panel2.TabIndex = 49;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // bemVindoControl1
            // 
            this.bemVindoControl1.Location = new System.Drawing.Point(170, 22);
            this.bemVindoControl1.Name = "bemVindoControl1";
            this.bemVindoControl1.Size = new System.Drawing.Size(707, 497);
            this.bemVindoControl1.TabIndex = 6;
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
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FormOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 519);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.bemVindoControl1);
            this.Controls.Add(this.pagamentoControl);
            this.Controls.Add(this.orcamentoControl);
            this.Controls.Add(this.clienteControl);
            this.Controls.Add(this.carroControl);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOficina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOficina";
            this.sidePanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel headerPanel;
        private Views.carroControl carroControl;
        private Views.clienteControl clienteControl;
        private Views.servicoControl orcamentoControl;
        private Views.pagamentoControl pagamentoControl;
        private System.Windows.Forms.Panel panelSide;
        private Bunifu.Framework.UI.BunifuFlatButton btnCliente;
        private Bunifu.Framework.UI.BunifuFlatButton btnCarro;
        private Bunifu.Framework.UI.BunifuFlatButton btnPagamento;
        private Bunifu.Framework.UI.BunifuFlatButton btnOrcamento;
        private Views.bemVindoControl bemVindoControl1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}

