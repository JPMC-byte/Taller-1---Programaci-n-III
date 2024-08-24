using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class PersistenciaIntermedia
    {
     public bool PersistenciaProductos(bool productos)
        {
            List<(String Nombre, double Precio)> Productos = new List<(String Nombre, double Precio)>
            {
                ("Shampoo", 80.000),
                ("Cama", 210.000),
                ("Bicicleta", 556.000)
            };

            return productos;
        }
    }
}
