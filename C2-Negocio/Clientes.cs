using System;
using System.Collections.Generic;
using System.Reflection;
using Modelo;

namespace C2_Negocio
{
    public class Clientes
    {
        Acceso_Datos.ClienteAD _clienteAD = new Acceso_Datos.ClienteAD();
        Servicios.Encriptacion _Encriptacion = new Servicios.Encriptacion();
        Servicios.Verificadores _verificadores = new Servicios.Verificadores();

        public void Alta_Cliente(Modelo.Cliente cliente)
        {
            this.Encriptar(cliente);
            Modelo.Digito_Vertical DigitoVertical = new Modelo.Digito_Vertical();
            DigitoVertical.Tabla = "Clientes";
            string[] datos = { cliente.Nombre, cliente.Apellido, cliente.Direccion, cliente.Fechanac.ToString(), cliente.Mail, cliente.Telefono, cliente.DNI,cliente.Baja.ToString() };
            cliente.DVH = _verificadores.CalcularDVH(datos);
            _clienteAD.Alta(cliente);
            _verificadores.Recalcular_DVV(DigitoVertical);
        }

        public bool Validacion(Modelo.Cliente cliente)
        {
            try
            {
                foreach (PropertyInfo pi in cliente.GetType().GetProperties())
                {
                    if (pi.Name != "DVH" && pi.Name != "NombreCompleto")
                    {
                        string value = (string)pi.GetValue(cliente).ToString();
                        if (String.IsNullOrEmpty(value))
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Modelo.Cliente> ListarClientes()
        {
            try
            {
                List<Modelo.Cliente> ClientesList = _clienteAD.ListarClientes();
                foreach (Modelo.Cliente cliente in ClientesList)
                {
                    cliente.Nombre = _Encriptacion.Desencriptar(cliente.Nombre);
                    cliente.Apellido = _Encriptacion.Desencriptar(cliente.Apellido);
                    cliente.Mail = _Encriptacion.Desencriptar(cliente.Mail);
                    cliente.NombreCompleto = $"{cliente.Nombre} {cliente.Apellido}";
                }

                return ClientesList;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private Modelo.Cliente Encriptar(Modelo.Cliente cliente)
        {
            cliente.Nombre = _Encriptacion.Encriptar(cliente.Nombre, 2);
            cliente.Apellido = _Encriptacion.Encriptar(cliente.Apellido, 2);
            cliente.Mail = _Encriptacion.Encriptar(cliente.Mail, 2);
            return cliente;
        }

        public void Modificar_Cliente(Cliente cliente)
        {
            this.Encriptar(cliente);
            Modelo.Digito_Vertical DigitoVertical = new Modelo.Digito_Vertical();
            DigitoVertical.Tabla = "Clientes";
            string[] datos = { cliente.Nombre, cliente.Apellido, cliente.Direccion, cliente.Fechanac.ToString(), cliente.Mail, cliente.Telefono, cliente.DNI, cliente.Baja.ToString() };
            cliente.DVH = _verificadores.CalcularDVH(datos);
            _clienteAD.Modificar(cliente);
            _verificadores.Recalcular_DVV(DigitoVertical);
        }

        public bool Consistencia(Modelo.Cliente cliente)
        {
            if (!_clienteAD.Check_DNI(cliente))
            {
                return false;
            }
            return true;
        }

        public void Baja_Logica(Cliente cliente)
        {
            try
            {
                cliente.Baja = true;
                this.Modificar_Cliente(cliente);
            }
            catch (Exception)
            {
                return;
            }
        }

        public Modelo.Cliente TraerClientePorDNI(Modelo.Cliente cliente)
        {
            cliente = _clienteAD.TraerClientePorDNI(cliente);
            cliente.Nombre = _Encriptacion.Desencriptar(cliente.Nombre);
            cliente.Apellido = _Encriptacion.Desencriptar(cliente.Apellido);
            cliente.Mail = _Encriptacion.Desencriptar(cliente.Mail);
            return cliente;
        }

    }
}
