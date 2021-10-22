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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            AdminPerfil menu = new AdminPerfil();
             menu.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            UsuarioPerfil usuarioPerfil = new UsuarioPerfil();
            usuarioPerfil.Show();
            this.Hide();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {

        }
    }
}
