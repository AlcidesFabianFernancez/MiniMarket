using Datos;
using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Proveedor
    {
        Conexion conexion = new Conexion();

        //prueba de conexion
        public String pruebaConexion()
        {
            String mensaje = "" + conexion.crearConexion();
            return mensaje;
        }

        //listar tabla
        public static DataTable listado()
        {
            D_Proveedor datos = new D_Proveedor();
            return datos.listado();
        }

        //guardar o actualizar 
        public static string guardarActualizar(int opcion, E_Proveedores entidades)
        {

            D_Proveedor datos = new D_Proveedor();
            return datos.guardarActualizar(opcion, entidades);
        }

        //obtener siguiente codigo 
        public static string sgteCod()
        {
            D_Proveedor datos = new D_Proveedor(); ;
            return datos.sigteCod();
        }

        //eliminar 
        public static string eliminar(int codigo)
        {

            D_Proveedor datos = new D_Proveedor();
            return datos.eliminar(codigo);
        }

        //listar  por descripcion
        public static DataTable listar_Decripcion(String valor)
        {
            D_Proveedor datos = new D_Proveedor();
            return datos.listado_Descripcion(valor);
        }

        //cargar sexo
        public static DataTable cargarSexo()
        {
            D_Proveedor datos = new D_Proveedor();
            return datos.cargarSexo();
        }

        //buscar tipo documento
        public static DataTable listado_Tipo_Doc(String valor)
        {
            D_Proveedor datos = new D_Proveedor();
            return datos.listado_Tipo_Doc(valor);
        }

        //buscar ciudad
        public static DataTable listado_barrio(String valor)
        {
            D_Proveedor datos = new D_Proveedor();
            return datos.listado_barrio(valor);
        }

        //buscar rubro
        public static DataTable listado_rubro(String valor)
        {
            D_Proveedor datos = new D_Proveedor();
            return datos.listado_rubro(valor);
        }

    }   
}
