using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Modelo;

namespace Acceso_Datos
{
    public class UsuarioAD
{
        AccesoSQL _accesoSQL = new AccesoSQL();

        public bool Verificar_User(Modelo.Usuario usuario)
        {
            try
            {
                string UsuBD = _accesoSQL.Ejecutar_Query("ExecuteScalar", "SELECT ID FROM Usuarios WHERE Nombre='" + usuario.Nombre + "'");

                if (UsuBD != null)
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

        public bool Verificar_Bloq(Modelo.Usuario usuario)
        {
            try
            {
                string Consulta = _accesoSQL.Ejecutar_Query("ExecuteScalar", "SELECT Bloqueado FROM Usuarios WHERE Nombre='" + usuario.Nombre + "'");
                if (Convert.ToBoolean(Consulta))
                {
                    return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public Modelo.Usuario GetUserByName(Modelo.Usuario usuario)
        {
            Modelo.Usuario user = new Modelo.Usuario();

            try
            {
                DataSet UserDS = _accesoSQL.Consultar_DS("SELECT ID, Nombre, Pass, Contador, Bloqueado, Emp_id, Idioma_id, DVH FROM Usuarios WHERE Nombre='" + usuario.Nombre + "'", "Usuarios");

                user.id = Convert.ToInt32(UserDS.Tables[0].Rows[0]["Id"].ToString());
                user.Nombre = UserDS.Tables[0].Rows[0]["Nombre"].ToString();
                user.Pass = UserDS.Tables[0].Rows[0]["Pass"].ToString();
                user.Intentos = Convert.ToInt32(UserDS.Tables[0].Rows[0]["Contador"].ToString());
                user.bloqueado = Convert.ToBoolean(UserDS.Tables[0].Rows[0]["Bloqueado"].ToString());
                user.DVH = UserDS.Tables[0].Rows[0]["DVH"].ToString();
                int EmpID = Convert.ToInt32(UserDS.Tables[0].Rows[0]["Emp_id"].ToString());
                int IdiomaID = Convert.ToInt32(UserDS.Tables[0].Rows[0]["Idioma_id"].ToString());

                DataSet EmpDS = _accesoSQL.Consultar_DS("SELECT E_nombre, E_apellido, E_DNI, E_fechanac, E_mail, E_direccion, E_Telefono FROM Empleados WHERE ID=" + EmpID + "", "Empleados");
                Modelo.Empleado Emp = new Modelo.Empleado();

                Emp.id = EmpID;
                Emp.nombre = EmpDS.Tables[0].Rows[0]["E_nombre"].ToString();
                Emp.apellido = EmpDS.Tables[0].Rows[0]["E_apellido"].ToString();
                Emp.dni = EmpDS.Tables[0].Rows[0]["E_DNI"].ToString();
                Emp.fechanac = Convert.ToDateTime(EmpDS.Tables[0].Rows[0]["E_fechanac"].ToString());
                Emp.mail = EmpDS.Tables[0].Rows[0]["E_mail"].ToString();
                Emp.direccion = EmpDS.Tables[0].Rows[0]["E_direccion"].ToString();
                Emp.telefono = EmpDS.Tables[0].Rows[0]["E_Telefono"].ToString();

                user.Empleado = Emp;

                DataSet IdiomaDS = _accesoSQL.Consultar_DS("SELECT ID, Idioma FROM Idiomas WHERE ID = " + IdiomaID, "Idiomas");
                Modelo.Idioma Idioma = new Modelo.Idioma();

                Idioma.id = IdiomaID;
                Idioma.idioma = IdiomaDS.Tables[0].Rows[0]["Idioma"].ToString();

                user.Idioma = Idioma;

                return user;
            }
            catch(Exception ex)
            {
                return user;
            }
        }

        public bool Verificar_Pass(Modelo.Usuario usuario)
        {
            try
            {
                string PassBD = _accesoSQL.Ejecutar_Query("ExecuteScalar","SELECT Pass FROM Usuarios WHERE Nombre='" + usuario.Nombre + "'");
                if (usuario.Pass != PassBD)
                {
                    return false;
                }
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }


        public void AumentarResetear_Contador(Modelo.Usuario usuario)
        {
            try
            {
                var Consulta = _accesoSQL.Ejecutar_Query("ExecuteNonQuery", "UPDATE Usuarios SET Contador = " + usuario.Intentos.ToString() + ", DVH = '"+ usuario.DVH +"' WHERE Nombre = '" + usuario.Nombre + "'");
            }
            catch(Exception ex)
            {

            }
        }

        public void Bloquear_Usu(Modelo.Usuario usuario)
        {
            try
            {
                _accesoSQL.Ejecutar_Query("ExecuteNonQuery", "UPDATE Usuarios SET Contador = 0, Bloqueado = 1, DVH = '"+ usuario.DVH +"' WHERE Nombre ='" + usuario.Nombre + "'");
            }
            catch (Exception ex)
            {

            }
        }

       
    }
}
