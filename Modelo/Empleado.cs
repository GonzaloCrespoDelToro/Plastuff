using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Empleado
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dni { get; set; }
        public DateTime fechanac { get; set; }
        public string mail { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
    }
}
