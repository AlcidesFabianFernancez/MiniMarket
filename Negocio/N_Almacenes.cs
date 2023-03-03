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
    public class N_Almacenes
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
            D_Almacen  datos = new D_Almacen();
            return datos.listado();
        }

        //guardar o actualizar categoria
        public static string guardarActualizar(int opcion, E_Almacen almacen)
        {

            D_Almacen  datos = new D_Almacen();
            return datos.guardarActualizar(opcion, almacen);
        }

        //obtener siguiente codigo de categoria
        public static string sgteCod()
        {
            D_Almacen datos = new D_Almacen();
            return datos.sigteCod();
        }

        //eliminar una categoria
        public static string eliminar(int codigo)
        {

            D_Almacen datos = new D_Almacen();
            return datos.eliminar(codigo);
        }

        //listar categoria por descripcion
        public static DataTable listar_Decripcion(String valor)
        {
            D_Almacen datos = new D_Almacen();
            return datos.listado_Descripcion(valor);
        }
    }
}
