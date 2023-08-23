using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Rubro
    {

        public int cod_rubro { get; set; } 
        public string descripcion { get; set; }
        public bool estado { get; set; }

        public E_Rubro(int codigo, string descripcion, bool estado) {
            this.cod_rubro = codigo;
            this.descripcion = descripcion; 
            this.estado = estado;
        }

        public E_Rubro() { }
    }
}
