using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Modelo;

namespace Acceso_Datos
{
    public class EmpleadoAD
{
        AccesoSQL _accesoSQL = new AccesoSQL();

        public void Alta_Emp(Modelo.Empleado empleado)
        {
            try
            {
                var consulta = _accesoSQL.Ejecutar_Query("ExecuteNonQuery", $"INSERT INTO Empleados VALUES ('{empleado.Nombre}', '{empleado.Apellido}', '{empleado.DNI}','{empleado.Fechanac}','{empleado.Mail}','{empleado.Direccion}','{empleado.Telefono}')");
            }
            catch (Exception ex)
            {

            }
        }

        public void Mod_Emp(Modelo.Empleado empleado)
        {
            try
            {
                var consulta = _accesoSQL.Ejecutar_Query("ExecuteNonQuery", $"UPDATE Empleados SET E_nombre = '{empleado.Nombre}', E_apellido = '{empleado.Apellido}', E_DNI = '{empleado.DNI}', E_fechanac = '{empleado.Fechanac}', E_mail = '{empleado.Mail}', E_direccion = '{empleado.Direccion}', E_telefono = '{empleado.Telefono}' WHERE ID = {empleado.ID} ");
            }
            catch(Exception ex)
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
                    empleado.ID = Convert.ToInt32(row["ID"].ToString());
                    empleado.Nombre = row["E_nombre"].ToString();
                    empleado.Apellido = row["E_apellido"].ToString();
                    empleado.DNI = row["E_DNI"].ToString();
                    empleado.Fechanac = Convert.ToDateTime(row["E_fechanac"].ToString());
                    empleado.Mail = row["E_mail"].ToString();
                    empleado.Direccion = row["E_direccion"].ToString();
                    empleado.Telefono = row["E_telefono"].ToString();

                    Empleados.Add(empleado);
                }
                return Empleados;
            }
            catch(Exception ex)
            {
                return null;
            }
            
        }

        public bool Eliminar_Emp(Empleado empleado)
        {
            try
            {
                var consulta = _accesoSQL.Ejecutar_Query("ExecuteNonQuery", $"DELETE FROM Empleados Where ID = {empleado.ID}");
                if (string.IsNullOrEmpty(consulta))
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

        public List<Modelo.Empleado> Listar_Emp_usu()
        {
            try
            {
                List<Modelo.Empleado> Empleados = new List<Modelo.Empleado>();

                DataSet EmpleadosDS = _accesoSQL.Consultar_DS("SELECT e.ID, e.E_nombre, e.E_apellido, e.E_DNI, e.E_fechanac, e.E_mail, e.E_direccion, e.E_telefono FROM Empleados e LEFT JOIN Usuarios u on u.Emp_id = e.ID where u.Emp_id is null", "Empleados");
                foreach (DataRow row in EmpleadosDS.Tables[0].Rows)
                {
                    Modelo.Empleado empleado = new Modelo.Empleado();
                    empleado.ID = Convert.ToInt32(row["ID"].ToString());
                    empleado.Nombre = row["E_nombre"].ToString();
                    empleado.Apellido = row["E_apellido"].ToString();
                    empleado.DNI = row["E_DNI"].ToString();
                    empleado.Fechanac = Convert.ToDateTime(row["E_fechanac"].ToString());
                    empleado.Mail = row["E_mail"].ToString();
                    empleado.Direccion = row["E_direccion"].ToString();
                    empleado.Telefono = row["E_telefono"].ToString();

                    Empleados.Add(empleado);
                }
                return Empleados;
            }
            catch (Exception ex)
            {
                return null;
            }

        }


    }
}
