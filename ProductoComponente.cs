using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronComposite
{
    public abstract class ProductoComponente
    {
        public string NombreProducto { get; set; }
        public double PrecioProducto { get; set; }

        public ProductoComponente(string nombre, double precio)
        {
            this.NombreProducto = nombre;
            this.PrecioProducto = precio;
        }
    }
}
