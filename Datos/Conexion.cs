using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos
{
     public  class Conexion
    {
        MySqlConnection conexion = new MySqlConnection();

        private bool seguridad;
        //string cadenaconexion;
        private string servidor;
        private string bd;
        private string user;
        private string pass;
        private string puerto;
        private static Conexion con = null;

        public Conexion()
        {
           
        }


        public MySqlConnection crearConexion()
        {
            this.servidor = "localhost";
            this.bd = "minimarket";
            this.user = "root";
            this.pass = "1234";
            this.puerto = "3306";
            this.seguridad = false;
            MySqlConnection mysql;
            string mensaje = "";
            try
            {
                string valor = "Server=" + servidor + "; User=" + user + ";Password=" + pass + ";Port=" + puerto + "; database=" + bd + ";";
                mysql = new MySqlConnection(valor);
                mysql.Open();
                mensaje = "Se ha realizado la conexion123";
            }catch(Exception e)
            {
                mensaje = "No se ha podido reealizar la conexion " + e;
                mysql = null;
                throw e;
            }
            return mysql;
        }
        
        public static Conexion getInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }
    }
}
