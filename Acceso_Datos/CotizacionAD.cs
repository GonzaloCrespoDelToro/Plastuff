using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Modelo;

namespace Acceso_Datos
{
    public class CotizacionAD
    {
        AccesoSQL _AccesoSQL = new AccesoSQL();

        public void Alta(Modelo.Cotizacion cotizacion)
        {
            try
            {
                _AccesoSQL.Ejecutar_Query("ExecuteNonQuery", $"INSERT INTO Cotizaciones VALUES ({cotizacion.Empleado.ID},{cotizacion.Cliente.ID}," +
                    $" '{cotizacion.PrecioFinal}', '{cotizacion.Ruta}', '{cotizacion.Fecha}', '{cotizacion.Detalle}') ");
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
                cotizacion.ID = Convert.ToInt32(_AccesoSQL.Ejecutar_Query("ExecuteScalar", $"SELECT ID FROM Cotizaciones WHERE C_ruta = '{cotizacion.Ruta}' AND C_Fecha = '{cotizacion.Fecha}' "));
                return cotizacion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Modelo.Cotizacion TraerCotizacionPorID(Modelo.Cotizacion cotizacion)
        {
            try
            {
                cotizacion.ID = Convert.ToInt32(_AccesoSQL.Ejecutar_Query("ExecuteScalar", $"SELECT ID FROM Cotizaciones WHERE ID = {cotizacion.ID} "));
                return cotizacion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ModificarEstadoPedido(Pedidos pedido)
        {
            try
            {
                _AccesoSQL.Ejecutar_Query("ExecuteNonQuery", $"UPDATE Pedidos SET E_id = {pedido.Estados.ID} WHERE ID = {pedido.ID} ");
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }

        public List<Modelo.Cotizacion> ListarCotizacionesPendientes()
        {
            try
            {
                List<Modelo.Cotizacion> cotizaciones = new List<Modelo.Cotizacion>();
                //LEFT JOIN Usuarios u on u.Emp_id = e.ID where u.Emp_id is null
                DataSet CotizacionDS = _AccesoSQL.Consultar_DS("SELECT c.ID, cl.C_nombre, cl.C_apellido, cl.C_DNI," +
                    " c.C_preciofinal, c.C_Detalle, c.C_Fecha FROM Clientes cl INNER JOIN Cotizaciones c ON cl.ID = c.C_ID left join Pedidos p on c.ID = p.C_id WHERE p.C_id IS NULL", "Cotizaciones");
                foreach (DataRow row in CotizacionDS.Tables[0].Rows)
                {
                    Modelo.Cotizacion cotizacion = new Cotizacion();
                    Modelo.Cliente cliente = new Cliente();

                    cotizacion.ID = Convert.ToInt32(row["ID"].ToString());
                    cotizacion.Detalle = row["C_Detalle"].ToString();
                    cotizacion.Fecha = Convert.ToDateTime(row["C_Fecha"].ToString());
                    cotizacion.PrecioFinal = Convert.ToDouble(row["C_preciofinal"].ToString());
                    cliente.Nombre = row["C_nombre"].ToString();
                    cliente.Apellido = row["C_apellido"].ToString();
                    cliente.DNI = row["C_DNI"].ToString();

                    cotizacion.Cliente = cliente;
                    cotizaciones.Add(cotizacion);
                }
                return cotizaciones;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Pedidos> ListarPedidos()
        {
            try
            {
                List<Pedidos> pedidos = new List<Pedidos>();

                DataSet PedidosDS = _AccesoSQL.Consultar_DS("SELECT Pedidos.ID, Clientes.C_nombre AS Nombre, Clientes.C_apellido AS Apellido, Clientes.C_mail AS Mail, Clientes.C_DNI AS DNI, Estados.E_estado AS Estado," +
                    " Cotizaciones.C_preciofinal AS PrecioFinal, Pedidos.P_Fecha AS Fecha, Estados.ID AS EstadoID FROM Pedidos " +
                    "INNER JOIN Cotizaciones ON Pedidos.C_id = Cotizaciones.ID " +
                    "INNER JOIN Clientes ON Cotizaciones.C_ID = Clientes.ID " +
                    "INNER JOIN Estados ON Pedidos.E_id = Estados.ID", "Pedidos");
                foreach (DataRow row in PedidosDS.Tables[0].Rows)
                {
                    Modelo.Pedidos pedido = new Pedidos();
                    Modelo.Cotizacion cotizacion = new Cotizacion();
                    Modelo.Cliente cliente = new Cliente();
                    Modelo.Estados estado = new Estados();

                    pedido.ID = Convert.ToInt32(row["ID"].ToString());
                    cliente.Nombre = row["Nombre"].ToString();
                    cliente.Apellido = row["Apellido"].ToString();
                    cliente.DNI = row["DNI"].ToString();
                    cliente.Mail = row["Mail"].ToString();
                    estado.Estado = row["Estado"].ToString();
                    estado.ID = Convert.ToInt32(row["EstadoID"].ToString());
                    cotizacion.PrecioFinal = Convert.ToDouble(row["PrecioFinal"].ToString());
                    pedido.Fecha = Convert.ToDateTime(row["Fecha"].ToString());

                    pedido.Cotizacion = cotizacion;
                    pedido.Cotizacion.Cliente = cliente;
                    pedido.Estados = estado;

                    pedidos.Add(pedido);
                }
                return pedidos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Estados> ListarEstados()
        {
            try
            {
                List<Modelo.Estados> estados = new List<Estados>();
                DataSet EstadosDS = _AccesoSQL.Consultar_DS("SELECT ID, E_estado FROM Estados", "Estados");
                foreach (DataRow row in EstadosDS.Tables[0].Rows)
                {
                    Modelo.Estados estado = new Estados();
                    estado.ID = Convert.ToInt32(row["ID"].ToString());
                    estado.Estado = row["E_estado"].ToString();
                    estados.Add(estado);
                }

                return estados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Modelo.Pedidos TraerPedidoPorID(Modelo.Pedidos pedido)
        {
            try
            {
                Modelo.Pedidos _pedido = new Pedidos();
                Modelo.Cliente cliente = new Cliente();
                Modelo.Cotizacion cotizacion = new Cotizacion();
                DataSet PedidosDS = _AccesoSQL.Consultar_DS($"SELECT Clientes.C_mail AS Mail, Pedidos.ID FROM Clientes " +
               $"INNER JOIN Cotizaciones ON Clientes.ID = Cotizaciones.C_ID INNER JOIN Pedidos ON Cotizaciones.ID = Pedidos.C_id where Pedidos.ID = {pedido.ID}", "Pedidos");
                _pedido.ID = Convert.ToInt32(PedidosDS.Tables[0].Rows[0]["ID"].ToString());
                cliente.Mail = PedidosDS.Tables[0].Rows[0]["Mail"].ToString();

                _pedido.Cotizacion = cotizacion;
                _pedido.Cotizacion.Cliente = cliente;
                return _pedido;
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
                _AccesoSQL.Ejecutar_Query("ExecuteNonQuery", $"INSERT INTO Pedidos VALUES({cotizacion.ID}, 1, '{DateTime.Now}')");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
