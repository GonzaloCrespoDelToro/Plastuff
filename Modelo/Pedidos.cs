using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Pedidos
    {
        public int ID { get; set; }
        public Modelo.Cotizacion Cotizacion { get; set; }
        public Modelo.Estados Estados { get; set; }
        public DateTime Fecha { get; set; }
    }
}
