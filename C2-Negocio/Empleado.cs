using System;
using System.Collections.Generic;
using Modelo;

namespace C2_Negocio
{
    public class Empleado
    {
        Acceso_Datos.EmpleadoAD _EmpleadoAD = new Acceso_Datos.EmpleadoAD();

        public bool Vacio(Modelo.Empleado empleado)
        {
            if (string.IsNullOrEmpty(empleado.Nombre) || string.IsNullOrEmpty(empleado.Apellido) || string.IsNullOrEmpty(empleado.DNI) || empleado.Fechanac == null ||
                string.IsNullOrEmpty(empleado.Mail) || string.IsNullOrEmpty(empleado.Direccion) || string.IsNullOrEmpty(empleado.Telefono))
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

        public void Modificar_Empleado(Modelo.Empleado empleado)
        {
            try
            {
                _EmpleadoAD.Mod_Emp(empleado);
            }
            catch(Exception ex)
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

        public List<Modelo.Empleado> Listar_Empleados_Usuarios()
        {
            try
            {
                List<Modelo.Empleado> empleados = _EmpleadoAD.Listar_Emp_usu();

                return empleados;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Eliminar_Empleado(Modelo.Empleado selectEmp)
        {
            try
            {
                bool Elemin =_EmpleadoAD.Eliminar_Emp(selectEmp);
                if (Elemin)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        
    }
}
