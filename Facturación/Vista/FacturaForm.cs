using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Vista
{
    public partial class FacturaForm : Form
    {
        public FacturaForm()
        {
            InitializeComponent();
        }

        Cliente miCliente = new Cliente();
        ClienteDB clienteDB = new ClienteDB();
        Producto miProducto = null;
        ProductoDB productoDB = new ProductoDB();

        List<DetalleFactura> listadetalles = new List<DetalleFactura>();

        FacturaDB facturaDB = new FacturaDB();

        decimal subtotal = 0;
        decimal isv = 0;
        decimal descuento = 0;
        decimal pagototal = 0;

        private void IdentidadtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(IdentidadtextBox.Text))
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

        private void BuscarClientebutton_Click(object sender, System.EventArgs e)
        {
            BuscarClienteForm formCliente = new BuscarClienteForm();
            formCliente.ShowDialog();

            miCliente = new Cliente();
            miCliente = formCliente.cliente;
            IdentidadtextBox.Text = miCliente.Identidad;
            NombreClientetextBox.Text = miCliente.Nombre;

        }

        private void FacturaForm_Load(object sender, System.EventArgs e)
        {
            UsuariotextBox.Text = System.Threading.Thread.CurrentPrincipal.Identity.Name;
        }

        private void CodigotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(CodigotextBox.Text))
            {
                miProducto = new Producto();
                miProducto = productoDB.DevolverProductoPorCodigo(CodigotextBox.Text);
                DescripcionProductotextBox.Text = miProducto.Descripcion;
                ExistenciatextBox.Text = miProducto.Existencia;
            }
            else
            {
                miProducto = null;
                DescripcionProductotextBox.Clear();
                ExistenciatextBox.Clear();

            }
        }

        private void BuscarProductobutton_Click(object sender, EventArgs e)
        {
            BuscarProductoForm formProducto = new BuscarProductoForm();
            formProducto.ShowDialog();

            miProducto = new Producto();
            miProducto = formProducto.producto;
            CodigotextBox.Text = miProducto.Codigo;
            DescripcionProductotextBox.Text = miProducto.Descripcion;
            ExistenciatextBox.Text = miProducto.Existencia;
        }

        private void CantidadtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(CantidadtextBox.Text))
            {
                if (Convert.ToInt32(ExistenciatextBox.Text) > 0)
                {
                    if (Convert.ToInt32(ExistenciatextBox.Text) >= Convert.ToInt32(CantidadtextBox.Text))
                    {
                        DetalleFactura detalle = new DetalleFactura();
                        detalle.CodigoProducto = miProducto.Codigo;
                        detalle.Descripcion = miProducto.Descripcion;
                        detalle.Cantidad = Convert.ToInt32(CantidadtextBox.Text);
                        detalle.Precio = Convert.ToDecimal(miProducto.Precio);
                        detalle.Total = Convert.ToInt32(CantidadtextBox.Text) * Convert.ToInt32(miProducto.Precio);

                        subtotal += detalle.Total;
                        isv = subtotal * 0.15M;
                        pagototal = subtotal + isv;

                        listadetalles.Add(detalle);
                        DetalledataGridView.DataSource = null;
                        DetalledataGridView.DataSource = listadetalles;

                        SubTotaltextBox.Text = subtotal.ToString("N2");
                        ISVtextBox.Text = isv.ToString("N2");
                        PagoTotaltextBox.Text = pagototal.ToString("N2");

                        miProducto = null;
                        CodigotextBox.Clear();
                        DescripcionProductotextBox.Clear();
                        ExistenciatextBox.Clear();
                        CantidadtextBox.Clear();
                        CodigotextBox.Focus();

                    }
                    else
                    {
                        MessageBox.Show("No Hay Suficiente Existencia del Producto: " + miProducto.Descripcion);
                    }
                }
                else
                {
                    MessageBox.Show("No Hay Existencia del Producto: " + miProducto.Descripcion);
                }
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Factura miFactura = new Factura();
            miFactura.Fecha = FechadateTimePicker.Value;
            miFactura.CodigoUsuario = System.Threading.Thread.CurrentPrincipal.Identity.Name;
            miFactura.IdentidadCliente = miCliente.Identidad;
            miFactura.SubTotal = subtotal;
            miFactura.ISV = isv;
            miFactura.Descuento = descuento;
            miFactura.Total = pagototal;

            bool inserto = facturaDB.Guardar(miFactura, listadetalles);

            if (inserto)
            {
                LimpiarControles();
                IdentidadtextBox.Focus();
                MessageBox.Show("Factura Registrada Correctamente");
            }
            else
            {
                MessageBox.Show("No se Pudo Registrar la Factura");
            }

        }

        private void LimpiarControles()
        {
            miCliente = null;
            miProducto = null;
            listadetalles = null;
            FechadateTimePicker.Value = DateTime.Now;
            IdentidadtextBox.Clear();
            NombreClientetextBox.Clear();
            CodigotextBox.Clear();
            DescripcionProductotextBox.Clear();
            ExistenciatextBox.Clear();
            CantidadtextBox.Clear();
            DetalledataGridView.DataSource = null;
            SubTotaltextBox.Clear();
            ISVtextBox.Clear();
            DescuentotextBox.Clear();
            PagoTotaltextBox.Clear();
            subtotal = 0;
            isv = 0;
            descuento = 0;
            pagototal = 0;
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DescuentotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && e.KeyChar != '\b')
            {
                e.Handled = true;

            }

            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;

            }

            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(DescuentotextBox.Text))
            {
                descuento = Convert.ToDecimal(DescuentotextBox.Text);
                pagototal = pagototal - descuento;
                PagoTotaltextBox.Text = pagototal.ToString("N2");

            }
        }


    }
}