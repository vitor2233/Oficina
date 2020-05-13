namespace Oficina.Views
{
    partial class clienteControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clienteControl));
            this.lblRua = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.dgvClientes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnCadastrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExcluir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.pnlPesquisa = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.Location = new System.Drawing.Point(337, 36);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(32, 14);
            this.lblRua.TabIndex = 30;
            this.lblRua.Text = "RUA:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(337, 95);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(50, 14);
            this.lblBairro.TabIndex = 29;
            this.lblBairro.Text = "BAIRRO:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(228, 36);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(28, 14);
            this.lblCpf.TabIndex = 26;
            this.lblCpf.Text = "CPF:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(13, 36);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(42, 14);
            this.lblNome.TabIndex = 25;
            this.lblNome.Text = "NOME:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(13, 95);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 14);
            this.lblEstado.TabIndex = 27;
            this.lblEstado.Text = "ESTADO:";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(13, 154);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(49, 14);
            this.lblCidade.TabIndex = 28;
            this.lblCidade.Text = "CIDADE:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(555, 36);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(57, 14);
            this.lblNumero.TabIndex = 31;
            this.lblNumero.Text = "NÚMERO:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.Location = new System.Drawing.Point(337, 154);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(89, 14);
            this.lblComplemento.TabIndex = 32;
            this.lblComplemento.Text = "COMPLEMENTO:";
            // 
            // dgvClientes
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.DoubleBuffered = true;
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.dgvClientes.HeaderForeColor = System.Drawing.Color.White;
            this.dgvClientes.Location = new System.Drawing.Point(27, 335);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.Size = new System.Drawing.Size(647, 159);
            this.dgvClientes.TabIndex = 42;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrar.BorderRadius = 0;
            this.btnCadastrar.ButtonText = "CADASTRAR";
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.DisabledColor = System.Drawing.Color.Gray;
            this.btnCadastrar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCadastrar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Iconimage")));
            this.btnCadastrar.Iconimage_right = null;
            this.btnCadastrar.Iconimage_right_Selected = null;
            this.btnCadastrar.Iconimage_Selected = null;
            this.btnCadastrar.IconMarginLeft = 0;
            this.btnCadastrar.IconMarginRight = 0;
            this.btnCadastrar.IconRightVisible = true;
            this.btnCadastrar.IconRightZoom = 0D;
            this.btnCadastrar.IconVisible = true;
            this.btnCadastrar.IconZoom = 90D;
            this.btnCadastrar.IsTab = false;
            this.btnCadastrar.Location = new System.Drawing.Point(7, 224);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.btnCadastrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.btnCadastrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCadastrar.selected = false;
            this.btnCadastrar.Size = new System.Drawing.Size(149, 48);
            this.btnCadastrar.TabIndex = 43;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Textcolor = System.Drawing.Color.White;
            this.btnCadastrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.BorderRadius = 0;
            this.btnEditar.ButtonText = "EDITAR";
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditar.Iconimage")));
            this.btnEditar.Iconimage_right = null;
            this.btnEditar.Iconimage_right_Selected = null;
            this.btnEditar.Iconimage_Selected = null;
            this.btnEditar.IconMarginLeft = 0;
            this.btnEditar.IconMarginRight = 0;
            this.btnEditar.IconRightVisible = true;
            this.btnEditar.IconRightZoom = 0D;
            this.btnEditar.IconVisible = true;
            this.btnEditar.IconZoom = 90D;
            this.btnEditar.IsTab = false;
            this.btnEditar.Location = new System.Drawing.Point(273, 224);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.btnEditar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.btnEditar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditar.selected = false;
            this.btnEditar.Size = new System.Drawing.Size(149, 48);
            this.btnEditar.TabIndex = 44;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Textcolor = System.Drawing.Color.White;
            this.btnEditar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.BorderRadius = 0;
            this.btnExcluir.ButtonText = "EXCLUIR";
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.DisabledColor = System.Drawing.Color.Gray;
            this.btnExcluir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExcluir.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Iconimage")));
            this.btnExcluir.Iconimage_right = null;
            this.btnExcluir.Iconimage_right_Selected = null;
            this.btnExcluir.Iconimage_Selected = null;
            this.btnExcluir.IconMarginLeft = 0;
            this.btnExcluir.IconMarginRight = 0;
            this.btnExcluir.IconRightVisible = true;
            this.btnExcluir.IconRightZoom = 0D;
            this.btnExcluir.IconVisible = true;
            this.btnExcluir.IconZoom = 90D;
            this.btnExcluir.IsTab = false;
            this.btnExcluir.Location = new System.Drawing.Point(539, 224);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.btnExcluir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.btnExcluir.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExcluir.selected = false;
            this.btnExcluir.Size = new System.Drawing.Size(149, 48);
            this.btnExcluir.TabIndex = 45;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Textcolor = System.Drawing.Color.White;
            this.btnExcluir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(13, 53);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(209, 20);
            this.txtNome.TabIndex = 46;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(231, 53);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(85, 20);
            this.txtCpf.TabIndex = 48;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(13, 112);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(209, 20);
            this.txtEstado.TabIndex = 49;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(13, 171);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(209, 20);
            this.txtCidade.TabIndex = 50;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(340, 112);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(209, 20);
            this.txtBairro.TabIndex = 51;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(340, 53);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(209, 20);
            this.txtRua.TabIndex = 52;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(558, 53);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(85, 20);
            this.txtNumero.TabIndex = 53;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress_1);
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(340, 171);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(209, 20);
            this.txtComplemento.TabIndex = 54;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(7, 309);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(104, 20);
            this.txtPesquisa.TabIndex = 55;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // pnlPesquisa
            // 
            this.pnlPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPesquisa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPesquisa.BackgroundImage")));
            this.pnlPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlPesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlPesquisa.Location = new System.Drawing.Point(117, 309);
            this.pnlPesquisa.Name = "pnlPesquisa";
            this.pnlPesquisa.Size = new System.Drawing.Size(21, 20);
            this.pnlPesquisa.TabIndex = 64;
            // 
            // clienteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlPesquisa);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNome);
            this.Name = "clienteControl";
            this.Size = new System.Drawing.Size(707, 497);
            this.Load += new System.EventHandler(this.clienteControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblComplemento;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvClientes;
        private Bunifu.Framework.UI.BunifuFlatButton btnCadastrar;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditar;
        private Bunifu.Framework.UI.BunifuFlatButton btnExcluir;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Panel pnlPesquisa;
    }
}
