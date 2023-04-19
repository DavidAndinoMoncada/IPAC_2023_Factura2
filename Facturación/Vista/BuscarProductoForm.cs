using Datos;
using Entidades;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class BuscarProductoForm : Form
    {
        public BuscarProductoForm()
        {
            InitializeComponent();
        }

        ProductoDB productoDB = new ProductoDB();

        public Producto producto = new Producto();

        private void BuscarProductoForm_Load(object sender, EventArgs e)
        {
            ProductodataGridView.DataSource = productoDB.DevolverProductos();
        }

        private void DescripciontextBox_KeyUp(object sender, KeyEventArgs e)
        {
            ProductodataGridView.DataSource = productoDB.DevolverProductoPorDescripcion(DescripciontextBox.Text);
        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            if (ProductodataGridView.RowCount > 0)
            {
                if (ProductodataGridView.SelectedRows.Count > 0)
                {
                    producto.Codigo = ProductodataGridView.CurrentRow.Cells["Codigo"].Value.ToString();
                    producto.Descripcion = ProductodataGridView.CurrentRow.Cells["Descripcion"].Value.ToString();
                    producto.Existencia = ProductodataGridView.CurrentRow.Cells["Existencia"].Value.ToString();
                    producto.Precio = ProductodataGridView.CurrentRow.Cells["Precio"].Value.ToString();
                    producto.EstaActivo = Convert.ToBoolean(ProductodataGridView.CurrentRow.Cells["EstaActivo"].Value);
                    Close();
                }
            }
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
