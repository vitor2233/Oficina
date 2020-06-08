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
using System.Globalization;

namespace Oficina.Views
{
    public partial class pagamentoControl : UserControl
    {
        OrcamentoController orcamento = new OrcamentoController();
        ServicoController servico = new ServicoController();
        int codPagamentoClicado = 0;
        int codServicoClicado = 0;

        public pagamentoControl()
        {
            InitializeComponent();
            RetornarServicos();
            RetornarPagamentos();
        }

        private void RetornarServicos()
        {
            dgvServico.ReadOnly = true;
            dgvServico.RowHeadersVisible = false;
            dgvServico.DataSource = servico.Select();
            dgvServico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        private void RetornarPagamentos()
        {
            dgvPagamento.ReadOnly = true;
            dgvPagamento.RowHeadersVisible = false;
            dgvPagamento.DataSource = orcamento.Select();
            dgvPagamento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void CleanText()
        {
            cbxTipoPagamento.Text = "";
            txtValor.Text = "";
            mskData.Text = "";
            rtbDescricao.Text = "";
            lblServicoSelecionado.Text = "";
        }
        private void GetData()
        {
            //Pegar as informações para a inserção
            orcamento.TipoPagamento = cbxTipoPagamento.Text;
            orcamento.ValorPagamento = txtValor.Text;
            orcamento.DataPagamento = mskData.Text;
            orcamento.Descricao = rtbDescricao.Text;
            orcamento.Servico_ID = int.Parse(lblServicoSelecionado.Text);
        }
        private bool VerifyText()
        {
            if (String.IsNullOrEmpty(cbxTipoPagamento.Text) || String.IsNullOrEmpty(txtValor.Text) || String.IsNullOrEmpty(mskData.Text)
                || String.IsNullOrEmpty(rtbDescricao.Text) || String.IsNullOrEmpty(lblServicoSelecionado.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            Double value;
            if (Double.TryParse(txtValor.Text, out value))
                txtValor.Text = String.Format(CultureInfo.CurrentCulture, "{0:C2}", value);
            else
                txtValor.Text = String.Empty;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(lblServicoSelecionado.Text))
            {
                if (VerifyText())
                {
                    GetData();
                    codServicoClicado = int.Parse(lblServicoSelecionado.Text);
                    if (orcamento.VerificarServico(codServicoClicado).Rows.Count == 0)
                    {
                        if (orcamento.Insert())
                        {
                            MessageBox.Show("Pagamento cadastrado!");
                            dgvPagamento.DataSource = orcamento.Select();
                            CleanText();
                        }
                        else
                        {
                            MessageBox.Show("Erro!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Já existe um pagamento cadastrado para este serviço");
                    }

                }
                else
                {
                    MessageBox.Show("É necessário preencher todos os dados.");
                }

            }
            else
            {
                MessageBox.Show("É necessário selecionar um serviço.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (VerifyText())
            {
                GetData();
                if (orcamento.Update(codPagamentoClicado))
                {
                    MessageBox.Show("Pagamento Editado!");
                    dgvPagamento.DataSource = orcamento.Select();
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
            if (VerifyText())
            {
                GetData();
                if (codPagamentoClicado != 0)
                {
                    if (orcamento.Delete(codPagamentoClicado))
                    {
                        MessageBox.Show("Pagamento Excluido!");
                        dgvPagamento.DataSource = orcamento.Select();
                        CleanText();
                    }
                    else
                    {
                        MessageBox.Show("Erro!");
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum pagamento selecionado.");
                }
            }
            else
            {
                MessageBox.Show("Nenhum pagamento selecionado");
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RetornarServicos();
            RetornarPagamentos();
        }

        private void dgvServico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            if (dgvServico.Rows[e.RowIndex].Cells["ID"].Value.ToString() != "")
            {
                //CodClicado recebe o campo clicado
                codServicoClicado = int.Parse(dgvServico.Rows[e.RowIndex].Cells["ID"].Value.ToString());

                lblServicoSelecionado.Text = dgvServico.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            }
        }

        private void dgvPagamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            //Se clicar em algum codigo no dgv
            if (dgvPagamento.Rows[e.RowIndex].Cells["ID"].Value.ToString() != "")
            {
                //CodClicado recebe o campo clicado
                codPagamentoClicado = int.Parse(dgvPagamento.Rows[e.RowIndex].Cells["ID"].Value.ToString());

                cbxTipoPagamento.Text = dgvPagamento.Rows[e.RowIndex].Cells["tipoPagamento"].Value.ToString();
                txtValor.Text = dgvPagamento.Rows[e.RowIndex].Cells["valorPagamento"].Value.ToString();
                mskData.Text = dgvPagamento.Rows[e.RowIndex].Cells["dataPagamento"].Value.ToString();
                rtbDescricao.Text = dgvPagamento.Rows[e.RowIndex].Cells["descricao"].Value.ToString();
                lblServicoSelecionado.Text = dgvPagamento.Rows[e.RowIndex].Cells["servico_ID"].Value.ToString();
            }
        }

        private void txtPesquisaServico_TextChanged(object sender, EventArgs e)
        {
            dgvServico.DataSource = servico.Select(txtPesquisaServico.Text);
        }

        private void txtPesquisaPagamento_TextChanged(object sender, EventArgs e)
        {
            dgvPagamento.DataSource = orcamento.Select(txtPesquisaPagamento.Text);
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void mskData_Leave(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Today;
            DateTime Test;
            if (DateTime.TryParseExact(mskData.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out Test) == false)
            {
                mskData.Text = "";
                return;
            }
                

            if (Convert.ToDateTime(mskData.Text) > currentDate)
                mskData.Text = "";
        }

        private void pagamentoControl_Load(object sender, EventArgs e)
        {
            txtValor.MaxLength = 9;
        }
    }
}
