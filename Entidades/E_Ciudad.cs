using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Ciudad
    {
        public int cod_ciudad { get; set; }
        public String descripcion { get; set; }
        public decimal cod_departamento { get; set; }
        public bool estado { get; set; }

        public E_Ciudad(int cod_ciudad, string descripcion, int cod_departamento, bool estado)
        {
            this.cod_ciudad = cod_ciudad;
            this.descripcion = descripcion;
            this.cod_departamento = cod_departamento;
            this.estado = estado;
        }

        public E_Ciudad() { }
    }
}
