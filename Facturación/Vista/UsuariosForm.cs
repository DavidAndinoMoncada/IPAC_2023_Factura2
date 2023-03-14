using Datos;
using Entidades;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Vista
{
    public partial class UsuariosForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
        }

        string TipoOperacion;

        DataTable dt = new DataTable();
        UsuarioDB UsuarioDB = new UsuarioDB();
        Usuario user = new Usuario();

        private void Nuevobutton_Click(object sender, System.EventArgs e)
        {
            HabilitarControles();
            CodigotextBox.Focus();
            TipoOperacion = "Nuevo";
        }

        private void HabilitarControles()
        {

            CodigotextBox.Enabled = true;
            NombretextBox.Enabled = true;
            ContraseñatextBox.Enabled = true;
            CorreotextBox.Enabled = true;
            RolcomboBox.Enabled = true;
            EstaActivocheckBox.Enabled = true;
            Modificarbutton.Enabled = true;
            Guardarbutton.Enabled = true;
            Eliminarbutton.Enabled = true;
            Cancelarbutton.Enabled = true;
            AdjuntarFotobutton.Enabled = true;

        }

        private void Cancelarbutton_Click(object sender, System.EventArgs e)
        {
            DesabilitarControles();
            LimpiarControles();
        }

        private void DesabilitarControles()
        {
            CodigotextBox.Enabled = false;
            NombretextBox.Enabled = false;
            ContraseñatextBox.Enabled = false;
            CorreotextBox.Enabled = false;
            RolcomboBox.Enabled = false;
            EstaActivocheckBox.Enabled = false;
            Modificarbutton.Enabled = false;
            Guardarbutton.Enabled = false;
            Eliminarbutton.Enabled = false;
            Cancelarbutton.Enabled = false;
            AdjuntarFotobutton.Enabled = false;
        }

        private void LimpiarControles()
        {
            CodigotextBox.Clear();
            NombretextBox.Clear();
            ContraseñatextBox.Clear();
            CorreotextBox.Clear();
            RolcomboBox.Text = "";
            EstaActivocheckBox.Checked = false;
            FotopictureBox.Image = null;
        }

        private void Guardarbutton_Click(object sender, System.EventArgs e)
        {
            if (TipoOperacion == "Nuevo")
            {
                if (string.IsNullOrEmpty(CodigotextBox.Text))
                {
                    errorProvider1.SetError(CodigotextBox, "Ingrese un Codigo");
                    CodigotextBox.Focus();
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

                if (string.IsNullOrEmpty(ContraseñatextBox.Text))
                {
                    errorProvider1.SetError(ContraseñatextBox, "Ingrese una Contraseña");
                    ContraseñatextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(RolcomboBox.Text))
                {
                    errorProvider1.SetError(RolcomboBox, "Seleccione un Rol");
                    RolcomboBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                user.CodigoUsuario = CodigotextBox.Text;
                user.Nombre = NombretextBox.Text;
                user.Contraseña = ContraseñatextBox.Text;
                user.Correo = CorreotextBox.Text;
                user.Rol = RolcomboBox.Text;
                user.EstaActivo = EstaActivocheckBox.Checked;

                if (FotopictureBox.Image != null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();

                    FotopictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    user.Foto = ms.GetBuffer();
                }

                //Insertar en la Base de Datos

                bool inserto = UsuarioDB.Insertar(user);

                if (inserto)
                {
                    MessageBox.Show("Registro Guardado");
                    LimpiarControles();
                    DesabilitarControles(); TraerUsuarios();
                    TraerUsuarios();

                }
                else
                {
                    MessageBox.Show("No se Pudo Guardar el Registro");
                }

            }
            else if (TipoOperacion == "Modificar")
            {
                user.CodigoUsuario = CodigotextBox.Text;
                user.Nombre = NombretextBox.Text;
                user.Contraseña = ContraseñatextBox.Text;
                user.Correo = CorreotextBox.Text;
                user.Rol = RolcomboBox.Text;
                user.EstaActivo = EstaActivocheckBox.Checked;

                if (FotopictureBox.Image != null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();

                    FotopictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    user.Foto = ms.GetBuffer();
                }

                bool modifico = UsuarioDB.Editar(user);

                if (modifico)
                {
                    LimpiarControles();
                    DesabilitarControles();
                    TraerUsuarios();
                    MessageBox.Show("Registro Actualizado Correctamente");

                }
                else
                {
                    MessageBox.Show("No se Pudo Actualizar el Registro");
                }

            }
        }

        private void Modificarbutton_Click(object sender, System.EventArgs e)
        {
            TipoOperacion = "Modificar";

            if (UsuariosdataGridView.SelectedRows.Count > 0)
            {
                CodigotextBox.Text = UsuariosdataGridView.CurrentRow.Cells["CodigoUsuario"].Value.ToString();
                NombretextBox.Text = UsuariosdataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                ContraseñatextBox.Text = UsuariosdataGridView.CurrentRow.Cells["Contraseña"].Value.ToString();
                CorreotextBox.Text = UsuariosdataGridView.CurrentRow.Cells["Correo"].Value.ToString();
                RolcomboBox.Text = UsuariosdataGridView.CurrentRow.Cells["Rol"].Value.ToString();
                EstaActivocheckBox.Checked = Convert.ToBoolean(UsuariosdataGridView.CurrentRow.Cells["EstaActivo"].Value);

                byte[] miFoto = UsuarioDB.DevolverFoto(UsuariosdataGridView.CurrentRow.Cells["CodigoUsuario"].Value.ToString()); ;

                if (miFoto.Length > 0)
                {
                    MemoryStream ms = new MemoryStream(miFoto);
                    FotopictureBox.Image = System.Drawing.Bitmap.FromStream(ms);
                }

                HabilitarControles();
            }
            else
            {
                MessageBox.Show("Debe Seleccionar un Registro");
            }
        }

        private void AdjuntarFotobutton_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult resultado = dialog.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                FotopictureBox.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void UsuariosForm_Load(object sender, System.EventArgs e)
        {
            TraerUsuarios();
        }

        private void TraerUsuarios()
        {
            dt = UsuarioDB.DevolverUsuarios();

            UsuariosdataGridView.DataSource = dt;

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (UsuariosdataGridView.SelectedRows.Count > 0)
            {

                DialogResult resultado = MessageBox.Show("Esta Seguiro de Eliminar el Registro", "Advertencia", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    bool elimino = UsuarioDB.Eliminar(UsuariosdataGridView.CurrentRow.Cells["CodigoUsuario"].Value.ToString());

                    if (elimino)
                    {
                        LimpiarControles();
                        DesabilitarControles();
                        TraerUsuarios();
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
