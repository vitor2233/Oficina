using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oficina.Controllers;

namespace Oficina.Views
{
    public partial class carroControl : UserControl
    {
        CarroController carro = new CarroController();
        ClienteController cliente = new ClienteController();
        int codCarroClicado = 0;
        int codClienteClicado = 0;
        public carroControl()
        {
            InitializeComponent();
            ReturnCustomers();
            ReturnCars();
        }

        private void ReturnCustomers()
        {
            dgvCliente.DataSource = cliente.SelectNameCpf();
            dgvCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        private void ReturnCars()
        {
            dgvCarro.DataSource = carro.Select();
            dgvCarro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void GetData()
        {
            //Pegar as informações para a inserção
            carro.Marca = txtMarca.Text;
            carro.Placa = txtPlaca.Text;
            carro.Modelo = txtModelo.Text;
            carro.Chassi = txtChassi.Text;
            carro.Quilometragem = txtKm.Text;
            carro.Cliente_ID = lblClienteSelecionado.Text;
        }

        private void carroControl_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ReturnCustomers();
            ReturnCars();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            GetData();
            if (carro.Insert())
            {
                MessageBox.Show("Carro cadastrado!");
                dgvCarro.DataSource = carro.Select();
            }
            else
            {
                MessageBox.Show("Erro!");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            GetData();
            if (carro.Update(codCarroClicado))
            {
                MessageBox.Show("Carro Editado!");
                dgvCarro.DataSource = carro.Select();
            }
            else
            {
                MessageBox.Show("Erro!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            GetData();
            if (carro.Delete(codCarroClicado))
            {
                MessageBox.Show("Carro Excluido!");
                dgvCarro.DataSource = carro.Select();
            }
            else
            {
                MessageBox.Show("Erro!");
            }
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            if (dgvCliente.Rows[e.RowIndex].Cells["ID"].Value.ToString() != "")
            {
                //CodClicado recebe o campo clicado
                codClienteClicado = int.Parse(dgvCliente.Rows[e.RowIndex].Cells["ID"].Value.ToString());

                lblClienteSelecionado.Text = dgvCliente.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            }
        }

        private void dgvCarro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            //Se clicar em algum codigo no dgv
            if (dgvCarro.Rows[e.RowIndex].Cells["ID"].Value.ToString() != "")
            {
                //CodClicado recebe o campo clicado
                codCarroClicado = int.Parse(dgvCarro.Rows[e.RowIndex].Cells["ID"].Value.ToString());

                txtMarca.Text = dgvCarro.Rows[e.RowIndex].Cells["marca"].Value.ToString();
                txtPlaca.Text = dgvCarro.Rows[e.RowIndex].Cells["placa"].Value.ToString();
                txtModelo.Text = dgvCarro.Rows[e.RowIndex].Cells["modelo"].Value.ToString();
                txtChassi.Text = dgvCarro.Rows[e.RowIndex].Cells["chassi"].Value.ToString();
                txtKm.Text = dgvCarro.Rows[e.RowIndex].Cells["quilometragem"].Value.ToString();
                lblClienteSelecionado.Text = dgvCarro.Rows[e.RowIndex].Cells["cliente_ID"].Value.ToString();
            }
        }
    }
}
