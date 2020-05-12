using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Controllers
{
    class LoginController
    {
        public int ID { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }
        //ola mundo
        AcessoController bd = new AcessoController();

        public DataTable Login()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM tb_userAdm WHERE email LIKE '{0}' AND senha LIKE '{1}'", Email, Senha));
            bd.Desconectar();
            return dt;
        }

        public int VerifyLogin(string email)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM tb_userAdm WHERE email = '{0}'", email));
            bd.Desconectar();
            int linha = (dt.Rows.Count > 0) ? 1 : 0;
            return linha;
        }

        public DataTable RetPassword(string email)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT senha FROM tb_userAdm WHERE email = '{0}'", email));
            bd.Desconectar();

            return dt;
        }
    }
}
