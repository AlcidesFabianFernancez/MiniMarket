using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Entidades;
using Org.BouncyCastle.Bcpg.OpenPgp;

namespace Datos
{
    public class D_Categoria
    {
       

        //Nos devuelve el listado de las categorias que su estado sea verdadero
        public DataTable listado_ca()
        {
            DataTable tabla = new DataTable();
            MySqlConnection mysql= new MySqlConnection();

            try
            {
                mysql = Conexion.getInstancia().crearConexion();
                MySqlCommand command = new MySqlCommand("usp_listar_categoria", mysql);
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
            }catch(Exception e)
            {
                throw e;
            }
            finally
            {
                if (mysql.State == ConnectionState.Open) mysql.Close();
            }
        }

        //Guardar o Actualizar Categoria
        public string guardarActualizar(int opcion, E_Categoria categoria)
        {
            string mensaje = "";
            MySqlConnection mysql = new MySqlConnection();
            //MySqlDataReader resultado;

            try
            {
                mysql = Conexion.getInstancia().crearConexion();
                MySqlCommand command = new MySqlCommand("usp_guardar_categoria", mysql);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("opcion", MySqlDbType.Int64).Value = opcion;
                command.Parameters.Add("codigo", MySqlDbType.Int64).Value = categoria.cod_categoria;
                command.Parameters.Add("descripcionCa", MySqlDbType.VarChar).Value = categoria.descripcion;
                command.Parameters.Add("estadoCa", MySqlDbType.Int32).Value =1;            

                mensaje =command.ExecuteNonQuery()==0 ? "DATOS GUARDADOS CORRECTAMENTE" : "NO SE HA PODIDO GUARDAR LOS DATOS ";
            }
            catch(Exception e) {

                mensaje = "ERROR guardarActualizacion " + e;
            }
            finally
            {
                if (mysql.State == ConnectionState.Open) mysql.Close();
            }

            return mensaje;
        }

        //siguiente valor de  Codigo Categoria
        public string sigteCod_Categoria()
        {
            string valor = "";
            MySqlConnection mysql = new MySqlConnection();
            try
            {
                string sql = "select max(cod_categoria)+1 as codigo from categoria";
                mysql = Conexion.getInstancia().crearConexion();
                MySqlCommand command = new MySqlCommand(sql, mysql);
                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    valor = reader["codigo"].ToString();
                }
            }catch(Exception e)
            {
                valor = "ERROR " + e;
            }
            finally
            {
                if (mysql.State == ConnectionState.Open) mysql.Close();
            }
            return valor;
        }


        //Eliminar Categoria
        public string eliminar(int codigo)
        {
            string mensaje = "";
            MySqlConnection mysql = new MySqlConnection();
            //MySqlDataReader resultado;

            try
            {
                mysql = Conexion.getInstancia().crearConexion();
                MySqlCommand command = new MySqlCommand("usp_eliminar_categoria", mysql);
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

        //listar categoria por descripcion
        public DataTable listado_caxDescripcion(string valor)
        {
            //MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection mysql = new MySqlConnection();

            try
            {
                mysql = Conexion.getInstancia().crearConexion();
                MySqlCommand command = new MySqlCommand("usp_listar_categoriaxdescripcion", mysql);
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
