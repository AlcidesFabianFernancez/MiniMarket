using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Producto
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
            D_Productos datos = new D_Productos();
            return datos.listado();
        }

        //guardar o actualizar categoria
        public static string guardarActualizar(int opcion, E_Productos entidades)
        {

            D_Productos datos = new D_Productos();
            return datos.guardarActualizar(opcion, entidades);
        }

        //obtener siguiente codigo de categoria
        public static string sgteCod()
        {
            D_Productos datos = new D_Productos();
            return datos.sigteCod();
        }

        //eliminar una categoria
        public static string eliminar(int codigo)
        {

            D_Productos datos = new D_Productos();
            return datos.eliminar(codigo);
        }

        //listar categoria por descripcion
        public static DataTable listar_Decripcion(String valor)
        {
            D_Productos datos = new D_Productos();
            return datos.listado_Descripcion(valor);
        }

        public static DataTable listar_Decripcion_mar(String valor)
        {
            D_Productos datos = new D_Productos();
            return datos.listado_Descripcion_mar(valor);
        }
        public static DataTable listar_Decripcion_uni(String valor)
        {
            D_Productos datos = new D_Productos();
            return datos.listado_Descripcion_uni(valor);
        }

        public static DataTable listar_Decripcion_ca(String valor)
        {
            D_Productos datos = new D_Productos();
            return datos.listado_Descripcion_ca(valor);
        }

        public static DataTable stock_Producto(int valor)
        {
            D_Productos datos = new D_Productos();
            return datos.stock_Producto(valor);
        }
    }
}
