using Datos;
using Entidades;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class FacturaForm : Form
    {
        public FacturaForm()
        {
            InitializeComponent();
        }

        Cliente miCliente = null;
        ClienteDB clienteDB = new ClienteDB();
        private void IdentidadtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                miCliente = new Cliente();
                miCliente = clienteDB.DevolverClientePorIdentidad(IdentidadtextBox.Text);
                NombreClientetextBox.Text = miCliente.Nombre;
            }
            else
            {
                miCliente = null;
                NombreClientetextBox.Clear();
            }
        }

        private void BuscarClientebutton_Click(object sender, EventArgs e)
        {

        }
    }
}
