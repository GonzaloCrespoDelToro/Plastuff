using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public abstract class Permiso
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public string DVH { get; set; }
        public bool Familia { get; set; }
    }
}
