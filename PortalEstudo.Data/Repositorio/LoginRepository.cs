using PortalEstudo.Data.Persistence;
using PortalEstudo.Data.Repositorio.Interface;
using PortalEstudo.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalEstudo.Data.Repositorio
{
    public class LoginRepository : ILoginRepository
    {
        private LoginDao loginDao;

        public LoginRepository()
        {
            loginDao = new LoginDao();
        }

        public void Inserir(Login login)
        {
            loginDao.Salvar(login);
        }
    }
}
