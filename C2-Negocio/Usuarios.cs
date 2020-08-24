using Servicios;
using System;
using System.Collections.Generic;
using System.Text;

namespace C2_Negocio
{
    public class Usuarios
    {
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
            string usuD = encriptacion.Desencriptar("HOWhzUI1ZawycIBkfYL8Uw==");
            return true;
        }

    }
}
