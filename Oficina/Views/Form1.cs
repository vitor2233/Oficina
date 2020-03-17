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

        private void btnCliente_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnCliente.Height;
            panelSide.Top = btnCliente.Top;
            clienteControl.BringToFront();
        }

        private void btnCarro_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnCarro.Height;
            panelSide.Top = btnCarro.Top;
            carroControl.BringToFront();
        }

        private void btnOrcamento_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnOrcamento.Height;
            panelSide.Top = btnOrcamento.Top;
            orcamentoControl.BringToFront();
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnPagamento.Height;
            panelSide.Top = btnPagamento.Top;
            pagamentoControl.BringToFront();
        }
    }
}
