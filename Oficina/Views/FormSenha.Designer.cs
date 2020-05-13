namespace Oficina.Views
{
    partial class FormSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSenha));
            this.lblLogin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnEnviar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblEmail = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnVoltar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(118, 115);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(256, 39);
            this.lblLogin.TabIndex = 54;
            this.lblLogin.Text = "ESQUECI A SENHA";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 129);
            this.panel1.TabIndex = 57;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(15, 260);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(359, 20);
            this.txtEmail.TabIndex = 55;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnviar.BorderRadius = 0;
            this.btnEnviar.ButtonText = "ENVIAR";
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEnviar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEnviar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEnviar.Iconimage")));
            this.btnEnviar.Iconimage_right = null;
            this.btnEnviar.Iconimage_right_Selected = null;
            this.btnEnviar.Iconimage_Selected = null;
            this.btnEnviar.IconMarginLeft = 0;
            this.btnEnviar.IconMarginRight = 0;
            this.btnEnviar.IconRightVisible = true;
            this.btnEnviar.IconRightZoom = 0D;
            this.btnEnviar.IconVisible = true;
            this.btnEnviar.IconZoom = 90D;
            this.btnEnviar.IsTab = false;
            this.btnEnviar.Location = new System.Drawing.Point(225, 358);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.btnEnviar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.btnEnviar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEnviar.selected = false;
            this.btnEnviar.Size = new System.Drawing.Size(149, 48);
            this.btnEnviar.TabIndex = 51;
            this.btnEnviar.Text = "ENVIAR";
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviar.Textcolor = System.Drawing.Color.White;
            this.btnEnviar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(12, 244);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 14);
            this.lblEmail.TabIndex = 52;
            this.lblEmail.Text = "EMAIL:";
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
            this.headerPanel.TabIndex = 50;
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
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 14);
            this.label1.TabIndex = 60;
            this.label1.Text = "Digite seu email para recuperar sua senha";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(15, 299);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 14);
            this.lblResult.TabIndex = 61;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.btnVoltar.BackColor = System.Drawing.Color.Silver;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.BorderRadius = 0;
            this.btnVoltar.ButtonText = "VOLTAR";
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.DisabledColor = System.Drawing.Color.Gray;
            this.btnVoltar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVoltar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Iconimage")));
            this.btnVoltar.Iconimage_right = null;
            this.btnVoltar.Iconimage_right_Selected = null;
            this.btnVoltar.Iconimage_Selected = null;
            this.btnVoltar.IconMarginLeft = 0;
            this.btnVoltar.IconMarginRight = 0;
            this.btnVoltar.IconRightVisible = true;
            this.btnVoltar.IconRightZoom = 0D;
            this.btnVoltar.IconVisible = true;
            this.btnVoltar.IconZoom = 90D;
            this.btnVoltar.IsTab = false;
            this.btnVoltar.Location = new System.Drawing.Point(12, 358);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Normalcolor = System.Drawing.Color.Silver;
            this.btnVoltar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.btnVoltar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVoltar.selected = false;
            this.btnVoltar.Size = new System.Drawing.Size(149, 48);
            this.btnVoltar.TabIndex = 62;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Textcolor = System.Drawing.Color.White;
            this.btnVoltar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FormSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSenha";
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEmail;
        private Bunifu.Framework.UI.BunifuFlatButton btnEnviar;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
        private Bunifu.Framework.UI.BunifuFlatButton btnVoltar;
    }
}