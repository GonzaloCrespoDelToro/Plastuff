using Acceso_Datos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicios
{
    public class Verificadores
    {
        AccesoConfig DatosConfig = new AccesoConfig();
        AccesoSQL AccesoSQL = new AccesoSQL();
        Encriptacion DesEnc = new Encriptacion();

        public void Verificar_TXT()
        {
            bool Fallo = false;
            if (DatosConfig.Buscar_TXT() == true)
            {
                string RegCompleto = DatosConfig.ValidarTXT();
                try
                {
                    string[] V1 = RegCompleto.Split(';');
                    string[] V2 = DesEnc.Desencriptar(V1[0]).Split('=');
                    if (V2[0] == "Data Source" & V2[1] != "")
                    {
                        string[] V3 = DesEnc.Desencriptar(V1[1]).Split('=');
                        if (V3[0] == "Initial Catalog" & V3[1] != "")
                        {
                            string[] V4 = DesEnc.Desencriptar(V1[2]).Split('=');
                            if (V4[0] != "Integrated Security" & V4[1] != "")
                            {
                                Fallo = true;
                            }
                        }
                        else
                        {
                            Fallo = true;
                        }
                    }
                    else
                    {
                        Fallo = true;
                    }
                }
                catch (Exception ex)
                {
                    Fallo = true;
                }
            }
            else
            {
                Fallo = true;
            }
            if (Fallo == true)
            { //ver como hago con lo del ordenador
                string[] Datos = { DesEnc.Encriptar(@"Data Source=DESKTOP-ALLEDA", 2),
                    DesEnc.Encriptar("Initial Catalog=Plastuff", 2),
                    DesEnc.Encriptar("Integrated Security=True", 2)};
                DatosConfig.Crear_TXTDefecto(Datos);
            }
            else
            {
            }
        }

        public bool Armar_Conexion()
        {
            try
            {
                string[] Datos = { "", "", ""};
                string[] Vector = DatosConfig.Obtener_Conexion();

                Datos[0] = DesEnc.Desencriptar(Vector[0]).ToString();
                Datos[1] = DesEnc.Desencriptar(Vector[1]).ToString();
                Datos[2] = DesEnc.Desencriptar(Vector[2]).ToString();

               if(AccesoSQL.Armar_Conexion(Datos) != true)
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
    }
}
