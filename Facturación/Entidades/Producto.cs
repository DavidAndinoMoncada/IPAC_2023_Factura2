namespace Entidades
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Existencia { get; set; }
        public string Precio { get; set; }
        public byte[] Foto { get; set; }
        public bool EstaActivo { get; set; }

        public Producto()
        {
        }

        public Producto(string codigo, string descripcion, string existencia, string precio, byte[] foto)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Existencia = existencia;
            Precio = precio;
            Foto = foto;
        }
    }
}
