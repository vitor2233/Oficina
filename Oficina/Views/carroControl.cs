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
        ServicoController servico = new ServicoController();
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
            dgvCliente.RowHeadersVisible = false;
            dgvCliente.DataSource = cliente.SelectNameCpf();
            dgvCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        private void ReturnCars()
        {
            dgvCarro.RowHeadersVisible = false;
            dgvCarro.DataSource = carro.Select();
            dgvCarro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        private bool VerifyText()
        {
            if (String.IsNullOrEmpty(txtMarca.Text) || String.IsNullOrEmpty(txtPlaca.Text)
                || String.IsNullOrEmpty(txtModelo.Text) || String.IsNullOrEmpty(txtChassi.Text)
                || String.IsNullOrEmpty(txtKm.Text) || String.IsNullOrEmpty(lblClienteSelecionado.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
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
            txtKm.MaxLength = 6;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ReturnCustomers();
            ReturnCars();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lblClienteSelecionado.Text))
            {
                if (VerifyText())
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
                else
                {
                    MessageBox.Show("É necessário preencher todos os dados.");
                }

            }
            else
            {
                MessageBox.Show("É necessário selecionar um cliente.");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (VerifyText())
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
            else
            {
                MessageBox.Show("É necessário preencher todos os dados.");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (servico.VerificarCarro(codCarroClicado).Rows.Count == 0)
            {
                GetData();
                if (codCarroClicado != 0)
                {
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
                else
                {
                    MessageBox.Show("Nenhum carro selecionado.");
                }
            }
            else
            {
                MessageBox.Show("Há um serviço cadastrado para este carro, remova o serviço para remover o carro.");
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

        private void txtKm_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPesquisaCarro_TextChanged(object sender, EventArgs e)
        {
            dgvCarro.DataSource = carro.Select(txtPesquisaCarro.Text);
        }

        private void txtPesquisaCliente_TextChanged(object sender, EventArgs e)
        {
            dgvCliente.DataSource = cliente.SelectNameCpf(txtPesquisaCliente.Text);
        }
    }
}
