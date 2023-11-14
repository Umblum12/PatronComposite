using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronComposite
{
    public class ProductoHoja : ProductoComponente
    {
        public string UnidadProducto {  get; set; }
        public ProductoHoja(string nombre, double precio, string unidad) : base(nombre, precio)
        {
            this.UnidadProducto = unidad;
        }
    }
}
