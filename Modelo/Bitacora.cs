using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   public class Bitacora
    {
        public string Accion { get; set; }
        public string Descripcion { get; set; }
        public int Criticidad { get; set; }
        public string CriticidadNombre { get; set; }
        public DateTime FechaHora { get; set; }
        public int U_id { get; set; }
        public string Usuario { get; set; }
        public string DVH { get; set; }
    }
}
