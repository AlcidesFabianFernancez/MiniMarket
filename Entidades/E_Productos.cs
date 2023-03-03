using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Productos
    {
        public int codigo { get; set; }
        public string descripcion { get; set; }
        public Decimal cod_marcas { get; set; }
        public Decimal cod_medidas { get; set; }
        public Decimal cod_categoria { get; set; }
        public Decimal stock_minimo { get; set; }
        public Decimal stock_maximo { get; set; }
        public bool estado { get; set; }
        public DateTime fecha_creacion { get; set; }
        public DateTime fecha_modificacion { get; set; }


        public E_Productos(int codigo, string descripcion, int cod_marcas, int cod_medidas, int cod_categoria, decimal stock_minimo, decimal stock_maximo, bool estado, DateTime fecha_creacion, DateTime fecha_modificacion)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.cod_marcas = cod_marcas;
            this.cod_medidas = cod_medidas;
            this.cod_categoria = cod_categoria;
            this.stock_minimo = stock_minimo;
            this.stock_maximo = stock_maximo;
            this.estado = estado;
            this.fecha_creacion = fecha_creacion;
            this.fecha_modificacion = fecha_modificacion;
        }

        public E_Productos() { }
    }
}
