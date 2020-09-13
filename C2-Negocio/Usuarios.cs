using Acceso_Datos;
using Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace C2_Negocio
{
    public class Usuarios
    {
        AccesoSQL _accesoSQL = new AccesoSQL();
        private Encriptacion _encriptacion = new Encriptacion();
        UsuarioAD _UsuarioAD = new UsuarioAD();

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

        public bool Consistencia_Nombre(Modelo.Usuario usuario)
        {
            char[] Caracteres = { '%', '&', '$', '#', '/', '-', '_', '!', 'º', 'ª', '·', '(', ')', '=', '?', '¿', '¡', '`', '^', '+', '*', ']', '{', '}', '´', 'ç', 'Ç', ',', ';', ' ' };
            if (usuario.Nombre.Length <= 15)
            {
                foreach (char i in usuario.Nombre)
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
            }
            else
            {
                return false;
            }
            return true;
        }

        public bool Check_Usu(Modelo.Usuario usuario)
        {
            usuario.Nombre = _encriptacion.Encriptar(usuario.Nombre, 2);
            if (!_UsuarioAD.Verificar_User(usuario))
            {
                return false;
            }
            return true;
        }

        public bool Check_Bloq(Modelo.Usuario usuario)
        {
            if (!_UsuarioAD.Verificar_Bloq(usuario))
            {
                return false;
            }
            return true;
        }


        // 1 = Acceso Exitoso
        // 2 = Bloqueado
        // 3 = Error Usuario o Pass
        public int Verificar_Usu_Pass(Modelo.Usuario usuario)
        {
            string usuE = _encriptacion.Encriptar(usuario.Nombre, 2);
            string passE = _encriptacion.Encriptar(usuario.Pass, 1);

            _accesoSQL.Armar_Conexion();//Lo tengo que sacar, va en inicio de sistema

            string UsuBD = _accesoSQL.Ejecutar_Query("ExecuteScalar", "SELECT ID FROM Usuarios WHERE Nombre='" + usuE + "'");
            string PassDB = _accesoSQL.Ejecutar_Query("ExecuteScalar", "SELECT Pass FROM Usuarios WHERE Nombre='" + usuE + "'");
            
            if (UsuBD != null)
            {
                if (passE != PassDB)
                {
                    return 3;
                }
                string bloq = _accesoSQL.Ejecutar_Query("ExecuteScalar", "SELECT Bloqueado FROM Usuarios WHERE Nombre='" + usuE + "'");
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
