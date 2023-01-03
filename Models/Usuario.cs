﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebAPIPrueba.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }  
        public string DocumentoIdentidad { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Ciudad { get; set; }
        public DateTime FechaRegistro { get; set; }

    }
}