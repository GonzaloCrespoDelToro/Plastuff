using System;
using System.Data;
using System.Data.SqlClient;

namespace Acceso_Datos
{
    public class AccesoSQL
    {
        SqlDataAdapter DataAdapter = new SqlDataAdapter();
        SqlCommandBuilder ComBuilder = new SqlCommandBuilder();
        DataSet DataSet = new DataSet();
        string Conexion = "";
        SqlConnection SQLCON = new SqlConnection();

        public bool Armar_Conexion(/*string[] Datos*/)
        {
            //string CON = "Data Source=" + Datos[0] + ";" + "Initial Catalog=" + Datos[1] + ";" + "User ID=" + Datos[2] + ";" + "Password=" + Datos[3] + ";MultipleActiveResultSets=True";
            string CON = "Data Source=DESKTOP-ALLEDA;Initial Catalog=Plastuff;Integrated Security =True";
            SqlConnection SQL = new SqlConnection(CON);
            try
            {
                SQL.Open();
                SQL.Close();
                Conexion = CON;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private bool Conectar()
        {
            SQLCON = new SqlConnection(Conexion);
            try
            {
                if(SQLCON.State == ConnectionState.Closed)
                {
                    SQLCON.Open();
                    return true;
                }
                else
                {
                    return true;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        private bool Desconectar()
        {
            SQLCON = new SqlConnection(Conexion);
            try
            {
                if (SQLCON.State == ConnectionState.Open)
                {
                    SQLCON.Close();
                    return true;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataSet Consultar_DS(string Consulta, string Tabla)
        {
            try
            {
                Conectar();
                DataSet = new DataSet("DVH");
                DataAdapter = new SqlDataAdapter(Consulta, Conexion);
                ComBuilder = new SqlCommandBuilder(DataAdapter);
                DataAdapter.Fill(DataSet, Tabla);
                Desconectar();
                return DataSet;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public string Ejecutar_Query(string Tipo, string Consulta)
        {
            try
            {
                SqlCommand CMD = new SqlCommand();
                Conectar();
                CMD.Connection = SQLCON;
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = Consulta;
                string Valor = "";
                if(Tipo == "ExecuteScalar")
                {
                    Valor = CMD.ExecuteScalar().ToString();
                }
                else if (Tipo == "ExecuteNonQuery")
                {
                    Valor = CMD.ExecuteNonQuery().ToString();
                }
                Desconectar();
                return Valor;
            }
            catch(Exception ex)
            {
                Desconectar();
                return null;
            }
        }


    }
}
