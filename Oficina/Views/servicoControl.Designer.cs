namespace Oficina.Views
{
    partial class servicoControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(servicoControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtPesquisaServico = new System.Windows.Forms.TextBox();
            this.txtPesquisaCarro = new System.Windows.Forms.TextBox();
            this.txtTempo = new System.Windows.Forms.MaskedTextBox();
            this.txtTipoServico = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Panel();
            this.lblCarroSelecionado = new System.Windows.Forms.Label();
            this.dgvServico = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dgvCarro = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnExcluir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCadastrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblCarro = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.lblTipoServico = new System.Windows.Forms.Label();
            this.lblAdicional = new System.Windows.Forms.Label();
            this.rtbAdicional = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarro)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisaServico
            // 
            this.txtPesquisaServico.Location = new System.Drawing.Point(204, 311);
            this.txtPesquisaServico.Name = "txtPesquisaServico";
            this.txtPesquisaServico.Size = new System.Drawing.Size(104, 20);
            this.txtPesquisaServico.TabIndex = 84;
            this.txtPesquisaServico.TextChanged += new System.EventHandler(this.txtPesquisaServico_TextChanged);
            // 
            // txtPesquisaCarro
            // 
            this.txtPesquisaCarro.Location = new System.Drawing.Point(9, 311);
            this.txtPesquisaCarro.Name = "txtPesquisaCarro";
            this.txtPesquisaCarro.Size = new System.Drawing.Size(104, 20);
            this.txtPesquisaCarro.TabIndex = 83;
            this.txtPesquisaCarro.TextChanged += new System.EventHandler(this.txtPesquisaCarro_TextChanged);
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(15, 134);
            this.txtTempo.Mask = "00:00";
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(57, 20);
            this.txtTempo.TabIndex = 2;
            this.txtTempo.ValidatingType = typeof(System.DateTime);
            // 
            // txtTipoServico
            // 
            this.txtTipoServico.Location = new System.Drawing.Point(15, 55);
            this.txtTipoServico.Name = "txtTipoServico";
            this.txtTipoServico.Size = new System.Drawing.Size(201, 20);
            this.txtTipoServico.TabIndex = 1;
            this.txtTipoServico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaractere_KeyPress);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Location = new System.Drawing.Point(164, 337);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(34, 33);
            this.btnRefresh.TabIndex = 77;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblCarroSelecionado
            // 
            this.lblCarroSelecionado.AutoSize = true;
            this.lblCarroSelecionado.Location = new System.Drawing.Point(62, 2);
            this.lblCarroSelecionado.Name = "lblCarroSelecionado";
            this.lblCarroSelecionado.Size = new System.Drawing.Size(0, 13);
            this.lblCarroSelecionado.TabIndex = 75;
            // 
            // dgvServico
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvServico.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvServico.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvServico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvServico.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServico.DoubleBuffered = true;
            this.dgvServico.EnableHeadersVisualStyles = false;
            this.dgvServico.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.dgvServico.HeaderForeColor = System.Drawing.Color.White;
            this.dgvServico.Location = new System.Drawing.Point(204, 337);
            this.dgvServico.Name = "dgvServico";
            this.dgvServico.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServico.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvServico.Size = new System.Drawing.Size(486, 159);
            this.dgvServico.TabIndex = 74;
            this.dgvServico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServico_CellClick);
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
            this.dgvCarro.Location = new System.Drawing.Point(9, 337);
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
            this.dgvCarro.Size = new System.Drawing.Size(149, 159);
            this.dgvCarro.TabIndex = 73;
            this.dgvCarro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarro_CellClick);
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
            this.btnExcluir.Location = new System.Drawing.Point(541, 226);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.btnExcluir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.btnExcluir.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExcluir.selected = false;
            this.btnExcluir.Size = new System.Drawing.Size(149, 48);
            this.btnExcluir.TabIndex = 6;
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
            this.btnEditar.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnEditar.Location = new System.Drawing.Point(275, 226);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.btnEditar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.btnEditar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditar.selected = false;
            this.btnEditar.Size = new System.Drawing.Size(149, 48);
            this.btnEditar.TabIndex = 5;
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
            this.btnCadastrar.Location = new System.Drawing.Point(9, 226);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(130)))), ((int)(((byte)(13)))));
            this.btnCadastrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.btnCadastrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCadastrar.selected = false;
            this.btnCadastrar.Size = new System.Drawing.Size(149, 48);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Textcolor = System.Drawing.Color.White;
            this.btnCadastrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblCarro
            // 
            this.lblCarro.AutoSize = true;
            this.lblCarro.Location = new System.Drawing.Point(1, 2);
            this.lblCarro.Name = "lblCarro";
            this.lblCarro.Size = new System.Drawing.Size(48, 13);
            this.lblCarro.TabIndex = 69;
            this.lblCarro.Text = "CARRO:";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(12, 117);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(46, 14);
            this.lblTempo.TabIndex = 66;
            this.lblTempo.Text = "TEMPO:";
            // 
            // lblTipoServico
            // 
            this.lblTipoServico.AutoSize = true;
            this.lblTipoServico.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoServico.Location = new System.Drawing.Point(15, 38);
            this.lblTipoServico.Name = "lblTipoServico";
            this.lblTipoServico.Size = new System.Drawing.Size(100, 14);
            this.lblTipoServico.TabIndex = 65;
            this.lblTipoServico.Text = "TIPO DO SERVIÇO:";
            // 
            // lblAdicional
            // 
            this.lblAdicional.AutoSize = true;
            this.lblAdicional.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicional.Location = new System.Drawing.Point(272, 38);
            this.lblAdicional.Name = "lblAdicional";
            this.lblAdicional.Size = new System.Drawing.Size(67, 14);
            this.lblAdicional.TabIndex = 87;
            this.lblAdicional.Text = "ADICIONAL:";
            // 
            // rtbAdicional
            // 
            this.rtbAdicional.Location = new System.Drawing.Point(275, 55);
            this.rtbAdicional.Name = "rtbAdicional";
            this.rtbAdicional.Size = new System.Drawing.Size(415, 99);
            this.rtbAdicional.TabIndex = 3;
            this.rtbAdicional.Text = "";
            // 
            // servicoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtbAdicional);
            this.Controls.Add(this.lblAdicional);
            this.Controls.Add(this.txtPesquisaServico);
            this.Controls.Add(this.txtPesquisaCarro);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.txtTipoServico);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblCarroSelecionado);
            this.Controls.Add(this.dgvServico);
            this.Controls.Add(this.dgvCarro);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblCarro);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.lblTipoServico);
            this.Name = "servicoControl";
            this.Size = new System.Drawing.Size(707, 497);
            this.Load += new System.EventHandler(this.servicoControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPesquisaServico;
        private System.Windows.Forms.TextBox txtPesquisaCarro;
        private System.Windows.Forms.MaskedTextBox txtTempo;
        private System.Windows.Forms.TextBox txtTipoServico;
        private System.Windows.Forms.Panel btnRefresh;
        private System.Windows.Forms.Label lblCarroSelecionado;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvServico;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvCarro;
        private Bunifu.Framework.UI.BunifuFlatButton btnExcluir;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditar;
        private Bunifu.Framework.UI.BunifuFlatButton btnCadastrar;
        private System.Windows.Forms.Label lblCarro;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label lblTipoServico;
        private System.Windows.Forms.Label lblAdicional;
        private System.Windows.Forms.RichTextBox rtbAdicional;
    }
}
