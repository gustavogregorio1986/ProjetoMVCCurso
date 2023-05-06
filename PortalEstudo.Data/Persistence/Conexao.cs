using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace PortalEstudo.Data.Persistence
{
    public class Conexao
    {
        protected SqlConnection Con;
        protected SqlCommand Cmd;
        protected SqlDataReader Dr;

        public void Open()
        {
            Con = new SqlConnection(ConfigurationManager.ConnectionStrings["cursoestudo"].ConnectionString);
            Con.Open();

        }

        public void Close()
        {
            Con.Close();
        }
    }
}
