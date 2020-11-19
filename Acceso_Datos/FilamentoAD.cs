using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Modelo;

namespace Acceso_Datos
{
    public class FilamentoAD
    {
        Acceso_Datos.AccesoSQL _AccesoSQL = new AccesoSQL();
        public void Alta_TipoFilamento(TipoFilamento tipoFilamento)
        {
            string consulta = _AccesoSQL.Ejecutar_Query("ExecuteNonQuery", $"INSERT INTO Tipo_Filamento VALUES('{tipoFilamento.Tipo}',{tipoFilamento.Precio})");
        }
        
        public List<Modelo.TipoFilamento> ListarTipoFilamento()
        {
            List<Modelo.TipoFilamento> tipoFilamentos = new List<TipoFilamento>();
            try
            {
                DataSet ClientesDS = _AccesoSQL.Consultar_DS("SELECT ID, TF_tipo, TF_Precio FROM Tipo_Filamento", "Tipo_Filamento");
                foreach (DataRow row in ClientesDS.Tables[0].Rows)
                {
                    Modelo.TipoFilamento tipoFilamento = new TipoFilamento();
                    tipoFilamento.ID = Convert.ToInt32(row["ID"].ToString());
                    tipoFilamento.Tipo = row["TF_tipo"].ToString();
                    tipoFilamento.Precio =Convert.ToDouble(row["TF_Precio"].ToString());

                    tipoFilamentos.Add(tipoFilamento);
                }

                return tipoFilamentos;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Modelo.TipoFilamento TraerTipoFilamento(TipoFilamento tipoFilamento)
        {
            try
            {
                DataSet TipoFilamentoDS =_AccesoSQL.Consultar_DS($"SELECT ID, TF_tipo, TF_Precio FROM Tipo_Filamento WHERE TF_tipo = '{tipoFilamento.Tipo}'", "Tipo_Filamento");
                tipoFilamento.ID = Convert.ToInt32(TipoFilamentoDS.Tables[0].Rows[0]["ID"].ToString());
                tipoFilamento.Tipo = TipoFilamentoDS.Tables[0].Rows[0]["TF_tipo"].ToString();
                tipoFilamento.Precio =Convert.ToDouble(TipoFilamentoDS.Tables[0].Rows[0]["TF_Precio"].ToString());
                return tipoFilamento;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
