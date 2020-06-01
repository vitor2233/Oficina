using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Controllers
{
    class OrcamentoController
    {
        public int ID_Orcamento { get; set; }

        public string TipoPagamento { get; set; }

        public string Descricao { get; set; }

        public string ValorPagamento { get; set; }

        public string DataPagamento { get; set; }

        public int Servico_ID { get; set; }

        AcessoController bd = new AcessoController();

        public bool Insert()
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("INSERT INTO tb_orcamento (tipoPagamento, descricao, valorPagamento, dataPagamento, servico_ID) VALUES ('{0}','{1}','{2}','{3}',{4})",
                    TipoPagamento, Descricao, ValorPagamento, DataPagamento, Servico_ID));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao adicionar os dados do orçamento. ");
            }

        }
        public bool Update(int codOrcamentoClicado)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("UPDATE tb_orcamento SET tipoPagamento = '{0}', descricao = '{1}', valorPagamento = '{2}', dataPagamento = '{3}', servico_ID = {4}" +
                    " WHERE ID = {5} ", TipoPagamento, Descricao, ValorPagamento, DataPagamento, Servico_ID, codOrcamentoClicado));

                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao editar os dados deste orçamento" +
                    ". ");
            }
        }
        public bool Delete(int codOrcamentoClicado)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("DELETE FROM tb_orcamento WHERE ID = {0}", codOrcamentoClicado));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao excluir os dados do orçamento. ");
            }
        }
        public DataTable Select()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM tb_orcamento"));
            bd.Desconectar();
            return dt;
        }

        public DataTable Select(string searchText)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM tb_orcamento WHERE descricao LIKE '%{0}%'", searchText));
            bd.Desconectar();
            return dt;
        }
    }
}
