using Acceso_Datos;
using Modelo;
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
        Verificadores _Verificador = new Verificadores();
        Modelo.Digito_Vertical DVV = new Modelo.Digito_Vertical();

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

        public void CerrarSesion()
        {
            SessionManager.Logout();
        }


        // 1 = Acceso Exitoso
        // 2 = Bloqueado
        // 3 = Error Usuario o Pass
        public int Verificar_Usu_Pass(Modelo.Usuario usuario)
        {
            string passE = _encriptacion.Encriptar(usuario.Pass, 1);
            DVV.Tabla = "Usuarios";
            Modelo.Usuario UserDB = new Modelo.Usuario();
            UserDB = _UsuarioAD.GetUserByName(usuario);
            string[] datos;

            if (passE != UserDB.Pass)
            {
                if (!_UsuarioAD.Verificar_Bloq(UserDB))
                {
                    if (UserDB.Intentos < 3)
                    {
                        UserDB.Intentos = UserDB.Intentos + 1;
                        datos = new string[] { UserDB.Nombre, UserDB.Pass, UserDB.Intentos.ToString(), UserDB.bloqueado.ToString(), UserDB.Empleado.id.ToString(), UserDB.Idioma.id.ToString() };
                        UserDB.DVH = _Verificador.CalcularDVH(datos);
                        _UsuarioAD.AumentarResetear_Contador(UserDB);
                        _Verificador.Recalcular_DVV(DVV);
                        return 3;
                    }
                    UserDB.bloqueado = true;
                    UserDB.Intentos = 0;
                    datos = new string[] { UserDB.Nombre, UserDB.Pass, UserDB.Intentos.ToString(), UserDB.bloqueado.ToString(), UserDB.Empleado.id.ToString(), UserDB.Idioma.id.ToString() };
                    UserDB.DVH = _Verificador.CalcularDVH(datos);
                    _UsuarioAD.Bloquear_Usu(UserDB);
                    _Verificador.Recalcular_DVV(DVV);
                    return 2;
                }
                return 2;
            }

            bool bloq = _UsuarioAD.Verificar_Bloq(usuario);
            if (!Convert.ToBoolean(bloq))
            {
                if (UserDB.Intentos > 0)
                {
                    UserDB.Intentos = 0;
                    datos = new string[] { UserDB.Nombre, UserDB.Pass, UserDB.Intentos.ToString(), UserDB.bloqueado.ToString(), UserDB.Empleado.id.ToString(), UserDB.Idioma.id.ToString() };
                    UserDB.DVH = _Verificador.CalcularDVH(datos);
                    _UsuarioAD.AumentarResetear_Contador(UserDB);
                    _Verificador.Recalcular_DVV(DVV);
                }
                
                SessionManager.Login(UserDB);
                //SessionManager session = SessionManager.Getinstance;
                return 1;
            }

            return 2;
        }

        public Usuario GetUserByName(Modelo.Usuario User)
        {
           return _UsuarioAD.GetUserByName(User);
        }
    }
}
