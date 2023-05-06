using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalEstudo.Models
{
    public class LoginView
    {
        public int Id { get; set; }

        public string Usuario { get; set; }

        public string Senha { get; set; }

        public string Email { get; set; }

        public string Perfil { get; set; }
    }
}