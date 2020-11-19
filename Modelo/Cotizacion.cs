using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cotizacion
    {
        public int ID { get; set; }
        public Empleado Empleado { get; set; }
        public Cliente Cliente { get; set; }
        public Double PrecioFinal {get; set;}
        public string Ruta { get; set; }
        public DateTime Fecha { get; set; }
        public string Detalle { get; set; }

        public int Tiempo { get; set; }
        public Double Gramos { get; set; }
    }
}
