using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Parcial_2
{
    class Inicio
    {
        Connection conn = new Connection();
        Crud crud = new Crud();

        public int _ID { get; set; }

        public string _Nombre { get; set; }

        public string _Apellido { get; set; }

        public string _Correo { get; set; }

        public string _Registro { get; set; }

        public string _Usuario { get; set; }

        public string _Contra { get; set; }


        public MySqlDataReader getAll()
        {
            string query = "SELECT ID,Nombre,Apellido,Correo,FechaRegistro,NombreUsuario,Contrasena FROM parcial";

            return crud.select(query);
        }

     

    }
}
