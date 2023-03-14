using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text;

namespace Datos
{
    public class UsuarioDB
    {
        string cadena = "server=localhost; user=root; database=factura2; password=123456";

        public Usuario Autenticar(Login login)
        {
            Usuario user = null;

            try
            {
                StringBuilder sql = new StringBuilder();

                sql.Append("SELECT * FROM usuario WHERE CodigoUsuario = @CodigoUsuario AND Contraseña = @Contraseña;");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();

                    using (MySqlCommand _comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        _comando.CommandType = CommandType.Text;
                        _comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = login.CodigoUsuario;
                        _comando.Parameters.Add("@Contraseña", MySqlDbType.VarChar, 50).Value = login.Contraseña;

                        MySqlDataReader dr = _comando.ExecuteReader();

                        if (dr.Read())
                        {
                            user = new Usuario();

                            user.CodigoUsuario = dr["CodigoUsuario"].ToString();
                            user.Nombre = dr["Nombre"].ToString();
                            user.Contraseña = dr["Contraseña"].ToString();
                            user.Correo = dr["Correo"].ToString();
                            user.Rol = dr["Rol"].ToString();
                            user.FechaCreación = Convert.ToDateTime(dr["FechaCreacion"]);
                            user.EstaActivo = Convert.ToBoolean(dr["EstaActivo"]);

                            if (dr["Foto"].GetType() != typeof(DBNull))
                            {
                                user.Foto = (byte[])dr["Foto"];
                            }

                        }

                    }

                }


            }
            catch (System.Exception)
            {
            }

            return user;

        }

        public bool Insertar(Usuario user)
        {
            bool inserto = false;

            try
            {
                StringBuilder sql = new StringBuilder();

                sql.Append("INSERT INTO usuario VALUES ");
                sql.Append("(@CodigoUsuario, @Nombre, @Contraseña, @Correo, @Rol, @Foto, @FechaCreacion, @EstaActivo);");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();

                    using (MySqlCommand _comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        _comando.CommandType = CommandType.Text;
                        _comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = user.CodigoUsuario;
                        _comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 50).Value = user.Nombre;
                        _comando.Parameters.Add("@Contraseña", MySqlDbType.VarChar, 80).Value = user.Contraseña;
                        _comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 45).Value = user.Correo;
                        _comando.Parameters.Add("@Rol", MySqlDbType.VarChar, 20).Value = user.Rol;
                        _comando.Parameters.Add("@Foto", MySqlDbType.LongBlob).Value = user.Foto;
                        _comando.Parameters.Add("@FechaCreacion", MySqlDbType.DateTime).Value = user.FechaCreación;
                        _comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = user.EstaActivo;
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

        public bool Editar(Usuario user)
        {

            bool edito = false;

            try
            {
                StringBuilder sql = new StringBuilder();

                sql.Append("UPDATE usuario SET ");
                sql.Append(" Nombre = @Nombre, Contraseña = @Contraseña, Correo = @Correo, Rol = @Rol, Foto = @Foto, EstaActivo = @EstaActivo ");
                sql.Append("WHERE CodigoUsuario = @CodigoUsuario; ");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();

                    using (MySqlCommand _comando = new MySqlCommand(sql.ToString(), _conexion))
                    {

                        _comando.CommandType = CommandType.Text;
                        _comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = user.CodigoUsuario;
                        _comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 50).Value = user.Nombre;
                        _comando.Parameters.Add("@Contraseña", MySqlDbType.VarChar, 80).Value = user.Contraseña;
                        _comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 45).Value = user.Correo;
                        _comando.Parameters.Add("@Rol", MySqlDbType.VarChar, 20).Value = user.Rol;
                        _comando.Parameters.Add("@Foto", MySqlDbType.LongBlob).Value = user.Foto;
                        _comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = user.EstaActivo;
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

        public bool Eliminar(string CodigoUsuario)
        {

            bool elimino = false;

            try
            {
                StringBuilder sql = new StringBuilder();

                sql.Append("DELETE FROM usuario ");
                sql.Append("WHERE CodigoUsuario = @CodigoUsuario;");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();

                    using (MySqlCommand _comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        _comando.CommandType = CommandType.Text;
                        _comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = CodigoUsuario;
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

        public DataTable DevolverUsuarios()
        {

            DataTable dt = new DataTable();

            try
            {
                StringBuilder sql = new StringBuilder();

                sql.Append("SELECT * FROM usuario ");

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

        public byte[] DevolverFoto(string CodigoUsuario)
        {
            byte[] foto = new byte[0];

            try
            {
                StringBuilder sql = new StringBuilder();

                sql.Append("SELECT Foto FROM usuario WHERE CodigoUsuario = @CodigoUsuario;");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();

                    using (MySqlCommand _comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        _comando.CommandType = CommandType.Text;
                        _comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = CodigoUsuario;
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

    }
}
