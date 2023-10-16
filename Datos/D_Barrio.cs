using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Entidades;

namespace Datos
{
    public class D_Barrio
    {


        public DataTable listado()
        {
            DataTable table = new DataTable();
            MySqlConnection mysql = new MySqlConnection();

            try
            {
                mysql = Conexion.getInstancia().crearConexion();
                MySqlCommand cmd = new MySqlCommand("usp_listar_barrio", mysql);
                cmd.CommandTimeout = 60;  //tiempo de prueba de conexion
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataSet set = new DataSet();
                adapter.Fill(set); //cargamos los datos de la base de datos al dataset
                table = set.Tables[0];
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (mysql.State == ConnectionState.Open) mysql.Close();
            }
        }


        public string guardarActualizar(int opcion, E_Barrio entidades)
        {
            string mensaje = "";
            MySqlConnection mysql = new MySqlConnection();

            try
            {
                mysql = Conexion.getInstancia().crearConexion();
                MySqlCommand command = new MySqlCommand("usp_guardar_barrio", mysql);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("opcion", MySqlDbType.Int64).Value = opcion;
                command.Parameters.Add("codigo", MySqlDbType.Int64).Value = entidades.cod_barrio;
                command.Parameters.Add("descripcionba", MySqlDbType.VarChar).Value = entidades.descripcion;
                command.Parameters.Add("codciudad", MySqlDbType.Decimal).Value = entidades.cod_ciudad;
                command.Parameters.Add("estadoba", MySqlDbType.Int64).Value = 1;

                mensaje = command.ExecuteNonQuery() == 0 ? "DATOS GUARDADOS CORRECTAMENTE" : "NO SE HA PODIDO GUARDAR LOS DATOS";
            }
            catch (Exception ex)
            {
                mensaje = "ERROR Guardar Actualizar " + ex.Message;
            }
            finally
            {
                if (mysql.State == ConnectionState.Open) mysql.Close();
            }

            return mensaje;
        }


        public string sigteCod()
        {
            string valor = "1";
            MySqlConnection mysql = new MySqlConnection();

            try
            {
                string sql = "Select max(cod_barrio)+1 as codigo from barrio";
                mysql = Conexion.getInstancia().crearConexion();
                MySqlCommand command = new MySqlCommand(sql, mysql);
                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    valor = reader["codigo"].ToString();
                }
            }
            catch (Exception ex)
            {
                valor = "ERROR " + ex;
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
                MySqlCommand command = new MySqlCommand("usp_eliminar_barrio", mysql);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("codigo", MySqlDbType.Int32).Value = codigo;

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
                MySqlCommand command = new MySqlCommand("usp_listar_barrioxdescripcion", mysql);
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


        public DataTable listado_Descripcion_edpa(string valor)
        {
            //MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection mysql = new MySqlConnection();

            try
            {
                mysql = Conexion.getInstancia().crearConexion();
                MySqlCommand command = new MySqlCommand("usp_listar_ciudadxdescripcion_ciu", mysql);
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
