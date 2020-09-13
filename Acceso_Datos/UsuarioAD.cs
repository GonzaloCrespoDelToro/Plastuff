using System;
using System.Collections.Generic;
using System.Text;

namespace Acceso_Datos
{
    public class UsuarioAD
{
        AccesoSQL _accesoSQL = new AccesoSQL();

        public bool Verificar_User(Modelo.Usuario usuario)
        {
            try
            {
                string UsuBD = _accesoSQL.Ejecutar_Query("ExecuteScalar", "SELECT ID FROM Usuarios WHERE Nombre='" + usuario.Nombre + "'");

                if (UsuBD != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Verificar_Bloq(Modelo.Usuario usuario)
        {
            try
            {
                string Consulta = _accesoSQL.Ejecutar_Query("ExecuteScalar", "SELECT Bloqueado FROM Usuarios WHERE Nombre='" + usuario.Nombre + "'");
                if (!Convert.ToBoolean(Consulta))
                {
                    return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                return false;
            }

        }
    }
}
