using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Proveedores
    {
        public int codigo { get; set; }   
        public int tipodocumentos { get; set; }
        public string nro_documento { get; set; }
        public string razon_social { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int cod_sexo { get; set; }
        public int cod_rubro { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public string movil { get; set; }
        public string direccion { get; set; }
        public int cod_ciudad { get; set; }
        public string observacion { get; set; }

        public E_Proveedores() { }
    }
}
