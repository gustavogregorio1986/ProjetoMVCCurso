﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalEstudo.Dominio.Dominio
{
    public class Login
    {
        public int Id { get; set; }

        public string Usuario { get; set; }

        public string Senha { get; set; }

        public string Email { get; set; }

        public string Perfil { get; set; }
    }
}
