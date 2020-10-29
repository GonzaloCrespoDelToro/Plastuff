using System.Collections.Generic;
using System.Data;
using Modelo;

namespace Acceso_Datos
{
    public class TraductorAD
    {
        AccesoSQL _accesoSQL = new AccesoSQL();

        public List<Modelo.Traduccion> ObtenerTraducciones(Idioma idioma, Formulario formulario)
        {
            List<Modelo.Traduccion> traducciones = new List<Traduccion>();

            DataSet UserDS = _accesoSQL.Consultar_DS($"SELECT Controles.Nombre AS NombreControl, Idioma_Controles.Texto as Descripcion FROM Controles " +
                $"INNER JOIN Idioma_Controles ON Controles.ID = Idioma_Controles.C_id " +
                $"INNER JOIN Formularios ON Controles.F_id = Formularios.ID " +
                $"INNER JOIN Idiomas ON Idioma_Controles.I_id = Idiomas.ID Where Formularios.Nombre = '{formulario.Nombre}' AND Idiomas.ID = {idioma.id}", "Controles");

            foreach (DataRow row in UserDS.Tables[0].Rows)
            {
                Modelo.Traduccion traduccion = new Traduccion();
                traduccion.Etiqueta = row["NombreControl"].ToString();
                traduccion.Descripcion = row["Descripcion"].ToString();
                traducciones.Add(traduccion);
            }

            return traducciones;
        }
    }
}
