using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Almacen
    {

        //atributos
        public int cod_almacen { get; set; }
        public string descripcion { get; set; }
        public Boolean estado { get; set; }

        public E_Almacen(int codigo, string desripcion, Boolean estado)
        {
            this.cod_almacen = codigo;
            this.descripcion = desripcion;
            this.estado = estado;
        }
        public E_Almacen() { }
    }
}
