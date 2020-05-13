using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Controllers
{
    class CarroController
    {
        public int ID_Carro { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Placa { get; set; }

        public string Quilometragem { get; set; }

        public string Chassi { get; set; }

        public string Cliente_ID { get; set; }

        AcessoController bd = new AcessoController();

        public bool Insert()
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("INSERT INTO tb_carro (marca, modelo, placa, quilometragem, chassi, cliente_ID) VALUES ('{0}','{1}','{2}','{3}','{4}',{5})",
                    Marca, Modelo, Placa, Quilometragem, Chassi, Cliente_ID));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao adicionar os dados do carro. ");
            }

        }
        public bool Update(int codCarroClicado)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("UPDATE tb_carro SET marca = '{0}', modelo = '{1}', placa ='{2}', quilometragem = '{3}', chassi = '{4}', cliente_ID = '{5}'" +
                    " WHERE ID = {6} ", Marca, Modelo, Placa, Quilometragem, Chassi, Cliente_ID, codCarroClicado));

                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao editar os dados deste carro" +
                    ". ");
            }
        }
        public bool Delete(int codCarroClicado)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("DELETE FROM tb_carro WHERE ID = {0}", codCarroClicado));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao excluir os dados do carro. ");
            }
        }
        public DataTable Select()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM tb_carro"));
            bd.Desconectar();
            return dt;
        }

        public DataTable Select(string searchText)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM tb_carro WHERE modelo LIKE '%{0}%'", searchText));
            bd.Desconectar();
            return dt;
        }
    }
}
