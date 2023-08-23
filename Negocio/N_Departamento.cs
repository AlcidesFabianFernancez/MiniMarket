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
     public class N_Departamento
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
            D_Departamento datos = new D_Departamento();
            return datos.listado();
        }

        //guardar o actualizar categoria
        public static string guardarActualizar(int opcion, E_Departamento entidades)
        {

            D_Departamento datos = new D_Departamento();
            return datos.guardarActualizar(opcion, entidades);
        }

        //obtener siguiente codigo de categoria
        public static string sgteCod()
        {
            D_Departamento datos = new D_Departamento();
            return datos.sigteCod();
        }

        //eliminar una categoria
        public static string eliminar(int codigo)
        {

            D_Departamento datos = new D_Departamento();
            return datos.eliminar(codigo);
        }

        //listar categoria por descripcion
        public static DataTable listar_Decripcion(String valor)
        {
            D_Departamento datos = new D_Departamento();
            return datos.listado_Descripcion(valor);
        }
    }
}
