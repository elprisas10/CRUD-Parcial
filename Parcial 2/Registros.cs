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
    public partial class Registros : Form
    {
        public Registros()
        {
            InitializeComponent();
            EliminarData();
        }

     public void Crear()
        {
            EliminarData();

            Inicio inicio = new Inicio();

            dgt2.Columns.Add("_ID", "ID");
            dgt2.Columns.Add("_Nombre", "Nombre");
            dgt2.Columns.Add("_Tiempo", "Tiempo");


            
            if (Int1.Checked)
            {
                MySqlDataReader dataReader = inicio.getLog();
                while (dataReader.Read())
                {
                    dgt2.Rows.Add(
                        dataReader.GetValue(0),
                        dataReader.GetValue(1),
                        dataReader.GetValue(2)
                      


                        );
                }

            }

            else
            {
                MySqlDataReader dataReader = inicio.getLogWithoutAdmin();
                while(dataReader.Read())
                {
                    dgt2.Rows.Add(
                        dataReader.GetValue(0),
                        dataReader.GetValue(1),
                        dataReader.GetValue(2)
                      


                        );
                }
            }
        }

        private void Registros_Load(object sender, EventArgs e)
        {
            Crear();
        }


        public void EliminarData()
        {
            dgt2.Columns.Clear();
            dgt2.Rows.Clear();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            Menu.Show();
            this.Hide();
        }

        private void Int1_CheckedChanged(object sender, EventArgs e)
        {
            Crear();
        }
    }
}
