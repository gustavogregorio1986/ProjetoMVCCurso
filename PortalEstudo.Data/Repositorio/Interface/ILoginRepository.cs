using PortalEstudo.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalEstudo.Data.Repositorio.Interface
{
    public interface ILoginRepository
    {
        void Inserir(Login login);
    }
}
