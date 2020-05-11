using Oficina.Views;
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

namespace Oficina
{
    public partial class FormOficina : Form
    {
        //Mover form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public FormOficina()
        {
            InitializeComponent();
        }

        private void btnCliente_Click_1(object sender, EventArgs e)
        {
            panelSide.Height = btnCliente.Height - 1;
            panelSide.Top = btnCliente.Top;
            clienteControl.BringToFront();
        }

        private void btnCarro_Click_1(object sender, EventArgs e)
        {
            panelSide.Height = btnCarro.Height - 1;
            panelSide.Top = btnCarro.Top;
            carroControl.BringToFront();
        }

        private void btnOrcamento_Click_1(object sender, EventArgs e)
        {
            panelSide.Height = btnOrcamento.Height - 1;
            panelSide.Top = btnOrcamento.Top;
            orcamentoControl.BringToFront();
        }

        private void btnPagamento_Click_1(object sender, EventArgs e)
        {
            panelSide.Height = btnPagamento.Height - 1;
            panelSide.Top = btnPagamento.Top;
            pagamentoControl.BringToFront();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
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
