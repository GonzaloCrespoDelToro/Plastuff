using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Familia : Permiso, IPermisoMetodos
    {
        public List<Permiso> Permisos { get; set; }

        public Familia()
        {
            this.Permisos = new List<Permiso>();
        }
        public void Agregar(Permiso permiso)
        {
            this.Permisos.Add(permiso);
        }

        public void Eliminar(Permiso permiso)
        {
            this.Permisos.Remove(permiso);
        }
    }
}
