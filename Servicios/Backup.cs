using System;
using System.Linq;

namespace Servicios
{
    public class Backup
    {
        Acceso_Datos.BackupAD _BackupAD = new Acceso_Datos.BackupAD();
        public void RealizarBackup(Modelo.Backup backup)
        {
            _BackupAD.RealizarBackup(backup);

            _BackupAD.Alta(backup);
        }
        public bool Consistencia(string texto)
        {
            char[] Caracteres = { '%', '&', '$', '#', '!', 'º', 'ª', '·', '(', ')', '=', '?', '¿', '¡', '`', '^', '+', '*', ']', '{', '}', '´', 'ç', 'Ç', ',', ';' };

            foreach (char i in texto)
            {
                if (Caracteres.Contains(i))
                {
                    return false;
                }
                if (Char.IsNumber(i))
                {
                    return false;
                }
            }

            return true;
        }

        public string TraerUltimoBack()
        {
           return _BackupAD.TraerUltimoBack();
        }
    }
}
