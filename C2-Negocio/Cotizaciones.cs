using System;
using System.Collections.Generic;
using System.Text;
using Modelo;
using Servicios;

namespace C2_Negocio
{
    public class Cotizaciones
    {
        Acceso_Datos.CotizacionAD _CotizacionAD = new Acceso_Datos.CotizacionAD();
        Servicios.Encriptacion _Encriptacion = new Servicios.Encriptacion();
        MailManager _MailManager = new MailManager();


        public Modelo.Cotizacion CalcularCotizacion(Modelo.Cotizacion cotizacion, Modelo.TipoFilamento tipoFilamento)
        {
            var tiempo = cotizacion.Tiempo;
            var gramos = cotizacion.Gramos;
            var precioKilo = tipoFilamento.Precio;
            int precioImpresion = 200; //Traer de base el precio de impresion

            cotizacion.PrecioFinal = ((((gramos * precioKilo) / 1000) * 2) + ((tiempo * precioImpresion) / 60));

            return cotizacion;
        }

        public bool Validacion(Modelo.Cotizacion cotizacion)
        {
            try
            {
                if (string.IsNullOrEmpty(cotizacion.Detalle) || cotizacion.Gramos == 0 || cotizacion.Gramos == 0 || string.IsNullOrEmpty(cotizacion.Ruta))
                {
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void ModificarEstadoPedido(Pedidos pedido)
        {
            try
            {
                _CotizacionAD.ModificarEstadoPedido(pedido);
                if (pedido.Estados.ID == 3 )
                {
                    _MailManager.EnviarMail(pedido.Cotizacion.Cliente.Mail, "Pedido Terminado", $"Su Pedido N° {pedido.ID} esta listo para ser retirado por nuestra sucursal. <br>Muchas Gracias. Plastuff");

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Alta(Modelo.Cotizacion cotizacion)
        {
            try
            {
                cotizacion.Fecha = DateTime.Now;
                _CotizacionAD.Alta(cotizacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Modelo.Cotizacion TraerCotizacionPorRuta(Modelo.Cotizacion cotizacion)
        {
            try
            {
                cotizacion = _CotizacionAD.TraerCotizacionPorRuta(cotizacion);
                return cotizacion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AceptarCotizacion(Cotizacion cotizacion)
        {
            try
            {
                _CotizacionAD.AceptarCotizacion(cotizacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Modelo.Pedidos TraerPedidoPorID(Modelo.Pedidos pedido)
        {
            var _pedido = _CotizacionAD.TraerPedidoPorID(pedido);
           _pedido.Cotizacion.Cliente.Mail = _Encriptacion.Desencriptar(_pedido.Cotizacion.Cliente.Mail);
            return _pedido;
        }

        public List<Modelo.Cotizacion> ListarCotizaciones()
        {
            try
            {
                var cotizaciones = _CotizacionAD.ListarCotizacionesPendientes();
                foreach (var C in cotizaciones)
                {
                    C.Cliente.Nombre = _Encriptacion.Desencriptar(C.Cliente.Nombre);
                    C.Cliente.Apellido = _Encriptacion.Desencriptar(C.Cliente.Apellido);
                }
                return cotizaciones;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Modelo.Pedidos> ListarPedidos()
        {
            List<Modelo.Pedidos> Pedidos = new List<Pedidos>();

            Pedidos = _CotizacionAD.ListarPedidos();
            foreach (var p in Pedidos)
            {
                p.Cotizacion.Cliente.Nombre = _Encriptacion.Desencriptar(p.Cotizacion.Cliente.Nombre);
                p.Cotizacion.Cliente.Apellido = _Encriptacion.Desencriptar(p.Cotizacion.Cliente.Apellido);
                p.Cotizacion.Cliente.Mail = _Encriptacion.Desencriptar(p.Cotizacion.Cliente.Mail);
            }

            return Pedidos;
        }

        public List<Modelo.Estados> ListarEstados()
        {
            return _CotizacionAD.ListarEstados();
        }
    }
}
