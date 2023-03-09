using System;

namespace Entidades
{
    public class Usuario
    {
        public string CodigoUsuario { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public string Correo { get; set; }
        public string Rol { get; set; }
        public byte[] Foto { get; set; }
        public DateTime FechaCreación { get; set; }
        public bool EstaActivo { get; set; }

        public Usuario()
        {

        }

        public Usuario(string codigoUsuario, string nombre, string contraseña, string correo, string rol,
            byte[] foto, DateTime fechaCreación, bool estaActivo)
        {
            CodigoUsuario = codigoUsuario;
            Nombre = nombre;
            Contraseña = contraseña;
            Correo = correo;
            Rol = rol;
            Foto = foto;
            FechaCreación = fechaCreación;
            EstaActivo = estaActivo;
        }
    }
}
