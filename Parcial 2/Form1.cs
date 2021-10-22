using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Parcial_2
{
    public partial class Form1 : Form
    {
        public string _Contra { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Focus();
                ErrorProvider.ReferenceEquals(txtUsuario, "Debe escribir un Nombre");
            }
            else if (txtContrasena.Text =="")
            {
                txtContrasena.Focus();
                ErrorProvider.ReferenceEquals(txtContrasena, "Debe escribir una Contraseña");

            }

            Inicio cuenta = new Inicio();
            cuenta._Contra = txtContrasena.Text;

            if (cuenta.Ingresar())
            {
                MetroFramework.MetroMessageBox.Show(this,
                   "BIENVENIDO", "USUARIO YA REGISTRADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cuenta.SesionInicio();
                _Contra = txtContrasena.Text;
                MenuUsuario menuUsuario = new MenuUsuario();
                menuUsuario.Show();
                this.Hide();
            }

            else
            {
                MetroFramework.MetroMessageBox.Show(this,
                   "NOMBRE DE USUARIO O CONTRASEÑA NO REGISTRADOS ", "ENTRAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (txtUsuario.Text == "Admin")
            {
                Menu Menu = new Menu();
                Menu.Show();
                this.Hide();
            }

            else if (txtUsuario.Text == "123")
            {
                Menu Menu = new Menu();
                Menu.Show();
                this.Hide();
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            CuentaN cuentan = new CuentaN();
            cuentan.Show();
           
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿DESEA SALIR?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
         
            {

                Close();
            }
        }
    }
}
