using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Acceso_Datos
{
    public class DigitosVerticalesAD
{
        AccesoSQL _AccesoSQL = new AccesoSQL();
       

        public List<Modelo.Digito_Vertical> TraerTablas()
        {
            List<Modelo.Digito_Vertical> ListDVV = new List<Modelo.Digito_Vertical>();
            

            DataSet DvvDS =  _AccesoSQL.Consultar_DS("SELECT Tabla, DVV FROM DigitoVerificadorVertical ", "DigitoVerificadorVertical");
            foreach(DataRow row in DvvDS.Tables[0].Rows)
            {
                Modelo.Digito_Vertical _DigitoVertical = new Modelo.Digito_Vertical();
                _DigitoVertical.Tabla = row["Tabla"].ToString();
                _DigitoVertical.DVV =  row["DVV"].ToString();

                ListDVV.Add(_DigitoVertical);
            }
            return ListDVV;
        }

        public DataSet TraerInfoTabla(Modelo.Digito_Vertical digito_Vertical)
        {
            try
            {
                var TablaInfoDS = _AccesoSQL.Consultar_DS("SELECT * FROM " + digito_Vertical.Tabla, digito_Vertical.Tabla);
                return TablaInfoDS;
            }
            catch (Exception ex)
            {
                return null;
            }
            
        }

        public bool UpdateDVVTabla(Modelo.Digito_Vertical digito_Vertical)
        {
            try
            {
                var Consulta = _AccesoSQL.Ejecutar_Query("ExecuteNonQuery", "UPDATE DigitoVerificadorVertical SET DVV = '" + digito_Vertical.DVV + "' WHERE Tabla = '" + digito_Vertical.Tabla + "'");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

}
}
