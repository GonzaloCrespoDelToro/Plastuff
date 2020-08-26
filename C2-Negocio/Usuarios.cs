using Acceso_Datos;
using Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace C2_Negocio
{
    public class Usuarios
    {
        AccesoSQL accesoSQL = new AccesoSQL();

        private Encriptacion encriptacion = new Encriptacion();

        void Alta_Usuario()
        {

        }

        void Baja_Usuario()
        {

        }

        void Modificar_Usuario()
        {
            
        }

        public bool Verificar_Usuario(string usuario)
        {
            string usuE = encriptacion.Encriptar(usuario, 2);
            accesoSQL.Armar_Conexion();
            string Usu = accesoSQL.Ejecutar_Query("ExecuteScalar", "SELECT ID FROM Usuarios WHERE Nombre='" + usuE + "'");
            if(Usu != null)
            {
                string bloq = accesoSQL.Ejecutar_Query("ExecuteScalar", "SELECT Bloqueado FROM Usuarios WHERE Nombre='" + usuE + "'");
                if (!Convert.ToBoolean(bloq))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
