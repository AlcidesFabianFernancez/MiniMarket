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
    public class N_UnidadMedidas
    {

        Conexion conexion = new Conexion();

        //prueba de conexion
        public String pruebaConexion()
        {
            String mensaje = "" + conexion.crearConexion();
            return mensaje;
        }

        //listar tabla
        public static DataTable listado_um()
        {
            D_UnidadMedidas datos = new D_UnidadMedidas();
            return datos.listado_um();
        }

        //guardar o actualizar categoria
        public static string guardarActualizar(int opcion, E_UnidadMedidas clase)
        {

            D_UnidadMedidas datos = new D_UnidadMedidas();
            return datos.guardarActualizar(opcion, clase);
        }

        //obtener siguiente codigo de categoria
        public static string sgteCod()
        {
            D_UnidadMedidas datos = new D_UnidadMedidas();
            return datos.sigteCodigo();
        }

        //eliminar una categoria
        public static string eliminar(int codigo)
        {

            D_UnidadMedidas datos = new D_UnidadMedidas();
            return datos.eliminar(codigo);
        }

        //listar categoria por descripcion
        public static DataTable listarxDecripcion(String valor)
        {
            D_UnidadMedidas datos = new D_UnidadMedidas();
            return datos.listado_unidadmedidaxDescripcion(valor);
        }
    }
}
