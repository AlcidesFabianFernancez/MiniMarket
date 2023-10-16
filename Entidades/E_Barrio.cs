using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Barrio
    {

        public int cod_barrio { get; set; }
        public String descripcion { get; set; }
        public int cod_ciudad { get; set; }
        public bool estado { get; set; }

        public E_Barrio(int cod_barrio, string descripcion, int cod_ciudad, bool estado)
        {
            this.cod_barrio = cod_barrio;
            this.descripcion = descripcion;
            this.cod_ciudad = cod_ciudad;
            this.estado = estado;
        }

        public E_Barrio() { }
    }
}
