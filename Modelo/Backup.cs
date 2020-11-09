using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Backup
    {
        public int id { get; set; }
        public string NombreArchivo { get; set; }
        public string Destino { get; set; }
        public DateTime FechaHora { get; set; }


    }
}
