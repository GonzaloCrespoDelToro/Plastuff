using System;
using System.Collections.Generic;
using System.Text;
using Modelo;

namespace C2_Negocio
{
    public class Patente
    {
        Acceso_Datos.PatentesAD _patentesAD = new Acceso_Datos.PatentesAD();
        Servicios.Encriptacion _Encriptacion = new Servicios.Encriptacion();
        Servicios.Verificadores _Verificadores = new Servicios.Verificadores();

        public List<Modelo.Patente> Listar()
        {
            var patenetes = _patentesAD.Listar();
            return patenetes;
        }

        internal int ObtUsuAsignados(Modelo.Patente patente)
        {
           return _patentesAD.ObtUsuAsignados(patente);
        }

        public Modelo.Patente TraePatente(Modelo.Permiso permiso)
        {
            return _patentesAD.TraerPatente(permiso);
        }
    }
}
