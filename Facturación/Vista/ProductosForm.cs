using Datos;
using Entidades;
using System;
using System.Data;
using System.Drawing;
using System.IO;
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
        Producto producto = new Producto();
        ProductoDB productoDB = new ProductoDB();
        DataTable dt = new DataTable();

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
            EstaActivocheckBox.Checked = false;
            FotopictureBox.Image = null;
        }

        private void Guardarbutton_Click(object sender, System.EventArgs e)
        {
            producto.Codigo = CodigotextBox.Text;
            producto.Descripcion = DescripciontextBox.Text;
            producto.Existencia = ExistenciatextBox.Text;
            producto.Precio = PreciotextBox.Text;
            producto.EstaActivo = EstaActivocheckBox.Checked;

            if (FotopictureBox.Image != null)
            {
                System.IO.MemoryStream Ms = new System.IO.MemoryStream();

                FotopictureBox.Image.Save(Ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                producto.Foto = Ms.GetBuffer();
            }

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
                    errorProvider1.SetError(DescripciontextBox, "Ingrese una Descripcion");
                    DescripciontextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(ExistenciatextBox.Text))
                {
                    errorProvider1.SetError(ExistenciatextBox, "Ingrese una Existencia");
                    ExistenciatextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(PreciotextBox.Text))
                {
                    errorProvider1.SetError(PreciotextBox, "Ingrese un Precio");

                    return;
                }
                errorProvider1.Clear();

                bool inserto = productoDB.Insertar(producto);

                if (inserto)
                {
                    DesabilitarControles();
                    LimpiarControles();
                    TraerProductos();
                    MessageBox.Show("Registro Guardado Correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se Pudo Guardar el Registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (TipoOperacion == "Modificar")
            {
                bool modifico = productoDB.Editar(producto);

                if (modifico)
                {
                    CodigotextBox.ReadOnly = false;
                    DesabilitarControles();
                    LimpiarControles();
                    TraerProductos();
                    MessageBox.Show("Registro Guardado Correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se Pudo Guardar el Registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Modificarbutton_Click(object sender, System.EventArgs e)
        {
            TipoOperacion = "Modificar";
            if (ProductosdataGridView.SelectedRows.Count > 0)
            {
                CodigotextBox.Text = ProductosdataGridView.CurrentRow.Cells["Codigo"].Value.ToString();
                DescripciontextBox.Text = ProductosdataGridView.CurrentRow.Cells["Descripcion"].Value.ToString();
                ExistenciatextBox.Text = ProductosdataGridView.CurrentRow.Cells["Existencia"].Value.ToString();
                PreciotextBox.Text = ProductosdataGridView.CurrentRow.Cells["Precio"].Value.ToString();
                EstaActivocheckBox.Checked = Convert.ToBoolean(ProductosdataGridView.CurrentRow.Cells["EstaActivo"].Value);

                byte[] miFoto = productoDB.DevolverFoto(ProductosdataGridView.CurrentRow.Cells["Codigo"].Value.ToString()); ;

                if (miFoto.Length > 0)
                {
                    MemoryStream ms = new MemoryStream(miFoto);
                    FotopictureBox.Image = System.Drawing.Bitmap.FromStream(ms);
                }

                HabilitarControles();
                CodigotextBox.ReadOnly = true;

            }
            else
            {
                MessageBox.Show("Debe Seleccionar un Registro");
            }
        }

        private void AdjuntarImagenbutton_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult resultado = dialog.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                FotopictureBox.Image = Image.FromFile(dialog.FileName);
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
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && e.KeyChar != '\b')
            {
                e.Handled = true;

            }

            if ((e.KeyChar != '.') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;

            }

        }

        private void ProductosForm_Load(object sender, System.EventArgs e)
        {
            TraerProductos();
        }

        private void TraerProductos()
        {
            dt = productoDB.DevolverProductos();

            ProductosdataGridView.DataSource = dt;

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (ProductosdataGridView.SelectedRows.Count > 0)
            {

                DialogResult resultado = MessageBox.Show("Esta Seguiro de Eliminar el Registro", "Advertencia", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    bool elimino = productoDB.Eliminar(ProductosdataGridView.CurrentRow.Cells["Codigo"].Value.ToString());

                    if (elimino)
                    {
                        LimpiarControles();
                        DesabilitarControles();
                        TraerProductos();
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
