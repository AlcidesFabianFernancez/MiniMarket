using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Categoria
    {
        //atributos
        public int cod_categoria{get; set;}
        public string descripcion { get; set; }
        public Boolean estado { get; set; }


        //constructor con atributos
        public E_Categoria(int codigo, string descripcion, Boolean estado)
        {
            this.cod_categoria = cod_categoria;
            this.descripcion = descripcion;
            this.estado = estado;
        }

        //constructor vacio
        public E_Categoria()
        {

        }

    }
}
