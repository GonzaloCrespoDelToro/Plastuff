using System;
using System.Collections.Generic;
using System.Text;

namespace Servicios
{
    public class SessionManager
    {
        private static SessionManager _session;

        public Modelo.Usuario Usuario { get; set; }


        public static SessionManager Getinstance
        {
            get
            {
                return _session;
            }
        }

        public static void Login(Modelo.Usuario usuario)
        {
            if (_session == null)
            {
                _session = new SessionManager();
                _session.Usuario = usuario;
            }
        }

        public static void Logout()
        {
            if (_session != null)
            {
                _session = null;
            }
        }
    }
}
