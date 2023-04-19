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

                sql.Append("SELECT * FROM cliente WHERE NOMBRE LIKE '%" + nombre + "%'");

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

        public bool Insertar(Cliente cliente)
        {
            bool inserto = false;

            try
            {
                StringBuilder sql = new StringBuilder();

                sql.Append("INSERT INTO cliente VALUES ");
                sql.Append("(@Identidad, @Nombre, @Telefono, @Correo, @Direccion, @FechaNacimiento, @EstaActivo);");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();

                    using (MySqlCommand _comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        _comando.CommandType = CommandType.Text;
                        _comando.Parameters.Add("@Identidad", MySqlDbType.VarChar, 25).Value = cliente.Identidad;
                        _comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 50).Value = cliente.Nombre;
                        _comando.Parameters.Add("@Telefono", MySqlDbType.VarChar, 15).Value = cliente.Telefono;
                        _comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 45).Value = cliente.Correo;
                        _comando.Parameters.Add("@Direccion", MySqlDbType.VarChar, 100).Value = cliente.Direccion;
                        _comando.Parameters.Add("@FechaNacimiento", MySqlDbType.DateTime).Value = cliente.FechaNacimiento;
                        _comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = cliente.EstaActivo;
                        _comando.ExecuteNonQuery();
                        inserto = true;

                    }

                }


            }
            catch (System.Exception)
            {
            }

            return inserto;

        }

        public bool Editar(Cliente cliente)
        {

            bool edito = false;

            try
            {
                StringBuilder sql = new StringBuilder();

                sql.Append("UPDATE cliente SET ");
                sql.Append(" Nombre = @Nombre, Telefono = @Telefono, Correo = @Correo, Direccion = @Direccion, EstaActivo = @EstaActivo ");
                sql.Append("WHERE Identidad = @Identidad; ");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();

                    using (MySqlCommand _comando = new MySqlCommand(sql.ToString(), _conexion))
                    {

                        _comando.CommandType = CommandType.Text;
                        _comando.Parameters.Add("@Identidad", MySqlDbType.VarChar, 25).Value = cliente.Identidad;
                        _comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 50).Value = cliente.Nombre;
                        _comando.Parameters.Add("@Telefono", MySqlDbType.VarChar, 15).Value = cliente.Telefono;
                        _comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 45).Value = cliente.Correo;
                        _comando.Parameters.Add("@Direccion", MySqlDbType.VarChar, 10).Value = cliente.Direccion;
                        _comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = cliente.EstaActivo;
                        _comando.ExecuteNonQuery();
                        edito = true;

                    }

                }

            }
            catch (System.Exception)
            {
            }

            return edito;

        }

        public bool Eliminar(string identidad)
        {

            bool elimino = false;

            try
            {
                StringBuilder sql = new StringBuilder();

                sql.Append("DELETE FROM cliente ");
                sql.Append("WHERE Identidad = @Identidad;");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();

                    using (MySqlCommand _comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        _comando.CommandType = CommandType.Text;
                        _comando.Parameters.Add("@Identidad", MySqlDbType.VarChar, 25).Value = identidad;
                        _comando.ExecuteNonQuery();
                        elimino = true;

                    }

                }


            }
            catch (System.Exception)
            {
            }

            return elimino;

        }
    }
}
