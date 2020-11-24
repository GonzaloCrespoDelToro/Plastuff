using System;
using System.Collections.Generic;
using System.Text;
using Modelo;

namespace Acceso_Datos
{
    public class BackupAD
    {
        Acceso_Datos.AccesoSQL _AccesoSQL = new Acceso_Datos.AccesoSQL();

        public void RealizarBackup(Modelo.Backup backup)
        {
            _AccesoSQL.Ejecutar_Query("ExecuteNonQuery", $"BACKUP DATABASE Plastuff TO disk= '{backup.Destino}.bak'");
        }

        public void Alta(Backup backup)
        {
            _AccesoSQL.Ejecutar_Query("ExecuteNonQuery", $"INSERT INTO Backups VALUES ('{backup.NombreArchivo}','{backup.Destino}','{backup.FechaHora}')");
        }

        public string TraerUltimoBack()
        {
            string fechahora = _AccesoSQL.Ejecutar_Query("ExecuteScalar", "SELECT FechaHora FROM Backups WHERE ID = (SELECT MAX(ID) FROM Backups)");
            return fechahora;
        }

        public void RealizarRestore(Modelo.Backup backup)
        {
            try
            {
                _AccesoSQL.Ejecutar_Query("ExecuteNonQuery", $"Use Master ALTER DATABASE Plastuff SET OFFLINE WITH ROLLBACK IMMEDIATE" +
                    $" RESTORE DATABASE Plastuff FROM DISK = '{backup.Destino}' ALTER DATABASE Plastuff SET ONLINE WITH ROLLBACK IMMEDIATE USE Plastuff");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
