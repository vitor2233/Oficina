using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Oficina.Controllers
{
    class ClienteController
    {
        public int ID_Cliente { get; set; }

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string Bairro { get; set; }

        public string Rua { get; set; }

        public int Numero { get; set; }

        public string Complemento { get; set; }

        AcessoController bd = new AcessoController();

        public bool Insert()
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("INSERT INTO tb_cliente (nome, cpf, estado, cidade, bairro, rua, numero, complemento) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}',{6},'{7}')",
                    Nome, Cpf, Estado, Cidade, Bairro, Rua, Numero, Complemento));

                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao adicionar os dados do cliente. ");
            }

        }
        public bool Update(int codClienteClicado)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("UPDATE tb_cliente SET nome = '{0}', cpf = '{1}', estado ='{2}', cidade = '{3}', bairro = '{4}', rua = '{5}', numero = {6}, "
                    + " complemento = '{7}' WHERE ID = {8} ", Nome, Cpf, Estado, Cidade, Bairro, Rua, Numero, Complemento, codClienteClicado));
                
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao editar os dados deste cliente" +
                    ". ");
            }
        }
        public bool Delete(int codClienteClicado)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("DELETE FROM tb_cliente WHERE ID = {0}", codClienteClicado));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao excluir os dados do cliente. ");
            }
        }
        public DataTable Select()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM tb_cliente"));
            bd.Desconectar();
            return dt;
        }

        public DataTable SelectNameCpf()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT ID, nome, cpf FROM tb_cliente"));
            bd.Desconectar();
            return dt;
        }

        public DataTable VerifyCar(int codCliente)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM tb_carro WHERE cliente_ID = {0}", codCliente));
            bd.Desconectar();
            return dt;
        }
    }
}
