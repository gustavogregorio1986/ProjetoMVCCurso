using PortalEstudo.Data.Repositorio.Interface;
using PortalEstudo.Dominio.Dominio;
using PortalEstudo.Servico.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalEstudo.Servico.Servico
{
    public class LoginServico : ILoginServico
    {
        private readonly ILoginRepository _reepositorio;

        public void Adicionar(Login login)
        {
            _reepositorio.Inserir(login);
        }
    }
}
