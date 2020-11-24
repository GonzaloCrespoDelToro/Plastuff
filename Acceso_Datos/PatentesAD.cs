using System;
using System.Collections.Generic;
using System.Data;
using Modelo;

namespace Acceso_Datos
{
    public class PatentesAD
    {
        Acceso_Datos.AccesoSQL _AccesoSQL = new AccesoSQL();

        public List<Patente> Listar()
        {
            try
            {
                List<Patente> patentes = new List<Patente>();

                DataSet PatentesDS = _AccesoSQL.Consultar_DS("SELECT ID, Nombre, Familia, Descripcion, DVH FROM Permisos WHERE Familia = 'False' ", "Permisos");

                foreach (DataRow row in PatentesDS.Tables[0].Rows)
                {
                    Modelo.Patente patente = new Patente();
                    patente.ID = Convert.ToInt32(row["ID"].ToString());
                    patente.Nombre = row["Nombre"].ToString();
                    patente.Familia = Convert.ToBoolean(row["Familia"].ToString());
                    patente.Descripcion = row["Descripcion"].ToString();
                    patente.DVH = row["DVH"].ToString();

                    patentes.Add(patente);
                }
                return patentes;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            
        }

        public Patente TraerPatente(Permiso patente)
        {
            Modelo.Patente _Patente = new Patente();
            DataSet PatenteDS = _AccesoSQL.Consultar_DS($"SELECT ID, Nombre, Familia, Descripcion, DVH FROM Permisos WHERE Familia = 0 AND Nombre = '{patente.Nombre}'", "Permisos");
            _Patente.ID = Convert.ToInt32(PatenteDS.Tables[0].Rows[0]["ID"].ToString());
            _Patente.Nombre = PatenteDS.Tables[0].Rows[0]["Nombre"].ToString();
            _Patente.Familia = Convert.ToBoolean(PatenteDS.Tables[0].Rows[0]["Familia"].ToString());
            _Patente.Descripcion = PatenteDS.Tables[0].Rows[0]["Descripcion"].ToString();
            _Patente.DVH = PatenteDS.Tables[0].Rows[0]["DVH"].ToString();

            return _Patente;
        }

        public int ObtUsuAsignados(Patente patente)
        {
            string consulta = $"SELECT COUNT(u.id) FROM Usu_Per up " +
                $"INNER JOIN Usuarios u ON u.ID = up.ID_U " +
                $"INNER JOIN Permisos p ON p.ID = up.ID_P " +
                $"WHERE p.Familia = 0 AND p.ID = {patente.ID }";

            return Convert.ToInt32(_AccesoSQL.Ejecutar_Query("ExecuteScalar", consulta));
        }
    }
}
