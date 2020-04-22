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

        AcessoController bd = new AcessoController();

        public DataTable Login()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM tb_userAdm WHERE email LIKE '{0}' AND senha LIKE '{1}'", Email, Senha));
            bd.Desconectar();
            return dt;
        }
    }
}
