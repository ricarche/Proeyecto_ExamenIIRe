using Examen2.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.Modelos.ConexionBD
{
   public class CreacionTicketDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool CreacionNuevoTicket(CreacionTicket creacion)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO TICKETS ");
                sql.Append(" VALUES (@TipoSoporte, @NombreCliente, @Email, @Direccion, @DescripcionProblema); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@TipoSoporte", SqlDbType.NVarChar, 50).Value = creacion.TipoSoporte;
                comando.Parameters.Add("@NombreCliente", SqlDbType.NVarChar, 80).Value = creacion.NombreCliente;
                comando.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = creacion.Email;
                comando.Parameters.Add("@Direccion", SqlDbType.NVarChar, 80).Value = creacion.Direccion;
                comando.Parameters.Add("@DescripcionProblema", SqlDbType.NVarChar, 100).Value = creacion.DescripcionProblema;
                comando.ExecuteNonQuery();
                return true;
                MiConexion.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable GetTickets()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM TICKETS ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                SqlDataReader dr = comando.ExecuteReader();
                dt.Load(dr);
                MiConexion.Close();
            }
            catch (Exception)
            {
            }
            return dt;
        }

        public bool EliminarUsuario(int id)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM TICKETS ");
                sql.Append(" WHERE ID = @Id; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                comando.ExecuteNonQuery();
                modifico = true;
                MiConexion.Close();

            }
            catch (Exception ex)
            {
                return modifico;
            }
            return modifico;
        }

    }
}
