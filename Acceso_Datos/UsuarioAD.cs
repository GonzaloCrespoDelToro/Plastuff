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

        public string Alta(Usuario usuario)
        {
            try
            {
                string consulta = _accesoSQL.Ejecutar_Query("ExecuteNonQuery", $"INSERT INTO Usuarios VALUES ('{usuario.Nombre}', '{usuario.Pass}', {usuario.Intentos}," +
                    $" '{usuario.bloqueado}', {usuario.Empleado.ID.ToString()}, {usuario.Idioma.id.ToString()}, '{usuario.DVH}') ");
                return consulta;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Modificar(Usuario usuario)
        {
            try
            {
                string consulta = _accesoSQL.Ejecutar_Query("ExecuteNonQuery", $"UPDATE Usuarios SET Nombre = '{usuario.Nombre}', Pass = '{usuario.Pass}', Contador = {usuario.Intentos}," +
                    $" Bloqueado = '{usuario.bloqueado}', Emp_id = {usuario.Empleado.ID.ToString()}, Idioma_id = {usuario.Idioma.id.ToString()}, DVH = '{usuario.DVH}' WHERE ID = {usuario.id}");
                if (string.IsNullOrEmpty(consulta))
                {
                    return false;
                }
                return true;
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
            catch (Exception ex)
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

                Emp.ID = EmpID;
                Emp.Nombre = EmpDS.Tables[0].Rows[0]["E_nombre"].ToString();
                Emp.Apellido = EmpDS.Tables[0].Rows[0]["E_apellido"].ToString();
                Emp.DNI = EmpDS.Tables[0].Rows[0]["E_DNI"].ToString();
                Emp.Fechanac = Convert.ToDateTime(EmpDS.Tables[0].Rows[0]["E_fechanac"].ToString());
                Emp.Mail = EmpDS.Tables[0].Rows[0]["E_mail"].ToString();
                Emp.Direccion = EmpDS.Tables[0].Rows[0]["E_direccion"].ToString();
                Emp.Telefono = EmpDS.Tables[0].Rows[0]["E_Telefono"].ToString();

                user.Empleado = Emp;

                DataSet IdiomaDS = _accesoSQL.Consultar_DS("SELECT ID, Idioma FROM Idiomas WHERE ID = " + IdiomaID, "Idiomas");
                Modelo.Idioma Idioma = new Modelo.Idioma();

                Idioma.id = IdiomaID;
                Idioma.idioma = IdiomaDS.Tables[0].Rows[0]["Idioma"].ToString();

                user.Idioma = Idioma;

                return user;
            }
            catch (Exception ex)
            {
                return user;
            }
        }

        public bool TieneUsuario(Empleado selectEmp)
        {
            try
            {
                string usu = _accesoSQL.Ejecutar_Query("ExecuteScalar", $"SELECT Nombre FROM Usuarios WHERE Emp_id = {selectEmp.ID}");
                if (string.IsNullOrEmpty(usu))
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

        public bool Modificar_Pass(Usuario usuario)
        {
            try
            {
                string consulta = _accesoSQL.Ejecutar_Query("ExecuteNonQuery", $"UPDATE Usuarios SET Pass = '{usuario.Pass}', DVH = '{usuario.DVH}' WHERE ID = {usuario.id}");
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

        public List<Modelo.Idioma> Listar_Idiomas()
        {
            try
            {
                List<Modelo.Idioma> idiomas = new List<Modelo.Idioma>();
                DataSet IdiomaDS = _accesoSQL.Consultar_DS("SELECT ID, Idioma FROM Idiomas", "Idiomas");
                foreach (DataRow row in IdiomaDS.Tables[0].Rows)
                {
                    Modelo.Idioma idioma = new Modelo.Idioma();
                    idioma.id = Convert.ToInt32(row["ID"].ToString());
                    idioma.idioma = row["Idioma"].ToString();
                    idiomas.Add(idioma);
                }
                return idiomas;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Verificar_Pass(Modelo.Usuario usuario)
        {
            try
            {
                string PassBD = _accesoSQL.Ejecutar_Query("ExecuteScalar", "SELECT Pass FROM Usuarios WHERE Nombre='" + usuario.Nombre + "'");
                if (usuario.Pass != PassBD)
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public void AumentarResetear_Contador(Modelo.Usuario usuario)
        {
            try
            {
                var Consulta = _accesoSQL.Ejecutar_Query("ExecuteNonQuery", "UPDATE Usuarios SET Contador = " + usuario.Intentos.ToString() + ", DVH = '" + usuario.DVH + "' WHERE Nombre = '" + usuario.Nombre + "'");
            }
            catch (Exception ex)
            {

            }
        }

        public List<Modelo.Usuario> Listar_usuarios()
        {
            try
            {
                List<Modelo.Usuario> Usuarios = new List<Usuario>();
                DataSet UserDS = _accesoSQL.Consultar_DS("SELECT ID, Nombre, Pass, Contador, Bloqueado, Emp_id, Idioma_id, DVH FROM Usuarios WHERE ID != 1", "Usuarios");
                foreach (DataRow row in UserDS.Tables[0].Rows)
                {
                    Modelo.Usuario user = new Modelo.Usuario();
                    user.id = Convert.ToInt32(row["Id"].ToString());
                    user.Nombre = row["Nombre"].ToString();
                    user.Pass = row["Pass"].ToString();
                    user.Intentos = Convert.ToInt32(row["Contador"].ToString());
                    user.bloqueado = Convert.ToBoolean(row["Bloqueado"].ToString());
                    user.DVH = row["DVH"].ToString();
                    int EmpID = Convert.ToInt32(row["Emp_id"].ToString());
                    int IdiomaID = Convert.ToInt32(row["Idioma_id"].ToString());

                    DataSet EmpDS = _accesoSQL.Consultar_DS("SELECT E_nombre, E_apellido, E_DNI, E_fechanac, E_mail, E_direccion, E_Telefono FROM Empleados WHERE ID=" + EmpID + "", "Empleados");
                    Modelo.Empleado Emp = new Modelo.Empleado();

                    Emp.ID = EmpID;
                    Emp.Nombre = EmpDS.Tables[0].Rows[0]["E_nombre"].ToString();
                    Emp.Apellido = EmpDS.Tables[0].Rows[0]["E_apellido"].ToString();
                    Emp.DNI = EmpDS.Tables[0].Rows[0]["E_DNI"].ToString();
                    Emp.Fechanac = Convert.ToDateTime(EmpDS.Tables[0].Rows[0]["E_fechanac"].ToString());
                    Emp.Mail = EmpDS.Tables[0].Rows[0]["E_mail"].ToString();
                    Emp.Direccion = EmpDS.Tables[0].Rows[0]["E_direccion"].ToString();
                    Emp.Telefono = EmpDS.Tables[0].Rows[0]["E_Telefono"].ToString();

                    user.Empleado = Emp;

                    DataSet IdiomaDS = _accesoSQL.Consultar_DS("SELECT ID, Idioma FROM Idiomas WHERE ID = " + IdiomaID, "Idiomas");
                    Modelo.Idioma Idioma = new Modelo.Idioma();

                    Idioma.id = IdiomaID;
                    Idioma.idioma = IdiomaDS.Tables[0].Rows[0]["Idioma"].ToString();

                    user.Idioma = Idioma;

                    Usuarios.Add(user);
                }

                return Usuarios;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Permiso> TraerPermisos(Usuario usuario)
        {
            string consulta = $"SELECT p.Id, p.Nombre, p.Familia, p.Descripcion FROM Usu_Per up " +
                $"INNER JOIN Usuarios u ON u.id = up.ID_U " +
                $"INNER JOIN Permisos p ON p.id = up.ID_P WHERE u.id = {usuario.id}";

            DataSet PermisosDS = _accesoSQL.Consultar_DS(consulta, "Usu_Per");

            if (PermisosDS.Tables[0].Rows.Count == 0)
            {
                return new List<Permiso>();
            }

            List<Modelo.Permiso> Permisos = new List<Permiso>();

            foreach (DataRow row in PermisosDS.Tables[0].Rows)
            {
                Modelo.Patente patente = new Patente();
                patente.ID = Convert.ToInt32(row["Id"].ToString());
                patente.Nombre = row["Nombre"].ToString();
                patente.Familia = Convert.ToBoolean(row["Familia"].ToString());
                patente.Descripcion = row["Descripcion"].ToString();

                Permisos.Add(patente);
            }

            return Permisos;
        }

        public void Bloquear_Usu(Modelo.Usuario usuario)
        {
            try
            {
                _accesoSQL.Ejecutar_Query("ExecuteNonQuery", "UPDATE Usuarios SET Contador = 0, Bloqueado = 1, DVH = '" + usuario.DVH + "' WHERE Nombre ='" + usuario.Nombre + "'");
            }
            catch (Exception ex)
            {

            }
        }


    }
}
