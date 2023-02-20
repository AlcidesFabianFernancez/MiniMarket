using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class E_Marca
    {
        //atributos
        public int cod_marca { get; set; }
        public string descripcion { get; set; }
        public Boolean estado { get; set; }

        public E_Marca(int codigo, string desripcion, Boolean estado)
        {
            this.cod_marca = codigo;
            this.descripcion = desripcion;  
            this.estado = estado;
        }
        public E_Marca() { }

    }
}
