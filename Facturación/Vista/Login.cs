using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {

            if (UsuariotextBox.Text == string.Empty)
            {
                errorProvider1.SetError(UsuariotextBox, "Ingrese un Usuario");
                UsuariotextBox.Focus();
                return;

            }
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(ContraseñatextBox.Text))
            {
                errorProvider1.SetError(ContraseñatextBox, "Ingrese la Contraseña");
                ContraseñatextBox.Focus();
                return;
            }
            errorProvider1.Clear();



        }
    }
}
