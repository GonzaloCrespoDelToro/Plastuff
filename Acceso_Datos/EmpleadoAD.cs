using System;
using System.Collections.Generic;
using System.Data;
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

        public List<Modelo.Empleado> Listar_Emp()
        {
            try
            {
                List<Modelo.Empleado> Empleados = new List<Modelo.Empleado>();

                DataSet EmpleadosDS = _accesoSQL.Consultar_DS("SELECT ID, E_nombre, E_apellido, E_DNI, E_fechanac, E_mail, E_direccion, E_telefono FROM Empleados ", "Empleados");
                foreach (DataRow row in EmpleadosDS.Tables[0].Rows)
                {
                    Modelo.Empleado empleado = new Modelo.Empleado();
                    empleado.id = Convert.ToInt32(row["ID"].ToString());
                    empleado.nombre = row["E_nombre"].ToString();
                    empleado.apellido = row["E_apellido"].ToString();
                    empleado.dni = row["E_DNI"].ToString();
                    empleado.fechanac = Convert.ToDateTime(row["E_fechanac"].ToString());
                    empleado.mail = row["E_mail"].ToString();
                    empleado.direccion = row["E_direccion"].ToString();
                    empleado.telefono = row["E_telefono"].ToString();

                    Empleados.Add(empleado);
                }

                return Empleados;
            }
            catch(Exception ex)
            {
                return null;
            }
            
        }


}
}
