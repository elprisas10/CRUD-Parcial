using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_2
{
    public partial class CuentaN : Form
    {
        public CuentaN()
        {
            InitializeComponent();
        }

        private void CuentaN_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(txtContra.Text != txtConfirmar.Text )
            {
                MetroFramework.MetroMessageBox.Show(this,
                    "Las contraseñas no coinciden", "Cuenta Nueva", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtNombre.Text == "")
            {
                txtNombre.Focus();
                ErrorProvider.Equals(txtNombre, "No ha escrito el nombre");
            }
            else if (txtApellido.Text == "")
            {
                txtApellido.Focus();
                ErrorProvider.Equals(txtApellido, "No ha escrito el Apellido");
            }
            else if (txtCorreo.Text == "")
            {
                txtCorreo.Focus();
                ErrorProvider.Equals(txtCorreo, "No ha escrito el Correo");
            }
            else if (txtUsurio.Text == "")
            {
                txtUsurio.Focus();
                ErrorProvider.Equals(txtUsurio, "No ha escrito el Usuario");
            }
            else if (txtContra.Text == "")
            {
                txtContra.Focus();
                ErrorProvider.Equals(txtContra, "No ha escrito la Contraseña");
            }
            else
            {
                Inicio inicio = new Inicio();

                inicio.getAll();
                inicio._Nombre = txtNombre.Text;
                inicio._Apellido = txtApellido.Text;
                inicio._Correo = txtCorreo.Text;
                inicio._Registro = DateTime.Now.ToString("dddd, dd MMM yyy HH:mm:ss");
                inicio._Usuario = txtUsurio.Text;
                inicio._Contra = txtContra.Text;
                inicio.Registro();

                MetroFramework.MetroMessageBox.Show(this,
                    "Ha sido Registrado", "Cuenta Nueva", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 form1 = new Form1();
                form1.Show();

            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {

        }
    }
}
