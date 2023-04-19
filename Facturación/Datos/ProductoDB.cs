using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text;

namespace Datos
{
    public class ProductoDB
    {
        string cadena = "server=localhost; user=root; database=factura2; password=123456";

        public bool Insertar(Producto producto)
        {
            bool inserto = false;

            try
            {
                StringBuilder sql = new StringBuilder();

                sql.Append("INSERT INTO producto VALUES ");
                sql.Append("(@Codigo, @Descripcion, @Existencia, @Precio, @Foto, @EstaActivo);");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();

                    using (MySqlCommand _comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        _comando.CommandType = CommandType.Text;
                        _comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = producto.Codigo;
                        _comando.Parameters.Add("@Descripcion", MySqlDbType.VarChar, 200).Value = producto.Descripcion;
                        _comando.Parameters.Add("@Existencia", MySqlDbType.Int32).Value = producto.Existencia;
                        _comando.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = producto.Precio;
                        _comando.Parameters.Add("@Foto", MySqlDbType.LongBlob).Value = producto.Foto;
                        _comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = producto.EstaActivo;
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

        public bool Editar(Producto producto)
        {

            bool edito = false;

            try
            {
                StringBuilder sql = new StringBuilder();

                sql.Append("UPDATE producto SET ");
                sql.Append(" Descripcion = @Descripcion, Existencia = @Existencia, Precio = @Precio, Foto = @Foto, EstaActivo = @EstaActivo ");
                sql.Append("WHERE Codigo = @Codigo; ");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();

                    using (MySqlCommand _comando = new MySqlCommand(sql.ToString(), _conexion))
                    {

                        _comando.CommandType = CommandType.Text;
                        _comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = producto.Codigo;
                        _comando.Parameters.Add("@Descripcion", MySqlDbType.VarChar, 200).Value = producto.Descripcion;
                        _comando.Parameters.Add("@Existencia", MySqlDbType.Int32).Value = producto.Existencia;
                        _comando.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = producto.Precio;
                        _comando.Parameters.Add("@Foto", MySqlDbType.LongBlob).Value = producto.Foto;
                        _comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = producto.EstaActivo;
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

        public bool Eliminar(string Codigo)
        {

            bool elimino = false;

            try
            {
                StringBuilder sql = new StringBuilder();

                sql.Append("DELETE FROM producto ");
                sql.Append("WHERE Codigo = @Codigo;");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();

                    using (MySqlCommand _comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        _comando.CommandType = CommandType.Text;
                        _comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = Codigo;
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

        public DataTable DevolverProductos()
        {

            DataTable dt = new DataTable();

            try
            {
                StringBuilder sql = new StringBuilder();

                sql.Append("SELECT * FROM producto ");

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

        public byte[] DevolverFoto(string Codigo)
        {
            byte[] foto = new byte[0];

            try
            {
                StringBuilder sql = new StringBuilder();

                sql.Append("SELECT Foto FROM producto WHERE Codigo = @Codigo;");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();

                    using (MySqlCommand _comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        _comando.CommandType = CommandType.Text;
                        _comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = Codigo;
                        MySqlDataReader dr = _comando.ExecuteReader();

                        if (dr.Read())
                        {
                            foto = (byte[])dr["Foto"];
                        }

                    }

                }


            }
            catch (System.Exception)
            {
            }

            return foto;

        }

        public Producto DevolverProductoPorCodigo(string Codigo)
        {

            Producto producto = null;

            try
            {
                StringBuilder sql = new StringBuilder();

                sql.Append("SELECT * FROM producto WHERE Codigo = @Codigo;");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();

                    using (MySqlCommand _comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        _comando.CommandType = CommandType.Text;
                        _comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = Codigo;
                        MySqlDataReader dr = _comando.ExecuteReader();

                        if (dr.Read())
                        {
                            producto = new Producto();

                            producto.Codigo = Codigo;
                            producto.Descripcion = dr["Descripcion"].ToString();
                            producto.Existencia = dr["Existencia"].ToString();
                            producto.Precio = dr["Precio"].ToString();
                            producto.EstaActivo = Convert.ToBoolean(dr["EstaActivo"]);

                        }
                    }

                }

            }
            catch (System.Exception)
            {
            }

            return producto;

        }

        public DataTable DevolverProductoPorDescripcion(string Descripcion)
        {

            DataTable dt = new DataTable();

            try
            {
                StringBuilder sql = new StringBuilder();

                sql.Append("SELECT * FROM producto WHERE Descripcion LIKE '%" + Descripcion + "%'");

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

    }
}