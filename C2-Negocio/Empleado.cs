using System;
using System.Collections.Generic;

namespace C2_Negocio
{
    public class Empleado
    {
        Acceso_Datos.EmpleadoAD _EmpleadoAD = new Acceso_Datos.EmpleadoAD();

        public bool Vacio(Modelo.Empleado empleado)
        {
            if (string.IsNullOrEmpty(empleado.nombre) || string.IsNullOrEmpty(empleado.apellido) || string.IsNullOrEmpty(empleado.dni) || empleado.fechanac == null ||
                string.IsNullOrEmpty(empleado.mail) || string.IsNullOrEmpty(empleado.direccion) || string.IsNullOrEmpty(empleado.telefono))
            {
                return true;
            }
            return false;
        }

        public void Alta_Empleado(Modelo.Empleado empleado)
        {
            try
            {
                _EmpleadoAD.Alta_Emp(empleado);
            }
            catch (Exception ex)
            {

            }
        }

        public List<Modelo.Empleado> Listar_Empleados()
        {
            try
            {
                List<Modelo.Empleado> empleados = _EmpleadoAD.Listar_Emp();

                return empleados;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
