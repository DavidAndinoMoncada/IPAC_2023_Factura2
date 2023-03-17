using Datos;
using Entidades;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class BuscarClienteForm : Form
    {
        public BuscarClienteForm()
        {
            InitializeComponent();
        }

        ClienteDB ClienteDB = new ClienteDB();

        public Cliente Cliente = new Cliente();

        private void BuscarClienteForm_Load(object sender, EventArgs e)
        {
            ClientesdataGridView.DataSource = ClienteDB.DevolverClientes();
        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            if (ClientesdataGridView.SelectedRows.Count > 0)
            {
                Cliente.Identidad = ClientesdataGridView.CurrentRow.Cells["Identidad"].Value.ToString();
                Cliente.Nombre = ClientesdataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                Cliente.Telefono = ClientesdataGridView.CurrentRow.Cells["Telefono"].Value.ToString();
                Cliente.Correo = ClientesdataGridView.CurrentRow.Cells["Correo"].Value.ToString();
                Cliente.Direccion = ClientesdataGridView.CurrentRow.Cells["Direccion"].Value.ToString();
                Cliente.FechaNacimiento = Convert.ToDateTime(ClientesdataGridView.CurrentRow.Cells["FechaNacimiento"].Value);
                Cliente.EstaActivo = Convert.ToBoolean(ClientesdataGridView.CurrentRow.Cells["EstaActivo"].Value);

            }
        }

        private void NombretextBox_KeyUp(object sender, KeyEventArgs e)
        {

            ClientesdataGridView.DataSource = ClienteDB.DevolverClientesPorNombre(NombretextBox.Text);

        }
    }
}
