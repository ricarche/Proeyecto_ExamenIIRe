using Examen2.Modelos.ConexionBD;
using Examen2.Modelos.Entidades;
using Examen2.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2.Controladores
{
    public class EstadoTicketController
    {
        EstadoTicketView vista;
        string operacion = string.Empty;
        EstadoDAO estadoDAO = new EstadoDAO();
        Estado estado = new Estado();

        public EstadoTicketController(EstadoTicketView view)
        {
            vista = view;
            vista.NuevoButton.Click += new EventHandler(Nuevo);
            vista.GuardarButton.Click += new EventHandler(Guardar);
            vista.Load += new EventHandler(Load);
            vista.EliminarButton.Click += new EventHandler(Eliminar);
            vista.CancelarButton.Click += new EventHandler(Cancelar);
        }

        private void Cancelar(object sender, EventArgs e)
        {
            DesabilitarControles();
            LimpiarControles();
            estado = null;
        }
        private void Eliminar(object serder, EventArgs e)
        {
            if (vista.EstadoTicketDataGriedView.SelectedRows.Count > 0)
            {
                bool elimino = estadoDAO.EliminarEstado(Convert.ToInt32(vista.EstadoTicketDataGriedView.CurrentRow.Cells[0].Value.ToString()));

                if (elimino)
                {
                    DesabilitarControles();
                    LimpiarControles();

                    MessageBox.Show("Estado de Ticket eliminado exitosamente", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    ListarTickets();
                }
            }
        }

        private void Nuevo(object serder, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }

        private void Load(object serder, EventArgs e)
        {
            ListarTickets();
        }

        private void Guardar(object serder, EventArgs e)
        {

            if (vista.EstadoTicketComboBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.EstadoTicketComboBox, "Ingrese el estado del ticket");
                vista.EstadoTicketComboBox.Focus();
                return;
            }
            if (vista.TipoSoporteComboBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.TipoSoporteComboBox, "Ingrese el tipo de soporte que necesita");
                vista.TipoSoporteComboBox.Focus();
                return;
            }
            if (vista.NombreClienteTextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.NombreClienteTextBox, "Ingrese el nombre del cliente");
                vista.NombreClienteTextBox.Focus();
                return;
            }

            estado.EstadoTicket = vista.EstadoTicketComboBox.Text;
            estado.TipoSoporte = vista.TipoSoporteComboBox.Text;
            estado.NombreCliente = vista.NombreClienteTextBox.Text;

            bool inserto = estadoDAO.EstadoTicket(estado);

            if (operacion == "Nuevo")
            {

                if (inserto)
                {
                    DesabilitarControles();
                    LimpiarControles();
                    MessageBox.Show("Nuevo estado de ticket creado exitosamente", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    ListarTickets();

                }
                else
                {
                    MessageBox.Show("No se pudo crear el estado del Ticket", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }


        }

        private void ListarTickets()
        {
            vista.EstadoTicketDataGriedView.DataSource = estadoDAO.GetEstado();
        }

        private void LimpiarControles()
        {
            vista.IdTextBox.Clear();
            vista.EstadoTicketComboBox.Text = "";
            vista.TipoSoporteComboBox.Text = "";
            vista.NombreClienteTextBox.Clear();
        }

        private void HabilitarControles()
        {
            vista.IdTextBox.Enabled = true;
            vista.EstadoTicketComboBox.Enabled = true;
            vista.TipoSoporteComboBox.Enabled = true;
            vista.NombreClienteTextBox.Enabled = true;

            vista.GuardarButton.Enabled = true;
            vista.CancelarButton.Enabled = true;
            vista.NuevoButton.Enabled = false;
        }

        private void DesabilitarControles()
        {
            vista.IdTextBox.Enabled = false;
            vista.EstadoTicketComboBox.Enabled = false;
            vista.TipoSoporteComboBox.Enabled = false;
            vista.NombreClienteTextBox.Enabled = false;

            vista.GuardarButton.Enabled = false;
            vista.CancelarButton.Enabled = false;
            vista.NuevoButton.Enabled = true;
        }


    }
}
