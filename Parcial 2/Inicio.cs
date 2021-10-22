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
            string query = "SELECT * FROM parcial WHERE ID<>1";

            return crud.select(query);
        }

        public Boolean Registro()
        {
            string query = "INSERT INTO parcial(ID, Nombre, Apellido, Correo, FechaRegistro, Usuario, Contrasena)" +
            "VALUES ('" + _ID + "','" + _Nombre + "', '" + _Apellido + "', '" + _Correo + "', '" + _Registro + "', '" + _Usuario + "', '" + _Contra + "')";
            crud.executeQuery(query);
            return true;
        }

        public Boolean Ingresar()
        {
            string query = "SELECT * FROM parcial WHERE NombreUsuario='" + _Usuario + "' CONTRASEÑA='" + _Contra + "'";
            if (crud.select(query).HasRows)
            {
                return true;
            }
            return false;
        }

        public MySqlDataReader getAllLogs()
        {
            string query = "SELECT * FROM NombreUsuario WHERE ID <> 0 ";


            return crud.select(query);
        }

        public void SesionInicio()
        {
            string SesionInicio = "INSERT INTO usuarios(ID, Nombre, Tiempo) VALUES('" + _ID + "','" + _Usuario + "', '" + _Registro + DateTime.Now.ToString("dddd, dd MMM yyy HH:mm:ss") + "')";
            crud.executeQuery(SesionInicio);
        }

    }
}
