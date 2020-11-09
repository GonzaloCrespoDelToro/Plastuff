using System;
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
                    $"'{cliente.Fechanac}','{cliente.Mail}')");
            }
            catch (Exception ex)
            {
                return;
            }
        }
    }
}
