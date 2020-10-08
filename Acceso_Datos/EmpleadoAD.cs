using System;
using System.Collections.Generic;
using System.Text;

namespace Acceso_Datos
{
    public class EmpleadoAD
{
        AccesoSQL _accesoSQL = new AccesoSQL();

        public void Alta_Emp(Modelo.Empleado empleado)
        {
            try
            {
                var consulta = _accesoSQL.Ejecutar_Query("ExecuteNonQuery", $"INSERT INTO Empleados VALUES ('{empleado.nombre}', '{empleado.apellido}', '{empleado.dni}','{empleado.fechanac}','{empleado.mail}','{empleado.direccion}','{empleado.telefono}')");
            }
            catch (Exception ex)
            {

            }
        }


}
}
