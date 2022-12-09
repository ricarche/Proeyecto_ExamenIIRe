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
    public class EstadoDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool EstadoTicket(Estado estado)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO ESTADO ");
                sql.Append(" VALUES (@EstadoTicket, @TipoSoporte, @NombreCliente); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@EstadoTicket", SqlDbType.NVarChar, 50).Value = estado.EstadoTicket;
                comando.Parameters.Add("@TipoSoporte", SqlDbType.NVarChar, 50).Value = estado.TipoSoporte;
                comando.Parameters.Add("@NombreCliente", SqlDbType.NVarChar, 80).Value = estado.NombreCliente;
                comando.ExecuteNonQuery();
                return true;
                MiConexion.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable GetEstado()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM ESTADO ");

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

        public bool EliminarEstado(int id)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM ESTADO ");
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
            catch (Exception ez)
            {
                return modifico;
            }
            return modifico;
        }



    }
}
