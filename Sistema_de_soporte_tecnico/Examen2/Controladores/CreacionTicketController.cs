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
    public class CreacionTicketController
    {
        CreacionTicketView vista;
        string operacion = string.Empty;
        CreacionTicketDAO creacionDAO = new CreacionTicketDAO();
        CreacionTicket creacion = new CreacionTicket();

        public CreacionTicketController(CreacionTicketView view)
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
            creacion = null;
        }
        private void Eliminar(object serder, EventArgs e)
        {
            if (vista.CreacionTicketDataGridView.SelectedRows.Count > 0)
            {
                bool elimino = creacionDAO.EliminarUsuario(Convert.ToInt32(vista.CreacionTicketDataGridView.CurrentRow.Cells[0].Value.ToString()));

                if (elimino)
                {
                    DesabilitarControles();
                    LimpiarControles();

                    MessageBox.Show("Ticket eliminado exitosamente", "Atención", MessageBoxButtons.OK,
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
            if (vista.EmailTextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.EmailTextBox, "Ingrese el correo del cliente");
                vista.EmailTextBox.Focus();
                return;
            }
            if (vista.DireccionTextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.DireccionTextBox, "Ingrese la direccion del cliente");
                vista.DireccionTextBox.Focus();
                return;
            }
            if (vista.DescripcionProblemaTextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.DescripcionProblemaTextBox, "Ingrese una descripcion del problema");
                vista.DescripcionProblemaTextBox.Focus();
                return;
            }

            creacion.TipoSoporte = vista.TipoSoporteComboBox.Text;
            creacion.NombreCliente = vista.NombreClienteTextBox.Text;
            creacion.Email = vista.EmailTextBox.Text;
            creacion.Direccion = vista.DireccionTextBox.Text;
            creacion.DescripcionProblema = vista.DescripcionProblemaTextBox.Text;

            bool inserto = creacionDAO.CreacionNuevoTicket(creacion);

            if (operacion == "Nuevo")
            {

                if (inserto)
                {
                    DesabilitarControles();
                    LimpiarControles();
                    MessageBox.Show("Ticket creado exitosamente", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    ListarTickets();

                }
                else
                {
                    MessageBox.Show("No se pudo crear el Ticket", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }


        }

        private void ListarTickets()
        {
            vista.CreacionTicketDataGridView.DataSource = creacionDAO.GetTickets();
        }

        private void LimpiarControles()
        {
            vista.IdTextBox.Clear();
            vista.TipoSoporteComboBox.Text = "";
            vista.NombreClienteTextBox.Clear();
            vista.EmailTextBox.Clear();
            vista.DireccionTextBox.Clear();
            vista.DescripcionProblemaTextBox.Clear();
        }

        private void HabilitarControles()
        {
            vista.IdTextBox.Enabled = true;
            vista.TipoSoporteComboBox.Enabled = true;
            vista.NombreClienteTextBox.Enabled = true;
            vista.EmailTextBox.Enabled = true;
            vista.DireccionTextBox.Enabled = true;
            vista.DescripcionProblemaTextBox.Enabled = true;

            vista.GuardarButton.Enabled = true;
            vista.CancelarButton.Enabled = true;
            vista.NuevoButton.Enabled = false;
        }

        private void DesabilitarControles()
        {
            vista.IdTextBox.Enabled = false;
            vista.TipoSoporteComboBox.Enabled = false;
            vista.NombreClienteTextBox.Enabled = false;
            vista.EmailTextBox.Enabled = false;
            vista.DireccionTextBox.Enabled = false;
            vista.DescripcionProblemaTextBox.Enabled = false;

            vista.GuardarButton.Enabled = false;
            vista.CancelarButton.Enabled = false;
            vista.NuevoButton.Enabled = true;
        }


    }
}
