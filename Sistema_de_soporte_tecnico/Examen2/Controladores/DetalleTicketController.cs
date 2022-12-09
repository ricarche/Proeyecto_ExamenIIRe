using Examen2.Modelos.ConexionBD;
using Examen2.Modelos.Entidades;
using Examen2.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.Controladores
{
    public class DetalleTicketController
    {

        DetalleTicketView vista;
        DetalleDAO detalleDAO = new DetalleDAO();
        Detalle detalle = new Detalle();


        public DetalleTicketController(DetalleTicketView view)
        {
            vista = view;
            vista.MostrarTicketButton.Click += new EventHandler(Load);
            vista.LimpiarButton.Click += new EventHandler(Limpiar);
        }

        private void Load(object serder, EventArgs e)
        {
            ListarTickets();
        }

        private void ListarTickets()
        {
            vista.DetalleDataGridView.DataSource = detalleDAO.GetDetalleTickets();
        }

        private void Limpiar(object serder, EventArgs e)
        {
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            vista.DetalleDataGridView.DataSource = null;
            vista.DetalleDataGridView.Refresh();
        }
    }
}
