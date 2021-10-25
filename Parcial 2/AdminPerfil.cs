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
    public partial class AdminPerfil : Form
    {
        public AdminPerfil()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void AdminPerfil_Load(object sender, EventArgs e)
        {



            
         
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();

            dgtAdmin.Columns.Add("_Nombre", "Nombre");
            dgtAdmin.Columns.Add("_Usuario", "Usuario");
            dgtAdmin.Columns.Add("_Correo", "Correo");
            dgtAdmin.Columns.Add("_FechaRegistro", "FechaRegistro");

            if (btnAdmin.Enabled)
            {
                MySqlDataReader dataReader = inicio.LogUsuary();
                while (dataReader.Read())
                {
                    dgtAdmin.Rows.Add(

                        dataReader.GetValue(0),
                        dataReader.GetValue(2),
                        dataReader.GetValue(1),
                        dataReader.GetValue(3)
                  


                        );
                }
            }
        }
    }
}
