﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Usuario
    {

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Password { get; set; }
        public int IdPerfil { get; set; }

    }
}