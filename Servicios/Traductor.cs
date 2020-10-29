using System;
using System.Collections.Generic;
using System.Text;

namespace Servicios
{
    public class Traductor
{
        private Acceso_Datos.TraductorAD _TraductorAD = new Acceso_Datos.TraductorAD();

        public List<Modelo.Traduccion> ObtenerTraducciones(Modelo.Idioma idioma, Modelo.Formulario formulario)
        {
            return _TraductorAD.ObtenerTraducciones(idioma, formulario);
        }

    }
}
