namespace Oficina.Views
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnEntrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblEsqueceuSenha = new System.Windows.Forms.Label();
            this.lblEsqueceuSenhaClick = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.headerPanel.Controls.Add(this.panel2);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.headerPanel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(386, 22);
            this.headerPanel.TabIndex = 2;
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
            this.panel2.Location = new System.Drawing.Point(354, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(32, 22);
            this.panel2.TabIndex = 48;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(10, 273);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(45, 14);
            this.lblSenha.TabIndex = 41;
            this.lblSenha.Text = "SENHA:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(12, 180);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 14);
            this.lblEmail.TabIndex = 40;
            this.lblEmail.Text = "EMAIL:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(118, 106);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(99, 39);
            this.lblLogin.TabIndex = 44;
            this.lblLogin.Text = "LOGIN";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.btnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEntrar.BorderRadius = 0;
            this.btnEntrar.ButtonText = "ENTRAR";
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEntrar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEntrar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEntrar.Iconimage")));
            this.btnEntrar.Iconimage_right = null;
            this.btnEntrar.Iconimage_right_Selected = null;
            this.btnEntrar.Iconimage_Selected = null;
            this.btnEntrar.IconMarginLeft = 0;
            this.btnEntrar.IconMarginRight = 0;
            this.btnEntrar.IconRightVisible = true;
            this.btnEntrar.IconRightZoom = 0D;
            this.btnEntrar.IconVisible = true;
            this.btnEntrar.IconZoom = 90D;
            this.btnEntrar.IsTab = false;
            this.btnEntrar.Location = new System.Drawing.Point(107, 348);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.btnEntrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.btnEntrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEntrar.selected = false;
            this.btnEntrar.Size = new System.Drawing.Size(149, 48);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntrar.Textcolor = System.Drawing.Color.White;
            this.btnEntrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(15, 196);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(359, 20);
            this.txtEmail.TabIndex = 45;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(12, 289);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(359, 20);
            this.txtSenha.TabIndex = 46;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 129);
            this.panel1.TabIndex = 47;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblEsqueceuSenha
            // 
            this.lblEsqueceuSenha.AutoSize = true;
            this.lblEsqueceuSenha.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsqueceuSenha.Location = new System.Drawing.Point(8, 418);
            this.lblEsqueceuSenha.Name = "lblEsqueceuSenha";
            this.lblEsqueceuSenha.Size = new System.Drawing.Size(125, 14);
            this.lblEsqueceuSenha.TabIndex = 48;
            this.lblEsqueceuSenha.Text = "Esqueceu sua senha?";
            // 
            // lblEsqueceuSenhaClick
            // 
            this.lblEsqueceuSenhaClick.AutoSize = true;
            this.lblEsqueceuSenhaClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEsqueceuSenhaClick.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsqueceuSenhaClick.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblEsqueceuSenhaClick.Location = new System.Drawing.Point(128, 417);
            this.lblEsqueceuSenhaClick.Name = "lblEsqueceuSenhaClick";
            this.lblEsqueceuSenhaClick.Size = new System.Drawing.Size(71, 15);
            this.lblEsqueceuSenhaClick.TabIndex = 49;
            this.lblEsqueceuSenhaClick.Text = "Venha aqui!";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 450);
            this.Controls.Add(this.lblEsqueceuSenhaClick);
            this.Controls.Add(this.lblEsqueceuSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLogin;
        private Bunifu.Framework.UI.BunifuFlatButton btnEntrar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lblEsqueceuSenhaClick;
        private System.Windows.Forms.Label lblEsqueceuSenha;
    }
}