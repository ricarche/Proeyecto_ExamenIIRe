using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.Modelos.Entidades
{
    public class CreacionTicket
    {
        public int Id { get; set; }
        public string TipoSoporte { get; set; }
        public string NombreCliente { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string DescripcionProblema { get; set; }


    }
}
