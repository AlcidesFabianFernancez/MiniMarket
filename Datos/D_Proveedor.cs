using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Proveedor
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
                MySqlCommand command = new MySqlCommand("usp_listar_proveedor", mysql);
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
        public string guardarActualizar(int opcion, E_Proveedores entidades)
        {
            string mensaje = "";
            MySqlConnection mysql = new MySqlConnection();
            //MySqlDataReader resultado;

            try
            {
                mysql = Conexion.getInstancia().crearConexion();
                MySqlCommand command = new MySqlCommand("usp_guardar_proveedor", mysql);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("opcion", MySqlDbType.Int64).Value = opcion;
                command.Parameters.Add("codigo", MySqlDbType.Int64).Value = entidades.codigo;
                command.Parameters.Add("cod_tipo_doc", MySqlDbType.Int64).Value = entidades.tipodocumentos;
                command.Parameters.Add("nro_doc", MySqlDbType.VarChar).Value = entidades.nro_documento;
                command.Parameters.Add("razon_social", MySqlDbType.VarChar).Value = entidades.razon_social;
                command.Parameters.Add("nombre", MySqlDbType.VarChar).Value = entidades.nombre;
                command.Parameters.Add("apellido", MySqlDbType.VarChar).Value = entidades.apellido;
                command.Parameters.Add("cod_sexo", MySqlDbType.Int64).Value = entidades.cod_sexo;
                command.Parameters.Add("cod_rubro", MySqlDbType.Int64).Value = entidades.cod_rubro;
                command.Parameters.Add("correo", MySqlDbType.VarChar).Value = entidades.correo;
                command.Parameters.Add("telefono", MySqlDbType.VarChar).Value = entidades.telefono;
                command.Parameters.Add("movil", MySqlDbType.VarChar).Value = entidades.movil;
                command.Parameters.Add("direccion", MySqlDbType.VarChar).Value = entidades.direccion;
                command.Parameters.Add("cod_ciudad", MySqlDbType.VarChar).Value = entidades.cod_ciudad;
                command.Parameters.Add("observacion", MySqlDbType.VarChar).Value = entidades.observacion;
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
                string sql = "select max(cod_proveedor)+1 as codigo from proveedor;";
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
                MySqlCommand command = new MySqlCommand("usp_listado_proveedor", mysql);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("texto", MySqlDbType.VarChar).Value = valor;
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
        /// Cargar Sexo para comboBox en Formulario
        /// </summary>
        /// <returns></returns>
        public DataTable cargarSexo()
        {
            DataTable sexo = new DataTable();
            MySqlConnection mysql = new MySqlConnection();
            try
            {
                string sql = "select cod_sexo, descripcion from sexo";
                mysql = Conexion.getInstancia().crearConexion();
                MySqlCommand command = new MySqlCommand(sql, mysql);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                adapter.Fill(sexo);
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Error cargarSexo"+e.Message);
            }
            finally
            {
                if (mysql.State == ConnectionState.Open) mysql.Close();
            }
            return sexo;
        }


        /// <summary>
        /// Listado tipo Documento
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public DataTable listado_Tipo_Doc(string valor)
        {
            //MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection mysql = new MySqlConnection();

            try
            {
                mysql = Conexion.getInstancia().crearConexion();
                MySqlCommand command = new MySqlCommand("usp_listar_tipoDoc_proveedor", mysql);
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

        /// <summary>
        /// Listado de ciudad
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public DataTable listado_ciudad(string valor)
        {
            //MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection mysql = new MySqlConnection();

            try
            {
                mysql = Conexion.getInstancia().crearConexion();
                MySqlCommand command = new MySqlCommand("usp_listar_ciudad_proveedor", mysql);
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

        /// <summary>
        /// Listado rubro
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public DataTable listado_rubro(string valor)
        {
            //MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection mysql = new MySqlConnection();

            try
            {
                mysql = Conexion.getInstancia().crearConexion();
                MySqlCommand command = new MySqlCommand("usp_listar_rubro_proveedor", mysql);
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
