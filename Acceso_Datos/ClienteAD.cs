using System;
using System.Collections.Generic;
using System.Data;
using Modelo;

namespace Acceso_Datos
{
    public class ClienteAD
    {
        Acceso_Datos.AccesoSQL _AccesoSQL = new AccesoSQL();
        public bool Check_DNI(Cliente cliente)
        {
            try
            {
                string valor = _AccesoSQL.Ejecutar_Query("ExecuteScalar", $"SELECT ID FROM CLientes WHERE C_DNI='{cliente.DNI}'");

                if (valor != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void Alta(Cliente cliente)
        {
            try
            {
                string consulta = _AccesoSQL.Ejecutar_Query("ExecuteNonQuery", $"INSERT INTO Clientes VALUES('{cliente.Nombre}','{cliente.Apellido}','{cliente.Direccion}'," +
                    $"'{cliente.Fechanac}','{cliente.Mail}','{cliente.Telefono}','{cliente.DNI}','{cliente.DVH}')");
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public List<Cliente> ListarClientes()
        {
            try
            {
                List<Cliente> clientes = new List<Cliente>();

                DataSet ClientesDS = _AccesoSQL.Consultar_DS("SELECT ID, C_nombre,C_apellido, C_direccion, C_fechanac, C_mail, C_telefono, C_DNI, DVH FROM Clientes", "Clientes");
                foreach (DataRow row in ClientesDS.Tables[0].Rows)
                {
                    Modelo.Cliente cliente = new Cliente();
                    cliente.ID = Convert.ToInt32(row["ID"].ToString());
                    cliente.Nombre = row["C_nombre"].ToString();
                    cliente.Apellido = row["C_apellido"].ToString();
                    cliente.Direccion = row["C_direccion"].ToString();
                    cliente.Fechanac = Convert.ToDateTime(row["C_fechanac"].ToString());
                    cliente.Mail = row["C_mail"].ToString();
                    cliente.Telefono = row["C_telefono"].ToString();
                    cliente.DNI = row["C_DNI"].ToString();
                    cliente.DVH = row["DVH"].ToString();
                    clientes.Add(cliente);
                }
                return clientes;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public Cliente TraerClientePorDNI(Cliente cliente)
        {
            try
            {
                DataSet ClienteDs = _AccesoSQL.Consultar_DS($"SELECT ID, C_nombre,C_apellido, C_direccion, C_fechanac, C_mail, C_telefono, C_DNI, DVH FROM Clientes WHERE C_DNI = '{cliente.DNI}'", "Clientes");
                cliente.ID = Convert.ToInt32(ClienteDs.Tables[0].Rows[0]["ID"].ToString());
                cliente.Nombre = ClienteDs.Tables[0].Rows[0]["C_nombre"].ToString();
                cliente.Apellido = ClienteDs.Tables[0].Rows[0]["C_apellido"].ToString();
                cliente.Direccion = ClienteDs.Tables[0].Rows[0]["C_direccion"].ToString();
                cliente.Fechanac = Convert.ToDateTime(ClienteDs.Tables[0].Rows[0]["C_fechanac"].ToString());
                cliente.Mail = ClienteDs.Tables[0].Rows[0]["C_mail"].ToString();
                cliente.Telefono = ClienteDs.Tables[0].Rows[0]["C_telefono"].ToString();
                cliente.DNI = ClienteDs.Tables[0].Rows[0]["C_DNI"].ToString();
                cliente.DVH = ClienteDs.Tables[0].Rows[0]["DVH"].ToString();
                return cliente;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
