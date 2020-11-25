using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Modelo;

namespace Acceso_Datos
{
    public class FamiliasAD
    {
        Acceso_Datos.AccesoSQL _AccesoSQL = new AccesoSQL();
        public bool Consistencia(Familia familia)
        {
            try
            {
                var id = _AccesoSQL.Ejecutar_Query("ExecuteScalar", $"SELECT ID FROM Permisos WHERE Nombre = '{familia.Nombre.ToLower()}' AND Familia = '{familia.Familia}'");
                if (string.IsNullOrEmpty(id))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Alta(Familia familia)
        {
            try
            {
                var consulta = _AccesoSQL.Ejecutar_Query("ExecuteNonQuery", $"INSERT INTO Permisos " +
                    $"VALUES('{familia.Nombre}', '{familia.Familia}', '{familia.Descripcion}', '{familia.DVH}')");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Modelo.Familia> ListarFamilias()
        {
            try
            {
                List<Modelo.Familia> familias = new List<Familia>();
                DataSet FamiliasDS = _AccesoSQL.Consultar_DS("SELECT ID, Nombre, Familia, Descripcion, DVH FROM Permisos WHERE Familia = 'True' ", "Permisos");
                foreach (DataRow row in FamiliasDS.Tables[0].Rows)
                {
                    Modelo.Familia familia = new Familia();
                    familia.ID = Convert.ToInt32(row["ID"].ToString());
                    familia.Nombre = row["Nombre"].ToString();
                    familia.Familia = Convert.ToBoolean(row["Familia"].ToString());
                    familia.Descripcion = row["Descripcion"].ToString();
                    familia.DVH = row["DVH"].ToString();

                    ConsultarPatentes(familia);

                    familias.Add(familia);
                }
                return familias;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public void ConsultarPatentes(Modelo.Familia familia)
        {
            string consulta = $"SELECT c.ID, c.Nombre, c.Familia, c.Descripcion, c.DVH FROM Fam_Per fp " +
                $"INNER JOIN Permisos p on p.Id = fp.ID_Fam " +
                $"INNER JOIN Permisos c on c.Id = fp.ID_Per " +
                $"WHERE p.id = {familia.ID }";

            DataSet PatentesDS = _AccesoSQL.Consultar_DS(consulta, "Fam_Per");

            foreach (DataRow row in PatentesDS.Tables[0].Rows)
            {
                Modelo.Patente patente = new Patente();
                patente.ID = int.Parse(row["Id"].ToString());
                patente.Nombre = (row["Nombre"].ToString());
                patente.Familia = (bool)row["Familia"];
                patente.Descripcion = row["Descripcion"].ToString();
                patente.DVH = row["DVH"].ToString();
                familia.Agregar(patente);
            }
        }

        public void Baja(Familia familia)
        {
            _AccesoSQL.Ejecutar_Query("ExecuteNonQuery", $"DELETE FROM Permisos WHERE ID = {familia.ID} ");
        }

        public void DesasignarPatente(Familia familia, Patente patente)
        {
            string consulta = _AccesoSQL.Ejecutar_Query("ExecuteNonQuery", $"DELETE FROM Fam_Per WHERE ID_Fam = {familia.ID} AND ID_Per = {patente.ID}");
        }

        public void AsignarUsuario(Usuario usuario, Familia familia)
        {
            try
            {
                var consulta = _AccesoSQL.Ejecutar_Query("ExecuteNonQuery", $"INSERT INTO Usu_Per VALUES({usuario.id}, {familia.ID})");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ObtUsuAsignados(Familia familia)
        {
            string consulta = $"SELECT COUNT(u.id) FROM Usu_Per up " +
                $"INNER JOIN Usuarios u ON u.ID = up.ID_U " +
                $"INNER JOIN Permisos p ON p.ID = up.ID_P " +
                $"WHERE p.ID = {familia.ID }";

            return Convert.ToInt32(_AccesoSQL.Ejecutar_Query("ExecuteScalar", consulta));
        }

        public void AsignarPatente(Familia familia, Patente patente)
        {
            try
            {
                var consulta = _AccesoSQL.Ejecutar_Query("ExecuteNonQuery", $"INSERT INTO Fam_Per VALUES({familia.ID}, {patente.ID})");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Familia TraeFamilia(Permiso permiso)
        {
            Modelo.Familia _Familia = new Familia();
            DataSet PatenteDS = _AccesoSQL.Consultar_DS($"SELECT ID, Nombre, Familia, Descripcion, DVH FROM Permisos WHERE Familia = 1 AND Nombre = '{permiso.Nombre}'", "Permisos");
            _Familia.ID = Convert.ToInt32(PatenteDS.Tables[0].Rows[0]["ID"].ToString());
            _Familia.Nombre = PatenteDS.Tables[0].Rows[0]["Nombre"].ToString();
            _Familia.Familia = Convert.ToBoolean(PatenteDS.Tables[0].Rows[0]["Familia"].ToString());
            _Familia.Descripcion = PatenteDS.Tables[0].Rows[0]["Descripcion"].ToString();
            _Familia.DVH = PatenteDS.Tables[0].Rows[0]["DVH"].ToString();

            ConsultarPatentes(_Familia);

            return _Familia;
        }

        public void DesasignarUsuario(Usuario usuario, Permiso permiso)
        {
            string Consulta = $"DELETE FROM Usu_Per WHERE ID_U = {usuario.id} AND ID_P = {permiso.ID}";
            _AccesoSQL.Ejecutar_Query("ExecuteNonQuery", Consulta);
        }
    }
}
