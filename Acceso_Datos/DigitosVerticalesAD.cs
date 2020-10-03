using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Acceso_Datos
{
    public class DigitosVerticalesAD
{
        AccesoSQL _AccesoSQL = new AccesoSQL();
        Modelo.Digito_Vertical _DigitoVertical = new Modelo.Digito_Vertical();
        List<Modelo.Digito_Vertical> ListDVV = new List<Modelo.Digito_Vertical>();

        public List<Modelo.Digito_Vertical> TraerTablas()
        {
            DataSet DvvDS =  _AccesoSQL.Consultar_DS("SELECT Tabla, DVV FROM DigitoVerificadorVertical ", "DigitoVerificadorVertical");
            foreach(DataRow row in DvvDS.Tables[0].Rows)
            {
                _DigitoVertical.Tabla = row["Tabla"].ToString();
                _DigitoVertical.DVV =  row["DVV"].ToString();

                ListDVV.Add(_DigitoVertical);
            }
            return ListDVV;
        }

        public DataSet TraerInfoTabla(Modelo.Digito_Vertical digito_Vertical)
        {
            var TablaInfoDS =_AccesoSQL.Consultar_DS("SELECT * FROM " + digito_Vertical.Tabla ,digito_Vertical.Tabla);
            return TablaInfoDS;
        }

}
}
