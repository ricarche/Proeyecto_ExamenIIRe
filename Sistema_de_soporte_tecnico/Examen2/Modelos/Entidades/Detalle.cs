﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.Modelos.Entidades
{
    public class Detalle
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }
        public bool EsAdministrador { get; set; }


    }
}
