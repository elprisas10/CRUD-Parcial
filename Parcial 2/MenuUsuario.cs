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
    public partial class MenuUsuario : Form
    {
        public MenuUsuario()
        {
            InitializeComponent();
        }

        private void MenuUsuario_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            UsuarioPerfil usuarioPerfil = new UsuarioPerfil();
            usuarioPerfil.Show();
            this.Hide();

        }
    }
}
