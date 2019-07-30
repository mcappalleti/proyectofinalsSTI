using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosTI.BL
{
    public class ProductosBL
    {
        
        public List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Auriculares";
            producto1.Precio = 500.00;

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Usb";
            producto2.Precio = 600.00;

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Baterias";
            producto3.Precio = 500.0;

            var listadeproductos = new List<Producto>();

            listadeproductos.Add(producto1);
            listadeproductos.Add(producto2);
            listadeproductos.Add(producto3);

            return listadeproductos;

    }

      
    }
}
