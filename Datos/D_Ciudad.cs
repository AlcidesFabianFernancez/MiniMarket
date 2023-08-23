﻿using System;
using System.Collections.Generic;
using System.Linq;
using Entidades;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class D_Ciudad
    {

        public DataTable listado()
        {
            DataTable table= new DataTable();
            MySqlConnection mysql = new MySqlConnection();

            try
            {
                mysql= Conexion.getInstancia().crearConexion();
                MySqlCommand cmd = new MySqlCommand("usp_listar_ciudad", mysql);
                cmd.CommandTimeout= 60;  //tiempo de prueba de conexion
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter adapter= new MySqlDataAdapter(cmd);

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
                if(mysql.State== ConnectionState.Open) mysql.Close(); 
            }
        }


        public string guardarActualizar(int opcion, E_Ciudad entidades)
        {
            string mensaje = "";
            MySqlConnection mysql= new MySqlConnection();

            try
            {
                mysql = Conexion.getInstancia().crearConexion();
                MySqlCommand command = new MySqlCommand("usp_guardar_ciudad", mysql);
                command.CommandType= CommandType.StoredProcedure;
                command.Parameters.Add("opcion", MySqlDbType.Int64).Value= opcion;
                command.Parameters.Add("codigo", MySqlDbType.Int64).Value = entidades.cod_ciudad;
                command.Parameters.Add("descripcion", MySqlDbType.VarChar).Value = entidades.descripcion;
                command.Parameters.Add("codepartamento", MySqlDbType.Decimal).Value = entidades.cod_departamento;
                command.Parameters.Add("estado", MySqlDbType.Int64).Value = 1;

                mensaje = command.ExecuteNonQuery() == 0 ? "DATOS GUARDADOS CORRECTAMENTE" : "NO SE HA PODIDO GUARDAR LOS DATOS";
            }
            catch(Exception ex)
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
                string sql = "Select max(cod_ciudad)+1 as codigo from ciudad";
                mysql = Conexion.getInstancia().crearConexion();
                MySqlCommand command= new MySqlCommand(sql, mysql);
                var reader = command.ExecuteReader();

                if(reader.Read())
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
                if(mysql.State == ConnectionState.Open)  mysql.Close();
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
                MySqlCommand command = new MySqlCommand("usp_eliminar_ciudad", mysql);
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
                MySqlCommand command = new MySqlCommand("usp_listado_ciudad", mysql);
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


        public DataTable listado_Descripcion_edpa(string valor)
        {
            //MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection mysql = new MySqlConnection();

            try
            {
                mysql = Conexion.getInstancia().crearConexion();
                MySqlCommand command = new MySqlCommand("usp_listar_departamentoxdescripcion_ciu", mysql);
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
