using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using Entidades;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Almacen
    {


        /// <summary>
        /// Nos devuelve el listado 
        /// </summary>
        /// <returns></returns>
        public DataTable listado()
        {
            DataTable tabla = new DataTable();
            MySqlConnection mysql = new MySqlConnection();

            try
            {
                mysql = Conexion.getInstancia().crearConexion();
                MySqlCommand command = new MySqlCommand("usp_listar_almacenes", mysql);
                command.CommandTimeout = 60;
                command.CommandType = CommandType.StoredProcedure;
                //command.Parameters.Add("texto", MySqlDbType.VarChar).Value = texto;
                //mysql.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                //resultado = command.ExecuteReader();
                DataSet set = new DataSet();
                adapter.Fill(set);
                tabla = set.Tables[0];
                return tabla;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (mysql.State == ConnectionState.Open) mysql.Close();
            }
        }

        /// <summary>
        /// Guardar o Actualizar
        /// </summary>
        /// <param name="opcion"></param>
        /// <param name="marca"></param>
        /// <returns></returns>         
        public string guardarActualizar(int opcion, E_Almacen almacen)
        {
            string mensaje = "";
            MySqlConnection mysql = new MySqlConnection();
            //MySqlDataReader resultado;

            try
            {
                mysql = Conexion.getInstancia().crearConexion();
                MySqlCommand command = new MySqlCommand("usp_guardar_al", mysql);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("opcion", MySqlDbType.Int64).Value = opcion;
                command.Parameters.Add("codigo", MySqlDbType.Int64).Value = almacen.cod_almacen;
                command.Parameters.Add("descripcion", MySqlDbType.VarChar).Value = almacen.descripcion;
                command.Parameters.Add("estado", MySqlDbType.Int32).Value = 1;

                mensaje = command.ExecuteNonQuery() == 0 ? "DATOS GUARDADOS CORRECTAMENTE" : "NO SE HA PODIDO GUARDAR LOS DATOS ";
            }
            catch (Exception e)
            {

                mensaje = "ERROR guardarActualizacion " + e;
            }
            finally
            {
                if (mysql.State == ConnectionState.Open) mysql.Close();
            }

            return mensaje;
        }

        /// <summary>
        /// siguiente valor de  Codigo 
        /// </summary>
        /// <returns></returns>
        public string sigteCod()
        {
            string valor = "";
            MySqlConnection mysql = new MySqlConnection();
            try
            {
                string sql = "select max(cod_almacen)+1 as codigo from almacenes";
                mysql = Conexion.getInstancia().crearConexion();
                MySqlCommand command = new MySqlCommand(sql, mysql);
                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    valor = reader["codigo"].ToString();
                }
            }
            catch (Exception e)
            {
                valor = "ERROR " + e;
            }
            finally
            {
                if (mysql.State == ConnectionState.Open) mysql.Close();
            }
            return valor;
        }


        /// <summary>
        /// Eliminar
        /// </summary>
        /// <returns></returns>
        public string eliminar(int codigo)
        {
            string mensaje = "";
            MySqlConnection mysql = new MySqlConnection();
            //MySqlDataReader resultado;

            try
            {
                mysql = Conexion.getInstancia().crearConexion();
                MySqlCommand command = new MySqlCommand("usp_eliminar_almacen", mysql);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("codigo", MySqlDbType.Int64).Value = codigo;

                mensaje = command.ExecuteNonQuery() == 1 ? "DATOS ELIMINADOS CORRECTAMENTE" : "NO SE HA PODIDO ELIMINAR LOS DATOS ";
            }
            catch (Exception e)
            {

                mensaje = "ERROR eliminar " + e;
            }
            finally
            {
                if (mysql.State == ConnectionState.Open) mysql.Close();
            }

            return mensaje;

        }

        /// <summary>
        /// listar por descripcion
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>

        public DataTable listado_Descripcion(string valor)
        {
            //MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection mysql = new MySqlConnection();

            try
            {
                mysql = Conexion.getInstancia().crearConexion();
                MySqlCommand command = new MySqlCommand("usp_listado_almacen", mysql);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("valor", MySqlDbType.VarChar).Value = valor;
                //mysql.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                //resultado = command.ExecuteReader();
                DataSet set = new DataSet();
                adapter.Fill(set);
                tabla = set.Tables[0];
                return tabla;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (mysql.State == ConnectionState.Open) mysql.Close();
            }
        }
    }
}
