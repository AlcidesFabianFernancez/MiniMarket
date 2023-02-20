using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_UnidadMedidas
    {
        public int codigo { get; set; }
        public string abreviatura { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }

        public E_UnidadMedidas(int codigo, string abreviatura, string descripcion, bool estado)
        {
            this.codigo = codigo;
            this.abreviatura = abreviatura;
            this.descripcion = descripcion;
            this.estado = estado;
        }   

        public E_UnidadMedidas() { }
    }
}
