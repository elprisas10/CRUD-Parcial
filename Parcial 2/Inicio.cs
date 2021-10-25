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
            string query = "SELECT * from registro WHERE ID<>1";

            return crud.select(query);
        }

        public Boolean Registro()
        {
            string query = "INSERT INTO registro(Nombre, Apellido, Correo, FechaRegistro, NombreUsuario, Contrasena)" +
            "VALUES ('" + _Nombre + "', '" + _Apellido + "', '" + _Correo + "', '" + _Registro + "', '" + _Usuario + "', '" + _Contra + "')";
            crud.executeQuery(query);
            return true;
        }

        public Boolean Ingresar()
        {
            string query = "SELECT * FROM registro WHERE NombreUsuario='" + _Usuario + "'AND Contrasena='" + _Contra + "'";
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

        public MySqlDataReader getbyID()
        {
            string query = "SELECT * FROM registro  WHERE ID='" + _ID + "' ";
            return crud.select(query);
        }
        public MySqlDataReader getLog()
        {
            string query = " SELECT * FROM usuarios";

            return crud.select(query);
        }
        public MySqlDataReader getLogWithoutAdmin()
        {
            string query = "SELECT * FROM usuarios WHERE Nombre <> 'Admin' ";
            return crud.select(query);
        }
        public MySqlDataReader getAlldatos()
        {
            string query = "SELECT Nombre, Apellido,Correo,FechaRegistro, NombreUsuario, Contrasena FROM registro ";


            return crud.select(query);
        }
        public MySqlDataReader LogWithoutAdmin()
        {
            string query = "SELECT * FROM registro  WHERE NombreUsuario <> 'Admin' ";
            return crud.select(query);


        }


        public MySqlDataReader LogUsuary()
        {
            string query = "SELECT Nombre, Correo, NombreUsuario,FechaRegistro FROM registro ";

            return crud.select(query);
        }

        public MySqlDataReader perfil()
        {
            string query = "SELECT * FROM `registro` ";


            return crud.select(query);
        }
    }
}

