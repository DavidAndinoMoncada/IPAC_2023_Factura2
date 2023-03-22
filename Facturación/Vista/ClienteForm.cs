using Datos;
using Entidades;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class ClienteForm : Form
    {
        public ClienteForm()
        {
            InitializeComponent();
        }

        string TipoOperacion;

        ClienteDB ClienteDB = new ClienteDB();
        Cliente cliente = new Cliente();

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            HabilitarControles();
            IdentidadtextBox.Focus();
            TipoOperacion = "Nuevo";
        }

        private void HabilitarControles()
        {

            IdentidadtextBox.Enabled = true;
            NombretextBox.Enabled = true;
            TelefonotextBox.Enabled = true;
            CorreotextBox.Enabled = true;
            DirecciontextBox.Enabled = true;
            FechaNacimientodateTimePicker.Enabled = true;
            EstaActivocheckBox.Enabled = true;
            Modificarbutton.Enabled = true;
            Guardarbutton.Enabled = true;
            Eliminarbutton.Enabled = true;
            Cancelarbutton.Enabled = true;

        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DesabilitarControles();
            LimpiarControles();
        }

        private void DesabilitarControles()
        {
            IdentidadtextBox.Enabled = false;
            NombretextBox.Enabled = false;
            TelefonotextBox.Enabled = false;
            CorreotextBox.Enabled = false;
            DirecciontextBox.Enabled = false;
            FechaNacimientodateTimePicker.Enabled = false;
            EstaActivocheckBox.Enabled = false;
            Modificarbutton.Enabled = false;
            Guardarbutton.Enabled = false;
            Eliminarbutton.Enabled = false;
            Cancelarbutton.Enabled = false;
        }

        private void LimpiarControles()
        {
            IdentidadtextBox.Clear();
            NombretextBox.Clear();
            TelefonotextBox.Clear();
            CorreotextBox.Clear();
            DirecciontextBox.Clear();
            EstaActivocheckBox.Checked = false;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (TipoOperacion == "Nuevo")
            {
                if (string.IsNullOrEmpty(IdentidadtextBox.Text))
                {
                    errorProvider1.SetError(IdentidadtextBox, "Ingrese un Codigo");
                    IdentidadtextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(NombretextBox.Text))
                {
                    errorProvider1.SetError(NombretextBox, "Ingrese un Nombre");
                    NombretextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(TelefonotextBox.Text))
                {
                    errorProvider1.SetError(TelefonotextBox, "Ingrese una Contraseña");
                    TelefonotextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(CorreotextBox.Text))
                {
                    errorProvider1.SetError(CorreotextBox, "Seleccione un Rol");
                    CorreotextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(DirecciontextBox.Text))
                {
                    errorProvider1.SetError(DirecciontextBox, "Seleccione un Rol");
                    DirecciontextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(FechaNacimientodateTimePicker.ToString()))
                {
                    errorProvider1.SetError(FechaNacimientodateTimePicker, "Seleccione un Rol");
                    FechaNacimientodateTimePicker.Focus();
                    return;
                }
                errorProvider1.Clear();

                cliente.Identidad = IdentidadtextBox.Text;
                cliente.Nombre = NombretextBox.Text;
                cliente.Telefono = TelefonotextBox.Text;
                cliente.Correo = CorreotextBox.Text;
                cliente.Direccion = DirecciontextBox.Text;
                cliente.EstaActivo = EstaActivocheckBox.Checked;


                //Insertar en la Base de Datos

                bool inserto = ClienteDB.Insertar(cliente);

                if (inserto)
                {
                    MessageBox.Show("Registro Guardado");
                    LimpiarControles();
                    DesabilitarControles();
                    TraerClientes();

                }
                else
                {
                    MessageBox.Show("No se Pudo Guardar el Registro");
                }

            }
            else if (TipoOperacion == "Modificar")
            {
                cliente.Identidad = IdentidadtextBox.Text;
                cliente.Nombre = NombretextBox.Text;
                cliente.Telefono = TelefonotextBox.Text;
                cliente.Correo = CorreotextBox.Text;
                cliente.Direccion = DirecciontextBox.Text;
                cliente.EstaActivo = EstaActivocheckBox.Checked;


                bool modifico = ClienteDB.Editar(cliente);

                if (modifico)
                {
                    LimpiarControles();
                    DesabilitarControles();
                    TraerClientes();
                    MessageBox.Show("Registro Actualizado Correctamente");

                }
                else
                {
                    MessageBox.Show("No se Pudo Actualizar el Registro");
                }

            }
        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {
            TipoOperacion = "Modificar";

            if (ClientesdataGridView.SelectedRows.Count > 0)
            {
                IdentidadtextBox.Text = ClientesdataGridView.CurrentRow.Cells["Identidad"].Value.ToString();
                NombretextBox.Text = ClientesdataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                TelefonotextBox.Text = ClientesdataGridView.CurrentRow.Cells["Telefono"].Value.ToString();
                CorreotextBox.Text = ClientesdataGridView.CurrentRow.Cells["Correo"].Value.ToString();
                DirecciontextBox.Text = ClientesdataGridView.CurrentRow.Cells["Direccion"].Value.ToString();
                EstaActivocheckBox.Checked = Convert.ToBoolean(ClientesdataGridView.CurrentRow.Cells["EstaActivo"].Value);

                HabilitarControles();
            }
            else
            {
                MessageBox.Show("Debe Seleccionar un Registro");
            }
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            TraerClientes();
        }

        private void TraerClientes()
        {

            ClientesdataGridView.DataSource = ClienteDB.DevolverClientes();

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (ClientesdataGridView.SelectedRows.Count > 0)
            {

                DialogResult resultado = MessageBox.Show("Esta Seguiro de Eliminar el Registro", "Advertencia", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    bool elimino = ClienteDB.Eliminar(ClientesdataGridView.CurrentRow.Cells["Identidad"].Value.ToString());

                    if (elimino)
                    {
                        LimpiarControles();
                        DesabilitarControles();
                        TraerClientes();
                        MessageBox.Show("Registro Eliminado Correctamente");
                    }
                    else
                    {
                        MessageBox.Show("No Se Pudo Eliminar El Registro");
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe Seleccionar un Registro");
            }
        }
    }
}
