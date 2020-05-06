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

namespace Oficina.Views
{
    public partial class FormLogin : Form
    {
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            this.Close();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
