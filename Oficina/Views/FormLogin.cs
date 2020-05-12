using Oficina.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Oficina.Views
{
    public partial class FormLogin : Form
    {
        //Mover form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        LoginController login = new LoginController();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            login.Email = txtEmail.Text;
            login.Senha = txtSenha.Text;

            DataTable dt = login.Login();

            if (dt.Rows.Count > 0)
            {
                this.Hide();
                FormOficina form = new FormOficina();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.");
                txtEmail.Text = "";
                txtSenha.Text = "";
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void headerPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar_Click(sender, e);
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar_Click(sender, e);
            }
        }

        private void lblEsqueceuSenhaClick_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSenha form = new FormSenha();
            form.ShowDialog();
            this.Close();
        }
    }
}
