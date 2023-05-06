using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortalEstudo.Dominio.Dominio;

namespace PortalEstudo.Data.Persistence
{
    public class LoginDao : Conexao
    {
        public void Salvar(Login login)
        {
            Open();
            Cmd = new SqlCommand("insert into Login values(@v1, @v2, @v3)", Con);
            Cmd.Parameters.AddWithValue("@v1", login.Usuario);
            Cmd.Parameters.AddWithValue("@v2", login.Senha);
            Cmd.Parameters.AddWithValue("@v3", login.Perfil);
            Cmd.ExecuteNonQuery();
            Close();
        }
    }
}
