using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
using System.Data;

namespace Negocio
{
    public class N_Categoria
    {
        Conexion conexion = new Conexion();
     
        //prueba de conexion
        public String  pruebaConexion()
        {
            String mensaje=""+conexion.crearConexion();
            return mensaje;
        }

        //listar tabla
        public static DataTable listarCategoria()
        {
            D_Categoria datos = new D_Categoria();
            return datos.listado_ca();
        }

        //guardar o actualizar categoria
        public static string guardarActualizar(int opcion, E_Categoria categoria)
        {
            
            D_Categoria datos = new D_Categoria();
            return datos.guardarActualizar(opcion, categoria);
        }

        //obtener siguiente codigo de categoria
        public static string sgteCod()
        {
            D_Categoria datos = new D_Categoria();
            return datos.sigteCod_Categoria();
        }

        //eliminar una categoria
        public static string eliminar(int codigo)
        {

            D_Categoria datos = new D_Categoria();
            return datos.eliminar(codigo);
        }

        //listar categoria por descripcion
        public static DataTable listarCategoriaxDecripcion(String valor)
        {
            D_Categoria datos = new D_Categoria();
            return datos.listado_caxDescripcion(valor);
        }
    }
}
