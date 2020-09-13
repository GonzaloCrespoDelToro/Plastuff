using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Pass { get; set; }
        public int Intentos { get; set; }
        public bool bloqueado { get; set; }
        public string DVH { get; set; }
        public Empleado Empleado { get; set; }
        public Idioma Idioma { get; set; }
        public List<Usuario> usuarios { get; set; }
    }
}
