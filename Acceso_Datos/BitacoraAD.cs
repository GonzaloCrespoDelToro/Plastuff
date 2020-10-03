using System;
using System.Collections.Generic;
using System.Text;

namespace Acceso_Datos
{
    public class BitacoraAD
{
        AccesoSQL _AccesoSQL = new AccesoSQL();

    public void Alta(Modelo.Bitacora bitacora)
    {
            try
            {
                _AccesoSQL.Ejecutar_Query("ExecuteNonQuery", "INSERT INTO Bitacora VALUES('" + bitacora.Accion + "','" + bitacora.Descripcion + "'," + "," + bitacora.Criticidad.ToString() + ",'" + bitacora.FechaHora + "'," + bitacora.U_id + ",'" + bitacora.DVH + "')");
            }
            catch(Exception ex)
            {
                string error = ex.ToString();
            }
    }

}
}
