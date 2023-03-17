using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text;

namespace Datos
{
    public class ClienteDB
    {
        string cadena = "server=localhost; user=root; database=factura2; password=123456";

        public Cliente DevolverClientePorIdentidad(string identidad)
        {

            Cliente cliente = null;

            try
            {
                StringBuilder sql = new StringBuilder();

                sql.Append("SELECT * FROM cliente WHERE Identidad = @Identidad;");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();

                    using (MySqlCommand _comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        _comando.CommandType = CommandType.Text;
                        _comando.Parameters.Add("@Identidad", MySqlDbType.VarChar, 25).Value = identidad;
                        MySqlDataReader dr = _comando.ExecuteReader();

                        if (dr.Read())
                        {
                            cliente = new Cliente();

                            cliente.Identidad = identidad;
                            cliente.Nombre = dr["Nombre"].ToString();
                            cliente.Telefono = dr["Telefono"].ToString();
                            cliente.Correo = dr["Correo"].ToString();
                            cliente.Direccion = dr["Direccion"].ToString();
                            cliente.FechaNacimiento = Convert.ToDateTime(dr["Nombre"].ToString());
                            cliente.EstaActivo = Convert.ToBoolean(dr["EstaActivo"].ToString());
                        }
                    }

                }

            }
            catch (System.Exception)
            {
            }

            return cliente;

        }

        public DataTable DevolverClientes()
        {

            DataTable dt = new DataTable();

            try
            {
                StringBuilder sql = new StringBuilder();

                sql.Append("SELECT * FROM cliente ");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();

                    using (MySqlCommand _comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        _comando.CommandType = CommandType.Text;
                        MySqlDataReader dr = _comando.ExecuteReader();
                        dt.Load(dr);

                    }

                }

            }
            catch (System.Exception)
            {
            }

            return dt;

        }

        public DataTable DevolverClientesPorNombre(string nombre)
        {

            DataTable dt = new DataTable();

            try
            {
                StringBuilder sql = new StringBuilder();

                sql.Append("SELECT * FROM cliente WHERE NOMBRE LIKE ('%@Nombre%'); ");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();

                    using (MySqlCommand _comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        _comando.CommandType = CommandType.Text;
                        _comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 50).Value = nombre;
                        MySqlDataReader dr = _comando.ExecuteReader();
                        dt.Load(dr);

                    }

                }

            }
            catch (System.Exception)
            {
            }

            return dt;

        }
    }
}
