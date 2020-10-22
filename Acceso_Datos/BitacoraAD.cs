using System;
using System.Collections.Generic;
using System.Data;
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
                _AccesoSQL.Ejecutar_Query("ExecuteNonQuery", "INSERT INTO Bitacora VALUES('" + bitacora.Accion + "','" + bitacora.Descripcion + "'," + bitacora.Criticidad.ToString() + ",'" + bitacora.FechaHora + "'," + bitacora.U_id + ",'" + bitacora.DVH + "')");
            }
            catch(Exception ex)
            {
                string error = ex.ToString();
            }
    }

        public List<Modelo.Bitacora> Listar_Bitacora()
        {
            try
            {
                List<Modelo.Bitacora> ListBitacora = new List<Modelo.Bitacora>();

                DataSet BitacoraDS = _AccesoSQL.Consultar_DS("SELECT b.Accion, b.Descripcion, c.Descripcion AS Criticidad, b.FechaHora, u.Nombre AS Usuario from Bitacora b inner join Criticidad c on b.ID_Criticidad = c.ID inner join Usuarios u on b.U_id = u.ID ", "Bitacora");
                foreach (DataRow row in BitacoraDS.Tables[0].Rows)
                {
                    Modelo.Bitacora Bitacora = new Modelo.Bitacora();
                    Bitacora.Accion = row["Accion"].ToString();
                    Bitacora.Descripcion = row["Descripcion"].ToString();
                    Bitacora.CriticidadNombre = row["Criticidad"].ToString();
                    Bitacora.FechaHora =Convert.ToDateTime(row["FechaHora"].ToString());
                    Bitacora.Usuario = row["Usuario"].ToString();

                    ListBitacora.Add(Bitacora);
                }
                return ListBitacora;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

    }
}
