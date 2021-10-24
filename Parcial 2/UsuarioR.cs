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
    public partial class UsuarioR : Form
    {
        public UsuarioR()
        {
            InitializeComponent();
        }

        private void txtVer_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();

            dgtINew.Columns.Add("_ID","ID");
            dgtINew.Columns.Add("_Nombre", "Nombre");
            dgtINew.Columns.Add("_Apellido", "Apellido");
            dgtINew.Columns.Add("_Correo", "Correo");
            dgtINew.Columns.Add("_FechaRegistro", "FechaRegistro");
            dgtINew.Columns.Add("_NombreUsuario", "NombreUsuario");
            dgtINew.Columns.Add("_Contrasena", "Contrasena");

            if (btnVer.Enabled)
            {
                MySqlDataReader dataReader = inicio.LogWithoutAdmin();

                while (dataReader.Read())
                {
                    dgtINew.Rows.Add(

                        dataReader.GetValue(0),
                        dataReader.GetValue(1),
                        dataReader.GetValue(2),
                        dataReader.GetValue(3),
                        dataReader.GetValue(4),
                        dataReader.GetValue(5),
                        dataReader.GetValue(6)

                        );

                }

            }
        }

        private void btnMenuVolver_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            Menu.Show();
            this.Hide();

        }

        private void UsuarioR_Load(object sender, EventArgs e)
        {

        }
    }
}
