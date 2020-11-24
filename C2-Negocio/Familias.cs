using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo;

namespace C2_Negocio
{
    public class Familias
    {
        Acceso_Datos.FamiliasAD _FamiliasAD = new Acceso_Datos.FamiliasAD();
        Servicios.Encriptacion _Encriptacion = new Servicios.Encriptacion();
        Servicios.Verificadores _Verificadores = new Servicios.Verificadores();

        public void Alta(Familia familia)
        {
            try
            {
                familia.Nombre = _Encriptacion.Encriptar(familia.Nombre, 2);

                string[] datos = { familia.Nombre,familia.Familia.ToString(),familia.Descripcion };
                familia.DVH = _Verificadores.CalcularDVH(datos);

                _FamiliasAD.Alta(familia);

                Modelo.Digito_Vertical DigitoVertical = new Modelo.Digito_Vertical();
                DigitoVertical.Tabla = "Permisos";
                _Verificadores.Recalcular_DVV(DigitoVertical);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Consistencia(Familia familia)
        {
            try
            {
                if (_FamiliasAD.Consistencia(familia))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Modelo.Familia> ListarFamilias()
        {
            try
            {
                var familias = _FamiliasAD.ListarFamilias();
                foreach (var f in familias)
                {
                    f.Nombre = _Encriptacion.Desencriptar(f.Nombre);
                }

                return familias;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Asignar(Familia familia, Modelo.Patente patente)
        {
            try
            {
                bool consistencia = this.TienePatente(familia, patente);

                if (consistencia)
                {
                    return false;
                }
                _FamiliasAD.AsignarPatente(familia, patente);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Desasignar(Familia familia, Modelo.Patente patente)
        {
            try
            {
                if (!ConsistenciaDesasigPat(familia, patente))
                {
                    return false;
                }
                _FamiliasAD.DesasignarPatente(familia, patente);
                return true;
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }

        private bool ConsistenciaDesasigPat(Familia familia, Modelo.Patente patente)
        {
            C2_Negocio.Patente patentes = new Patente();

            if (this.ObtUsuAsignados(familia) == 0)
            {
                return true;
            }

            foreach (Modelo.Familia item in this.ListarFamilias().Where(f => f.ID != familia.ID))
            {
                if (item.Permisos.Any(p => p.ID == patente.ID))
                {
                    if (this.ObtUsuAsignados(item) > 0)
                        return true;
                }
            }

            if (patentes.ObtUsuAsignados(patente) > 0)
            {
                return true;
            }

            return false;
        }

        private int ObtUsuAsignados(Familia familia)
        {
            return _FamiliasAD.ObtUsuAsignados(familia);
        }

        private bool TienePatente(Familia familia, Modelo.Patente patente)
        {
            if (familia.Permisos == null)
                return false;

            return familia.Permisos.Any(p => p.Nombre == patente.Nombre);
        }

        internal Modelo.Familia TraeFamilia(Permiso p)
        {
           var familia = _FamiliasAD.TraeFamilia(p);
            familia.Nombre = _Encriptacion.Desencriptar(familia.Nombre);
            return familia;
        }
    }
}
