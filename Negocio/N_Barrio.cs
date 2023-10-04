using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
using Entidades;

namespace Negocio
{
    public class N_Barrio
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
            D_Barrio datos = new D_Barrio();
            return datos.listado();
        }

        //guardar o actualizar categoria
        public static string guardarActualizar(int opcion, E_Barrio entidades)
        {

            D_Barrio datos = new D_Barrio();
            return datos.guardarActualizar(opcion, entidades);
        }

        //obtener siguiente codigo de categoria
        public static string sgteCod()
        {
            D_Barrio datos = new D_Barrio();
            return datos.sigteCod();
        }

        //eliminar una categoria
        public static string eliminar(int codigo)
        {

            D_Barrio datos = new D_Barrio();
            return datos.eliminar(codigo);
        }

        //listar categoria por descripcion
        public static DataTable listar_Decripcion(String valor)
        {
            D_Barrio datos = new D_Barrio();
            return datos.listado_Descripcion(valor);
        }

        public static DataTable listado_Descripcion_edpa(string valor)
        {
            D_Barrio datos = new D_Barrio();
            return datos.listado_Descripcion_edpa(valor);
        }
    }
}
}
