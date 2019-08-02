using Mantenimiento.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantenimiento.BL
{
    public class ProductosBL
    {
        public List<Producto> ListadeProducto { get; set; }

        public ProductosBL()
        {
            ListadeProducto = new List<Producto>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var categoria1 = new Categoria(1, "laptops");
            var categoria2 = new Categoria(2, "accesorios");

            var Producto1 = new Producto(1, "laptop Dell", 15000, categoria1);
            var Producto2 = new Producto(2, "laptops asus", 20000, categoria1);
            var Producto3 = new Producto(3, "Mouse", 200, categoria2);

            ListadeProducto.Add(Producto1);
            ListadeProducto.Add(Producto2);
            ListadeProducto.Add(Producto3);
        }
    }
}
