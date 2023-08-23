using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public  class E_Departamento
    {
        public int cod_departamento { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }

        public E_Departamento(int codigo, string descripcion, bool estado)
        {
            this.descripcion = descripcion;
            this.cod_departamento= codigo;  
            this.estado = estado;   
        }

        public E_Departamento() { }
    }
}
