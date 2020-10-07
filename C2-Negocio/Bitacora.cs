using Acceso_Datos;
using Servicios;
using System;
using System.Collections.Generic;
using System.Text;

namespace C2_Negocio
{
    public class Bitacora
    {
        BitacoraAD _bitacoraAD = new BitacoraAD();
        Encriptacion _encriptacion = new Encriptacion();
        Verificadores _verificadores = new Verificadores();

        public void Alta(Modelo.Bitacora bitacora)
        {
            try
            {
                Modelo.Digito_Vertical DigitoVertical = new Modelo.Digito_Vertical();
                DigitoVertical.Tabla = "Bitacora";
                bitacora.Descripcion = _encriptacion.Encriptar(bitacora.Descripcion, 2);
                string[] datos = { bitacora.Accion, bitacora.Descripcion, bitacora.Criticidad.ToString(), bitacora.FechaHora.ToString(), bitacora.U_id.ToString() };
                bitacora.DVH = _verificadores.CalcularDVH(datos);
                _bitacoraAD.Alta(bitacora);

                _verificadores.Recalcular_DVV(DigitoVertical);
            }
            catch (Exception ex)
            {
                string error = ex.ToString();
            }
        }
    }
}
