using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.Modelos.Entidades
{
    public class Estado
    {
        public int Id { get; set; }
        public string EstadoTicket { get; set; }
        public string TipoSoporte { get; set; }
        public string NombreCliente { get; set; }
    }
}
