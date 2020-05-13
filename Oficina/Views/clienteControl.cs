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
    public partial class clienteControl : UserControl
    {
        ClienteController cliente = new ClienteController();
        int codClienteClicado = 0;

        public clienteControl()
        {
            InitializeComponent();
            ReturnCustomers();
        }

        private void GetData()
        {
            //Pegar as informações para a inserção
            cliente.Nome = txtNome.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.Estado = txtEstado.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.Rua = txtRua.Text;
            cliente.Numero = int.Parse(txtNumero.Text);
            cliente.Complemento = txtComplemento.Text;
        }
        private void CleanText()
        {
            txtNome.Text = "";
            txtCpf.Text = "";
            txtEstado.Text = "";
            txtCidade.Text = "";
            txtBairro.Text = "";
            txtRua.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
        }
        private bool verifyCodCliente()
        {
            if (codClienteClicado == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool VerifyText()
        {
            if (String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(txtCpf.Text)
                || String.IsNullOrEmpty(txtEstado.Text) || String.IsNullOrEmpty(txtCidade.Text)
                || String.IsNullOrEmpty(txtBairro.Text) || String.IsNullOrEmpty(txtRua.Text)
                || String.IsNullOrEmpty(txtNumero.Text) || String.IsNullOrEmpty(txtComplemento.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ReturnCustomers()
        {
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.DataSource = cliente.Select();
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            //Se clicar em algum codigo no dgv
            if (dgvClientes.Rows[e.RowIndex].Cells["ID"].Value.ToString() != "")
            {
                //CodClicado recebe o campo clicado
                codClienteClicado = int.Parse(dgvClientes.Rows[e.RowIndex].Cells["ID"].Value.ToString());

                txtNome.Text = dgvClientes.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                txtCpf.Text = dgvClientes.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
                txtEstado.Text = dgvClientes.Rows[e.RowIndex].Cells["estado"].Value.ToString();
                txtCidade.Text = dgvClientes.Rows[e.RowIndex].Cells["cidade"].Value.ToString();
                txtBairro.Text = dgvClientes.Rows[e.RowIndex].Cells["bairro"].Value.ToString();
                txtRua.Text = dgvClientes.Rows[e.RowIndex].Cells["rua"].Value.ToString();
                txtNumero.Text = dgvClientes.Rows[e.RowIndex].Cells["numero"].Value.ToString();
                txtComplemento.Text = dgvClientes.Rows[e.RowIndex].Cells["complemento"].Value.ToString();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (VerifyText())
            {
                GetData();
                if (cliente.Insert())
                {
                    MessageBox.Show("Cliente cadastrado!");
                    dgvClientes.DataSource = cliente.Select();
                    CleanText();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!verifyCodCliente())
            {
                MessageBox.Show("É necessário selecionar um cliente");
                return;
            }

            if (VerifyText())
            {
                GetData();
                if (cliente.Update(codClienteClicado))
                {
                    MessageBox.Show("Cliente Editado!");
                    dgvClientes.DataSource = cliente.Select();
                    CleanText();
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
            if(!verifyCodCliente())
            {
                MessageBox.Show("É necessário selecionar um cliente");
                return;
            }

            if(codClienteClicado != 0)
            {
                if (cliente.VerifyCar(codClienteClicado).Rows.Count == 0)
                {
                    GetData();
                    if (cliente.Delete(codClienteClicado))
                    {
                        MessageBox.Show("Cliente Excluido!");
                        dgvClientes.DataSource = cliente.Select();
                        CleanText();
                    }
                    else
                    {
                        MessageBox.Show("Erro!");
                    }
                }
                else
                {
                    MessageBox.Show("Há um carro cadastrado para este cliente, remova o carro para remover o cliente.");
                }
            }
            else
            {
                MessageBox.Show("É necessário selecionar um cliente");
            }


        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void clienteControl_Load(object sender, EventArgs e)
        {
            txtNumero.MaxLength = 5;
        }

        private void txtNumero_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dgvClientes.DataSource = cliente.Select(txtPesquisa.Text);
        }
    }
}
