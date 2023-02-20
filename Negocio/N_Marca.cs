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
    public class N_Marca
    {
        Conexion conexion = new Conexion();

        //prueba de conexion
        public String pruebaConexion()
        {
            String mensaje = "" + conexion.crearConexion();
            return mensaje;
        }

        //listar tabla
        public static DataTable listarMarca()
        {
            D_Marca datos = new D_Marca();
            return datos.listado_ma();
        }

        //guardar o actualizar categoria
        public static string guardarActualizar(int opcion, E_Marca marca)
        {

            D_Marca datos = new D_Marca();
            return datos.guardarActualizar(opcion, marca);
        }

        //obtener siguiente codigo de categoria
        public static string sgteCod()
        {
            D_Marca datos = new D_Marca();
            return datos.sigteCod_Marca();
        }

        //eliminar una categoria
        public static string eliminar(int codigo)
        {

            D_Marca datos = new D_Marca();
            return datos.eliminar(codigo);
        }

        //listar categoria por descripcion
        public static DataTable listarMarcaxDecripcion(String valor)
        {
            D_Marca datos = new D_Marca();
            return datos.listado_maxDescripcion(valor);
        }
    }
}
