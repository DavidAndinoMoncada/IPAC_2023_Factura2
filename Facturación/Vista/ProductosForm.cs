using Entidades;
using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    public partial class ProductosForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public ProductosForm()
        {
            InitializeComponent();
        }

        string TipoOperacion;
        private void Nuevobutton_Click(object sender, System.EventArgs e)
        {
            HabilitarControles();
            CodigotextBox.Focus();
            TipoOperacion = "Nuevo";
        }

        private void HabilitarControles()
        {

            CodigotextBox.Enabled = true;
            DescripciontextBox.Enabled = true;
            ExistenciatextBox.Enabled = true;
            PreciotextBox.Enabled = true;
            Nuevobutton.Enabled = false;
            Modificarbutton.Enabled = true;
            Guardarbutton.Enabled = true;
            Eliminarbutton.Enabled = true;
            Cancelarbutton.Enabled = true;
            AdjuntarImagenbutton.Enabled = true;

        }
        private void Cancelarbutton_Click(object sender, System.EventArgs e)
        {
            DesabilitarControles();
            LimpiarControles();
        }

        private void DesabilitarControles()
        {
            CodigotextBox.Enabled = false;
            DescripciontextBox.Enabled = false;
            ExistenciatextBox.Enabled = false;
            PreciotextBox.Enabled = false;
            Nuevobutton.Enabled = true;
            Modificarbutton.Enabled = false;
            Guardarbutton.Enabled = false;
            Eliminarbutton.Enabled = false;
            Cancelarbutton.Enabled = false;
            AdjuntarImagenbutton.Enabled = false;
        }

        private void LimpiarControles()
        {
            CodigotextBox.Clear();
            DescripciontextBox.Clear();
            ExistenciatextBox.Clear();
            PreciotextBox.Clear();
            ImagenpictureBox.Image = null;
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

                if (string.IsNullOrEmpty(DescripciontextBox.Text))
                {
                    errorProvider1.SetError(DescripciontextBox, "Ingrese un Nombre");
                    DescripciontextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(ExistenciatextBox.Text))
                {
                    errorProvider1.SetError(ExistenciatextBox, "Ingrese una Contraseña");
                    ExistenciatextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(PreciotextBox.Text))
                {
                    errorProvider1.SetError(PreciotextBox, "Seleccione un Rol");
                    PreciotextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                Producto user = new Producto();

                user.Codigo = CodigotextBox.Text;
                user.Descripcion = DescripciontextBox.Text;
                user.Existencia = ExistenciatextBox.Text;
                user.Precio = PreciotextBox.Text;

                if (ImagenpictureBox.Image != null)
                {
                    System.IO.MemoryStream Ms = new System.IO.MemoryStream();

                    ImagenpictureBox.Image.Save(Ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    user.Imagen = Ms.GetBuffer();
                }


                //Insertar en la Base de Datos


            }
            else if (TipoOperacion == "Modificar")
            {

            }
        }

        private void Modificarbutton_Click(object sender, System.EventArgs e)
        {
            TipoOperacion = "Modificar";
        }

        private void AdjuntarImagenbutton_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult resultado = dialog.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                ImagenpictureBox.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void ExistenciatextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void PreciotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }

            if ((e.KeyChar != '.') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;

            }

        }
    }
}
