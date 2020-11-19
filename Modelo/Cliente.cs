using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public DateTime Fechanac { get; set; }
        public string Mail { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public bool Baja { get; set; }
        public string DVH { get; set; }
        public string NombreCompleto { get; set; }

    }
}
