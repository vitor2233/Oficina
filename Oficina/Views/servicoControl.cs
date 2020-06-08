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
    public partial class servicoControl : UserControl
    {
        CarroController carro = new CarroController();
        ServicoController servico = new ServicoController();
        OrcamentoController orcamento = new OrcamentoController();
        int codCarroClicado = 0;
        int codServicoClicado = 0;
        public servicoControl()
        {
            InitializeComponent();
            RetornarServicos();
            RetornarCarros();
        }

        private void RetornarServicos()
        {
            dgvServico.ReadOnly = true;
            dgvServico.RowHeadersVisible = false;
            dgvServico.DataSource = servico.Select();
            dgvServico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        private void RetornarCarros()
        {
            dgvCarro.ReadOnly = true;
            dgvCarro.RowHeadersVisible = false;
            dgvCarro.DataSource = carro.Select();
            dgvCarro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void CleanText()
        {
            txtTipoServico.Text = "";
            txtTempo.Text = "";
            rtbAdicional.Text = "";
            lblCarroSelecionado.Text = "";
        }

        private bool VerifyText()
        {
            if (String.IsNullOrEmpty(txtTipoServico.Text) || String.IsNullOrEmpty(txtTempo.Text)
                || String.IsNullOrEmpty(rtbAdicional.Text) || String.IsNullOrEmpty(lblCarroSelecionado.Text))
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
            servico.TipoServico = txtTipoServico.Text;
            servico.Tempo = txtTempo.Text;
            servico.Adicional = rtbAdicional.Text;
            servico.Carro_ID = int.Parse(lblCarroSelecionado.Text);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lblCarroSelecionado.Text))
            {
                if (VerifyText())
                {
                    GetData();
                    if (servico.Insert())
                    {
                        MessageBox.Show("Serviço cadastrado!");
                        dgvServico.DataSource = servico.Select();
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
            else
            {
                MessageBox.Show("É necessário selecionar um carro.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (VerifyText())
            {
                GetData();
                if (servico.Update(codServicoClicado))
                {
                    MessageBox.Show("Serviço Editado!");
                    dgvServico.DataSource = servico.Select();
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
            if(orcamento.VerificarServico(codServicoClicado).Rows.Count == 0)
            {
                if (VerifyText())
                {
                    GetData();
                    if (codServicoClicado != 0)
                    {
                        if (servico.Delete(codServicoClicado))
                        {
                            MessageBox.Show("Serviço Excluido!");
                            dgvServico.DataSource = servico.Select();
                            CleanText();
                        }
                        else
                        {
                            MessageBox.Show("Erro!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nenhum serviço selecionado.");
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum serviço selecionado");
                }
            }
            else
            {
                MessageBox.Show("Há um pagamento cadastrado para este serviço, remova o pagamento para remover o serviço.");
            }
            
        }

        private void dgvServico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            //Se clicar em algum codigo no dgv
            if (dgvServico.Rows[e.RowIndex].Cells["ID"].Value.ToString() != "")
            {
                //CodClicado recebe o campo clicado
                codServicoClicado = int.Parse(dgvServico.Rows[e.RowIndex].Cells["ID"].Value.ToString());

                txtTipoServico.Text = dgvServico.Rows[e.RowIndex].Cells["tipoServico"].Value.ToString();
                txtTempo.Text = dgvServico.Rows[e.RowIndex].Cells["tempo"].Value.ToString();
                rtbAdicional.Text = dgvServico.Rows[e.RowIndex].Cells["adicional"].Value.ToString();
                lblCarroSelecionado.Text = dgvServico.Rows[e.RowIndex].Cells["carro_ID"].Value.ToString();
            }
        }

        private void dgvCarro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            if (dgvCarro.Rows[e.RowIndex].Cells["ID"].Value.ToString() != "")
            {
                //CodClicado recebe o campo clicado
                codCarroClicado = int.Parse(dgvCarro.Rows[e.RowIndex].Cells["ID"].Value.ToString());

                lblCarroSelecionado.Text = dgvCarro.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RetornarServicos();
            RetornarCarros();
        }
        private void txtCaractere_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void servicoControl_Load(object sender, EventArgs e)
        {
            rtbAdicional.MaxLength = 255;
            txtTipoServico.MaxLength = 60;
        }

        private void txtPesquisaCarro_TextChanged(object sender, EventArgs e)
        {
            dgvCarro.DataSource = carro.Select(txtPesquisaCarro.Text);
        }

        private void txtPesquisaServico_TextChanged(object sender, EventArgs e)
        {
            dgvServico.DataSource = servico.Select(txtPesquisaServico.Text);
        }
    }
}
