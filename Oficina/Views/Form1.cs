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
            clienteControl.BringToFront();
        }

        private void btnCarro_Click(object sender, EventArgs e)
        {
            carroControl.BringToFront();
        }

        private void btnOrcamento_Click(object sender, EventArgs e)
        {
            orcamentoControl.BringToFront();
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            pagamentoControl.BringToFront();
        }
    }
}
