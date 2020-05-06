namespace Oficina.Views
{
    partial class carroControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(carroControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblChassi = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnExcluir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCadastrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvCliente = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dgvCarro = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lblClienteSelecionado = new System.Windows.Forms.Label();
            this.lblQuilometragem = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Panel();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.txtChassi = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(10, 30);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(48, 13);
            this.lblMarca.TabIndex = 9;
            this.lblMarca.Text = "MARCA:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(10, 83);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(44, 13);
            this.lblPlaca.TabIndex = 10;
            this.lblPlaca.Text = "PLACA:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(372, 30);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(56, 13);
            this.lblModelo.TabIndex = 13;
            this.lblModelo.Text = "MODELO:";
            // 
            // lblChassi
            // 
            this.lblChassi.AutoSize = true;
            this.lblChassi.Location = new System.Drawing.Point(129, 83);
            this.lblChassi.Name = "lblChassi";
            this.lblChassi.Size = new System.Drawing.Size(49, 13);
            this.lblChassi.TabIndex = 14;
            this.lblChassi.Text = "CHASSI:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(-1, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(55, 13);
            this.lblCliente.TabIndex = 16;
            this.lblCliente.Text = "CLIENTE:";
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
            this.btnExcluir.Location = new System.Drawing.Point(545, 224);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.btnExcluir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.btnExcluir.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExcluir.selected = false;
            this.btnExcluir.Size = new System.Drawing.Size(149, 48);
            this.btnExcluir.TabIndex = 48;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Textcolor = System.Drawing.Color.White;
            this.btnExcluir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
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
            this.btnEditar.Location = new System.Drawing.Point(279, 224);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.btnEditar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.btnEditar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditar.selected = false;
            this.btnEditar.Size = new System.Drawing.Size(149, 48);
            this.btnEditar.TabIndex = 47;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Textcolor = System.Drawing.Color.White;
            this.btnEditar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.btnCadastrar.Location = new System.Drawing.Point(13, 224);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.btnCadastrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.btnCadastrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCadastrar.selected = false;
            this.btnCadastrar.Size = new System.Drawing.Size(149, 48);
            this.btnCadastrar.TabIndex = 46;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Textcolor = System.Drawing.Color.White;
            this.btnCadastrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dgvCliente
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.DoubleBuffered = true;
            this.dgvCliente.EnableHeadersVisualStyles = false;
            this.dgvCliente.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.dgvCliente.HeaderForeColor = System.Drawing.Color.White;
            this.dgvCliente.Location = new System.Drawing.Point(13, 335);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCliente.Size = new System.Drawing.Size(149, 159);
            this.dgvCliente.TabIndex = 49;
            this.dgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellClick);
            // 
            // dgvCarro
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCarro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCarro.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvCarro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCarro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCarro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarro.DoubleBuffered = true;
            this.dgvCarro.EnableHeadersVisualStyles = false;
            this.dgvCarro.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.dgvCarro.HeaderForeColor = System.Drawing.Color.White;
            this.dgvCarro.Location = new System.Drawing.Point(202, 335);
            this.dgvCarro.Name = "dgvCarro";
            this.dgvCarro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarro.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCarro.Size = new System.Drawing.Size(492, 159);
            this.dgvCarro.TabIndex = 50;
            this.dgvCarro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarro_CellClick);
            // 
            // lblClienteSelecionado
            // 
            this.lblClienteSelecionado.AutoSize = true;
            this.lblClienteSelecionado.Location = new System.Drawing.Point(60, 0);
            this.lblClienteSelecionado.Name = "lblClienteSelecionado";
            this.lblClienteSelecionado.Size = new System.Drawing.Size(0, 13);
            this.lblClienteSelecionado.TabIndex = 52;
            // 
            // lblQuilometragem
            // 
            this.lblQuilometragem.AutoSize = true;
            this.lblQuilometragem.Location = new System.Drawing.Point(402, 83);
            this.lblQuilometragem.Name = "lblQuilometragem";
            this.lblQuilometragem.Size = new System.Drawing.Size(26, 13);
            this.lblQuilometragem.TabIndex = 53;
            this.lblQuilometragem.Text = "KM:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.Location = new System.Drawing.Point(166, 335);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(32, 33);
            this.btnRefresh.TabIndex = 55;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(65, 23);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(239, 20);
            this.txtMarca.TabIndex = 56;
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(434, 76);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(241, 20);
            this.txtKm.TabIndex = 57;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(434, 23);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(241, 20);
            this.txtModelo.TabIndex = 58;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(65, 76);
            this.txtPlaca.Mask = "LLL-0000";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(57, 20);
            this.txtPlaca.TabIndex = 59;
            // 
            // txtChassi
            // 
            this.txtChassi.Location = new System.Drawing.Point(184, 76);
            this.txtChassi.Mask = "0LL&&&&&L00000000";
            this.txtChassi.Name = "txtChassi";
            this.txtChassi.Size = new System.Drawing.Size(120, 20);
            this.txtChassi.TabIndex = 60;
            // 
            // carroControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtChassi);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblQuilometragem);
            this.Controls.Add(this.lblClienteSelecionado);
            this.Controls.Add(this.dgvCarro);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblChassi);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblMarca);
            this.Name = "carroControl";
            this.Size = new System.Drawing.Size(707, 497);
            this.Load += new System.EventHandler(this.carroControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblChassi;
        private System.Windows.Forms.Label lblCliente;
        private Bunifu.Framework.UI.BunifuFlatButton btnExcluir;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditar;
        private Bunifu.Framework.UI.BunifuFlatButton btnCadastrar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvCliente;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvCarro;
        private System.Windows.Forms.Label lblClienteSelecionado;
        private System.Windows.Forms.Label lblQuilometragem;
        private System.Windows.Forms.Panel btnRefresh;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
        private System.Windows.Forms.MaskedTextBox txtChassi;
    }
}
