using Oficina.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oficina.Views
{
    public partial class FormSenha : Form
    {
        //Mover form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        LoginController login = new LoginController();
        public FormSenha()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!txtEmail.Text.Contains('@') || !txtEmail.Text.Contains('.'))
            {
                MessageBox.Show("Por favor, entre com um email válido", "Email inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Text = "";
                return;
            }

            if (login.VerifyLogin(txtEmail.Text) > 0)
            {
                //Mandar email
                MailMessage mail = new MailMessage();

                //Colocando email e senha do cliente
                string emailCliente = txtEmail.Text;
                string senhaCliente = login.RetPassword(txtEmail.Text).Rows[0]["senha"].ToString();
                //Quem vai mandar
                mail.From = new MailAddress("suporteoficinaUna@gmail.com");
                //Quem vai receber
                mail.To.Add(emailCliente);
                //Assunto
                mail.Subject = "Recuperação de senha";
                //Mensagem
                mail.Body = "Sua senha da oficina é: " + senhaCliente + " não recomendamos usar senhas em comum, não investimos em segurança. Não é possível resetar sua senha. Obrigado.";

                //Criar smtp para enviar o email
                using (var smtp = new SmtpClient("smtp.gmail.com"))
                {
                    smtp.EnableSsl = true; // GMail requer SSL
                    smtp.Port = 587;       // porta para SSL
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network; // modo de envio
                    smtp.UseDefaultCredentials = false; // utilizar credencias especificas

                    //Usuário e senha do email que irá mandar
                    smtp.Credentials = new NetworkCredential("suporteoficinaUna@gmail.com", "suporte2020");
                    //Envia o email
                    smtp.Send(mail);
                    lblResult.Text = "E-mail enviado com sucesso.";
                    txtEmail.Text = "";

                }
            }
            else
            {
                lblResult.Text = "E-mail não cadastrado no sistema";
            }
        
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin form = new FormLogin();
            form.ShowDialog();
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
    }
}
