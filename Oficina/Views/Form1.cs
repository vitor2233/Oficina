using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oficina
{
    public partial class FormOficina : Form
    {
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
            this.Close();
        }
    }
}
