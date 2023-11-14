using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronComposite
{
    public class CarritoCompositor : ProductoComponente
    {
        private List<ProductoComponente> products = new List<ProductoComponente>();
        public CarritoCompositor(string nombre, double precio = 0) : base(nombre, precio)
        {
        }
        public double obtenerTotal
        {
            get
            {
                double total = 0;
                foreach (ProductoComponente producto in products)
                {
                    if (producto.GetType().Name == "CarritoCompositor")
                    {
                        total += ((CarritoCompositor)producto).PrecioProducto;
                    }
                    else
                    {
                        total += producto.PrecioProducto;
                    }
                }
                return total;
            }
        }
        public void AgregarProducto(ProductoComponente producto)
        {
            products.Add(producto);
        }
    }
}
