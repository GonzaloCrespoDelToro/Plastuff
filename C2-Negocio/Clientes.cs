using System;
using System.Reflection;

namespace C2_Negocio
{
    public class Clientes
    {
        Acceso_Datos.ClienteAD _clienteAD = new Acceso_Datos.ClienteAD();
        Servicios.Encriptacion _Encriptacion = new Servicios.Encriptacion();


        public void Alta_Cliente(Modelo.Cliente cliente)
        {
            this.Encriptar(cliente);
            _clienteAD.Alta(cliente);
        }

        public bool Validacion(Modelo.Cliente cliente)
        {
            foreach (PropertyInfo pi in cliente.GetType().GetProperties())
            {
                string value = (string)pi.GetValue(cliente).ToString();
                if (String.IsNullOrEmpty(value))
                {
                    return false;
                }
            }
            return true;
        }

        private Modelo.Cliente Encriptar(Modelo.Cliente cliente)
        {
            cliente.Nombre = _Encriptacion.Encriptar(cliente.Nombre, 2);
            cliente.Apellido = _Encriptacion.Encriptar(cliente.Apellido, 2);
            cliente.Mail = _Encriptacion.Encriptar(cliente.Mail, 2);
            return cliente;
        }

        public bool Consistencia(Modelo.Cliente cliente)
        {
            if (!_clienteAD.Check_DNI(cliente))
            {
                return false;
            }
            return true;
        }

    }
}
