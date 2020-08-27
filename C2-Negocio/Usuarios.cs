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

        public string Nombre;
        public string Contraseña;
        public string DVH;
        public int UsuID;

        void Alta_Usuario()
        {

        }

        void Baja_Usuario()
        {

        }

        void Modificar_Usuario()
        {
            
        }

        // 1 = Acceso Exitoso
        // 2 = Bloqueado
        // 3 = Error Usuario o Pass
        public int Verificar_Usu_Pass(string usu, string pass)
        {
            string usuE = encriptacion.Encriptar(usu, 2);
            string passE = encriptacion.Encriptar(pass, 1);

            accesoSQL.Armar_Conexion();
            string UsuBD = accesoSQL.Ejecutar_Query("ExecuteScalar", "SELECT ID FROM Usuarios WHERE Nombre='" + usuE + "'");
            string PassDB = accesoSQL.Ejecutar_Query("ExecuteScalar", "SELECT Pass FROM Usuarios WHERE Nombre='" + usuE + "'");
            
            if (UsuBD != null)
            {
                if (passE != PassDB)
                {
                    return 3;
                }
                string bloq = accesoSQL.Ejecutar_Query("ExecuteScalar", "SELECT Bloqueado FROM Usuarios WHERE Nombre='" + usuE + "'");
                if (!Convert.ToBoolean(bloq))
                {
                    return 1;
                }
                return 2;
            }
            return 3;
        }
    }
}
