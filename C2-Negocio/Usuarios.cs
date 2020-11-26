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
        MailManager _MailManager = new MailManager();
        Familias _Familias = new Familias();
        C2_Negocio.Patente _Patente = new Patente();

        public string Nombre;
        public string Contraseña;
        public string DVH;
        public int UsuID;

        public bool Alta_Usuario(Modelo.Usuario usuario)
        {
            try
            {
                string Usudescrip = _encriptacion.Desencriptar(usuario.Nombre);
                string pass = GenerarPassword(10);

                usuario.Pass = _encriptacion.Encriptar(pass, 1);

                Modelo.Digito_Vertical DigitoVertical = new Modelo.Digito_Vertical();
                DigitoVertical.Tabla = "Usuarios";

                string[] datos = { usuario.Nombre, usuario.Pass, usuario.Intentos.ToString(), usuario.bloqueado.ToString(), usuario.Empleado.ID.ToString(), usuario.Idioma.id.ToString() };
                usuario.DVH = _Verificador.CalcularDVH(datos);

                var alta = _UsuarioAD.Alta(usuario);
                if (string.IsNullOrEmpty(alta))
                {
                    return false;
                }

                _Verificador.Recalcular_DVV(DigitoVertical);
                _MailManager.EnviarMail(usuario.Empleado.Mail, "Nuevo Usuario", $"Estas son tus credenciales para tu Cuenta de PlaWare:<br>Usuario: {Usudescrip}<br>Contraseña: {pass}");

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool Modificar_Pass(Usuario usuario)
        {
            try
            {
                usuario.Pass = _encriptacion.Encriptar(usuario.Pass, 1);
                Modelo.Digito_Vertical DigitoVertical = new Modelo.Digito_Vertical();
                DigitoVertical.Tabla = "Usuarios";

                string[] datos = { usuario.Nombre, usuario.Pass, usuario.Intentos.ToString(), usuario.bloqueado.ToString(), usuario.Empleado.ID.ToString(), usuario.Idioma.id.ToString() };
                usuario.DVH = _Verificador.CalcularDVH(datos);

                var modificarpass = _UsuarioAD.Modificar_Pass(usuario);

                if (!modificarpass)
                {
                    return false;
                }

                _Verificador.Recalcular_DVV(DigitoVertical);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool TieneUsuario(Modelo.Empleado selectEmp)
        {
            try
            {
                if (_UsuarioAD.TieneUsuario(selectEmp))
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string GenerarPassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890@#%&.";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        void Baja_Usuario()
        {

        }

        public bool Modificar_Usuario(Modelo.Usuario usuario)
        {
            try
            {
                Modelo.Digito_Vertical DigitoVertical = new Modelo.Digito_Vertical();
                DigitoVertical.Tabla = "Usuarios";

                string[] datos = { usuario.Nombre, usuario.Pass, usuario.Intentos.ToString(), usuario.bloqueado.ToString(), usuario.Empleado.ID.ToString(), usuario.Idioma.id.ToString() };
                usuario.DVH = _Verificador.CalcularDVH(datos);

                if (!_UsuarioAD.Modificar(usuario))
                {
                    return false;
                }

                _Verificador.Recalcular_DVV(DigitoVertical);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
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
                        datos = new string[] { UserDB.Nombre, UserDB.Pass, UserDB.Intentos.ToString(), UserDB.bloqueado.ToString(), UserDB.Empleado.ID.ToString(), UserDB.Idioma.id.ToString() };
                        UserDB.DVH = _Verificador.CalcularDVH(datos);
                        _UsuarioAD.AumentarResetear_Contador(UserDB);
                        _Verificador.Recalcular_DVV(DVV);
                        return 3;
                    }
                    UserDB.bloqueado = true;
                    UserDB.Intentos = 0;
                    datos = new string[] { UserDB.Nombre, UserDB.Pass, UserDB.Intentos.ToString(), UserDB.bloqueado.ToString(), UserDB.Empleado.ID.ToString(), UserDB.Idioma.id.ToString() };
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
                    datos = new string[] { UserDB.Nombre, UserDB.Pass, UserDB.Intentos.ToString(), UserDB.bloqueado.ToString(), UserDB.Empleado.ID.ToString(), UserDB.Idioma.id.ToString() };
                    UserDB.DVH = _Verificador.CalcularDVH(datos);
                    _UsuarioAD.AumentarResetear_Contador(UserDB);
                    _Verificador.Recalcular_DVV(DVV);
                }

                this.TraerPermisos(UserDB);
                SessionManager.Login(UserDB);
                //SessionManager session = SessionManager.Getinstance;
                return 1;
            }

            return 2;
        }

        public List<Modelo.Idioma> Listar_Idiomas()
        {
            try
            {
                var idiomas = _UsuarioAD.Listar_Idiomas();
                return idiomas;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Modelo.Usuario TraerUsuByNombre(Modelo.Usuario usuario)
        {
            try
            {
                usuario.Nombre = _encriptacion.Encriptar(usuario.Nombre, 2);
                var user = _UsuarioAD.GetUserByName(usuario);
                user.Nombre = _encriptacion.Desencriptar(user.Nombre);
                this.TraerPermisos(user);
                return user;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Modelo.Usuario> Listar_Usuarios()
        {
            try
            {
                List<Modelo.Usuario> usuarios = _UsuarioAD.Listar_usuarios();
                foreach (Modelo.Usuario user in usuarios)
                {
                    user.Nombre = _encriptacion.Desencriptar(user.Nombre);
                    this.TraerPermisos(user);
                }
                return usuarios;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Usuario GetUserByName(Modelo.Usuario User)
        {
            Modelo.Usuario usuario = _UsuarioAD.GetUserByName(User);

            this.TraerPermisos(usuario);

            return usuario;
        }

        private void TraerPermisos(Usuario usuario)
        {
            try
            {
                List<Modelo.Permiso> permisos = _UsuarioAD.TraerPermisos(usuario);

                foreach (var p in permisos)
                {
                    if (p.Familia)
                    {
                        usuario.Permisos.Add(_Familias.TraeFamilia(p));
                    }
                    else
                    {
                        usuario.Permisos.Add(_Patente.TraePatente(p));
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Baja(Usuario user)
        {
            try
            {
                if (!this.ValidarBaja(user))
                {
                    return false;
                }

                _UsuarioAD.Baja(user);

                Modelo.Digito_Vertical DigitoVertical = new Modelo.Digito_Vertical();
                DigitoVertical.Tabla = "Usuarios";

                _Verificador.Recalcular_DVV(DigitoVertical);
                
                DigitoVertical.Tabla = "Bitacora";

                _Verificador.Recalcular_DVV(DigitoVertical);

                return true;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ValidarBaja(Usuario user)
        {
            C2_Negocio.Patente _Patente = new Patente();
            C2_Negocio.Familias _Familia = new Familias();

            foreach (Modelo.Permiso permiso in user.Permisos)
            {
                if (permiso.Familia)
                {
                    permiso.Nombre = _encriptacion.Encriptar(permiso.Nombre, 2);
                    Modelo.Familia familia = _Familia.TraeFamilia(permiso);

                    foreach (Modelo.Patente patente in familia.Permisos)
                    {
                        if (_Patente.ObtUsuAsignadorPorPatFam(patente, user) == 0 && _Patente.ObtUsuAsignados(patente, user) == 0)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    if (_Patente.ObtUsuAsignadorPorPatFam(permiso, user) == 0 && _Patente.ObtUsuAsignados(permiso, user) == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public List<Modelo.Permiso> ObtenerPermisos(Modelo.Usuario usuario)
        {
            try
            {
                List<Modelo.Permiso> permisos = _UsuarioAD.TraerPermisos(usuario);
                foreach (var p in permisos)
                {
                    if (p.Familia)
                    {
                        p.Nombre = _encriptacion.Desencriptar(p.Nombre);
                    }
                }

                //foreach (var p in permisos)
                //{
                //    if (p.Familia)
                //    {
                //        usuario.Permisos.Add(_Familias.TraeFamilia(p));
                //    }
                //    else
                //    {
                //        usuario.Permisos.Add(_Patente.TraePatente(p));
                //    }
                //}

                return permisos;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
