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

        public int ObtUsuAsignadorPorPatFam(Patente patente, Familia familia)
        {
            string consulta = $"SELECT COUNT(u.id) FROM Usu_Per up " +
                $"INNER JOIN Usuarios u ON u.ID = up.ID_U " +
                $"INNER JOIN Permisos p ON p.ID = up.ID_P " +
                $"INNER JOIN Fam_Per fp on fp.ID_Fam  = p.ID " +
                $"WHERE fp.ID_Fam <> {familia.ID} AND fp.ID_Per = {patente.ID}";

            return Convert.ToInt32(_AccesoSQL.Ejecutar_Query("ExecuteScalar", consulta));

        }

        public void Asignar(Usuario usuario, Patente patente)
        {
            try
            {
                string consulta = _AccesoSQL.Ejecutar_Query("ExecuteNonQuery", $"INSERT INTO Usu_Per VALUES ({usuario.id}, {patente.ID})");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Desasignar(Patente patente, Usuario usuario)
        {
            try
            {
                string consulta = _AccesoSQL.Ejecutar_Query("ExecuteNonQuery", $"DELETE FROM Usu_Per WHERE ID_U = {usuario.id} AND ID_P = {patente.ID}");
            }
            catch (Exception ex)
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

        public int ObtUsuAsignadorPorPatFam(Permiso permiso, Usuario user)
        {
            string consulta = $"SELECT COUNT(u.id) FROM Usu_Per up " +
                $"INNER JOIN Usuarios u ON u.ID = up.ID_U " +
                $"INNER JOIN Permisos p ON p.ID = up.ID_P " +
                $"INNER JOIN Fam_Per fp on fp.ID_Fam  = p.ID " +
                $"WHERE fp.ID_Per = {permiso.ID} AND u.ID <> {user.id}";

            return Convert.ToInt32(_AccesoSQL.Ejecutar_Query("ExecuteScalar", consulta));
        }

        public int ObtUsuAsignados(Patente patente, Usuario usuario)
        {
            string consulta = $"SELECT COUNT(u.id) FROM Usu_Per up " +
                              $"INNER JOIN Usuarios u ON u.ID = up.ID_U " +
                              $"INNER JOIN Permisos p ON p.ID = up.ID_P " +
                              $"WHERE p.ID = {patente.ID } AND up.ID_U <> {usuario.id}";

            return Convert.ToInt32(_AccesoSQL.Ejecutar_Query("ExecuteScalar", consulta));
        }

        public int ObtUsuAsignados(Permiso permiso, Usuario usuario)
        {
            string consulta = $"SELECT COUNT(u.id) FROM Usu_Per up " +
                              $"INNER JOIN Usuarios u ON u.ID = up.ID_U " +
                              $"INNER JOIN Permisos p ON p.ID = up.ID_P " +
                              $"WHERE p.ID = {permiso.ID } AND up.ID_U <> {usuario.id}";

            return Convert.ToInt32(_AccesoSQL.Ejecutar_Query("ExecuteScalar", consulta));
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
