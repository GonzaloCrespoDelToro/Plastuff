using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Modelo;

namespace C2_Negocio
{
    public class Filamentos
    {
        Acceso_Datos.FilamentoAD _FilamentoAD = new Acceso_Datos.FilamentoAD();

        public void Alta_TipoFilamento(Modelo.TipoFilamento tipoFilamento)
        {
            _FilamentoAD.Alta_TipoFilamento(tipoFilamento);
        }

        public List<Modelo.TipoFilamento> ListarTipoFilamento()
        {
            return _FilamentoAD.ListarTipoFilamento();
        }

        public bool Validacion(Object obj)
        {
            try
            {
                foreach (PropertyInfo pi in obj.GetType().GetProperties())
                {
                    if (pi.Name != "ID")
                    {
                        string value = (string)pi.GetValue(obj).ToString();
                        if (String.IsNullOrEmpty(value) || value == "0")
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public TipoFilamento TraerTipoFilamentoPorTipo(TipoFilamento tipoFilamento)
        {
            return _FilamentoAD.TraerTipoFilamento(tipoFilamento);
        }

        public bool Baja(TipoFilamento tipoFilamento)
        {
            try
            {
                if (_FilamentoAD.Baja(tipoFilamento))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Modificar_TipoFilamento(TipoFilamento tipoFilamento)
        {
            try
            {
                _FilamentoAD.Modificar_TipoFilamento(tipoFilamento);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
