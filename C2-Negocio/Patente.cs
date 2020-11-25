using System;
using System.Collections.Generic;
using System.Linq;
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

        internal int ObtUsuAsignadorPorPatFam(Modelo.Patente patente, Familia familia)
        {
            return _patentesAD.ObtUsuAsignadorPorPatFam(patente, familia);
        }

        public bool Asignar(Usuario usuario, Modelo.Patente patente)
        {
            try
            {
                bool Consistencia = this.TienePatente(usuario, patente);
                if (Consistencia)
                {
                    return false;
                }

                _patentesAD.Asignar(usuario, patente);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool TienePatente(Usuario usuario, Modelo.Patente patente)
        {
            C2_Negocio.Usuarios _usuarios = new Usuarios();
            if(usuario.Permisos == null)
            {
                return false;
            }
            
            return _usuarios.ObtenerPermisos(usuario).Any(p => !p.Familia && p.Nombre == patente.Nombre);
        }

        public bool Desasignar(Usuario usuario, Modelo.Patente patente)
        {
            if (!ValidacionDesig(patente,usuario))
            {
                return false;
            }

            _patentesAD.Desasignar(patente, usuario);

            return true;
        }

        private bool ValidacionDesig(Modelo.Patente patente, Usuario usuario)
        {
            C2_Negocio.Familias _Familia = new Familias();

            foreach (Modelo.Familia f in _Familia.ListarFamilias())
            {
                if (f.Permisos.Any(p=> p.ID == patente.ID))
                {
                    if (_Familia.ObtUsuAsignados(f) > 0)
                    {
                        return true;
                    }
                }
            }

            if (this.ObtUsuAsignados(patente,usuario) > 0)
            {
                return true;
            }

            return false;
        }

        public int ObtUsuAsignados(Modelo.Patente patente, Usuario usuario)
        {
           return this._patentesAD.ObtUsuAsignados(patente, usuario);
        }

        public int ObtUsuAsignados(Modelo.Permiso permiso, Usuario usuario)
        {
            return this._patentesAD.ObtUsuAsignados(permiso, usuario);
        }

        internal int ObtUsuAsignadorPorPatFam(Permiso permiso, Usuario user)
        {
            return this._patentesAD.ObtUsuAsignadorPorPatFam(permiso, user);
        }
    }
}
