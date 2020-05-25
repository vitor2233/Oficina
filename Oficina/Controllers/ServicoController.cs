using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Controllers
{
    class ServicoController
    {
        public int ID_Servico { get; set; }

        public string TipoServico { get; set; }

        public string Tempo { get; set; }

        public string Adicional { get; set; }

        public int Carro_ID { get; set; }

        AcessoController bd = new AcessoController();

        public bool Insert()
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("INSERT INTO tb_servico (tipoServico, tempo, adicional, carro_ID) VALUES ('{0}','{1}','{2}',{3})",
                    TipoServico, Tempo, Adicional, Carro_ID));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao adicionar os dados do serviço. ");
            }

        }
        public bool Update(int codServicoClicado)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("UPDATE tb_servico SET tipoServico = '{0}', tempo = '{1}', adicional ='{2}', carro_ID = {3}" +
                    " WHERE ID = {4} ", TipoServico, Tempo, Adicional, Carro_ID, codServicoClicado));

                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao editar os dados deste serviço" +
                    ". ");
            }
        }
        public bool Delete(int codServicoClicado)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("DELETE FROM tb_servico WHERE ID = {0}", codServicoClicado));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao excluir os dados do serviço. ");
            }
        }
        public DataTable Select()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM tb_servico"));
            bd.Desconectar();
            return dt;
        }

        public DataTable Select(string searchText)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM tb_servico WHERE tipoServico LIKE '%{0}%'", searchText));
            bd.Desconectar();
            return dt;
        }

        public DataTable VerificarCarro(int codCarro)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM tb_servico WHERE carro_ID = {0}", codCarro));
            bd.Desconectar();
            return dt;
        }
    }
}
