using Acceso_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Servicios
{
    public class Verificadores
    {
        AccesoConfig _DatosConfig = new AccesoConfig();
        AccesoSQL _AccesoSQL = new AccesoSQL();
        Encriptacion _Encriptacion = new Encriptacion();
        DigitosVerticalesAD _DigitosVerticalesAD = new DigitosVerticalesAD();


        public void Verificar_TXT()
        {
            bool Fallo = false;
            if (_DatosConfig.Buscar_TXT() == true)
            {
                string RegCompleto = _DatosConfig.ValidarTXT();
                try
                {
                    string[] V1 = RegCompleto.Split(';');
                    string[] V2 = _Encriptacion.Desencriptar(V1[0]).Split('=');
                    if (V2[0] == "Data Source" & V2[1] != "")
                    {
                        string[] V3 = _Encriptacion.Desencriptar(V1[1]).Split('=');
                        if (V3[0] == "Initial Catalog" & V3[1] != "")
                        {
                            string[] V4 = _Encriptacion.Desencriptar(V1[2]).Split('=');
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
            {
                string[] Datos = { _Encriptacion.Encriptar(@"Data Source=DESKTOP-ALLEDA\SQLEXPRESS", 2),
                    _Encriptacion.Encriptar("Initial Catalog=Plastuff", 2),
                    _Encriptacion.Encriptar("Integrated Security=True", 2)};
                _DatosConfig.Crear_TXTDefecto(Datos);
            }
            else
            {
            }
        }

        public bool Recalcular_TodosDVV()
        {
            try
            {
                var Tablas = _DigitosVerticalesAD.TraerTablas();
                foreach (Modelo.Digito_Vertical tabla in Tablas)
                {
                    DataSet TablaDS = _DigitosVerticalesAD.TraerInfoTabla(tabla);
                    int columnas = TablaDS.Tables[0].Columns.Count;
                    int filacount = 0;
                    int TotalDVH = 0;
                    foreach (DataRow Fila in TablaDS.Tables[0].Rows)
                    {
                        string Concadena = "";
                        int ValDVH = 0;
                        for (int j = 1; j <= columnas - 2; j++)
                        {
                            Concadena = Concadena + Fila[j].ToString();
                        }
                        int pos = 0;
                        foreach (char c in Concadena)
                        {
                            pos += 1;
                            ValDVH += (Encoding.ASCII.GetBytes(c.ToString())[0] * pos);
                        }
                        string DVHE = _Encriptacion.Encriptar(ValDVH.ToString(), 1);

                        filacount += 1;
                        var id = Fila[0].ToString();
                        string DVHTabla = Fila[columnas - 1].ToString();
                        int posicion = 0;
                        int ValorDVH = 0;

                        foreach (char c in DVHE)
                        {
                            posicion += 1;
                            ValorDVH += (Encoding.ASCII.GetBytes(c.ToString())[0] * posicion);
                        }
                        //realiza el uptada del dvh
                        if (DVHTabla != DVHE)
                        {
                            _DigitosVerticalesAD.UpdateDHV(id, DVHE, tabla.Tabla);
                        }

                        TotalDVH += ValorDVH;
                    }
                    string TDVH = _Encriptacion.Encriptar(TotalDVH.ToString(), 1);
                    tabla.DVV = TDVH;
                    _DigitosVerticalesAD.UpdateDVVTabla(tabla);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool Recalcular_DVV(Modelo.Digito_Vertical DVV) //Para una sola Tabla
        {
            try
            {
                DataSet TablaDS = _DigitosVerticalesAD.TraerInfoTabla(DVV);
                int columnas = TablaDS.Tables[0].Columns.Count;
                int filacount = 0;
                int TotalDVH = 0;
                string DVHTabla = "";
                foreach (DataRow Fila in TablaDS.Tables[0].Rows)
                {
                    filacount += 1;
                    DVHTabla = Fila[columnas - 1].ToString();
                    int posicion = 0;
                    int ValorDVH = 0;

                    foreach (char c in DVHTabla)
                    {
                        posicion += 1;
                        ValorDVH += (Encoding.ASCII.GetBytes(c.ToString())[0] * posicion);
                    }

                    TotalDVH += ValorDVH;
                }
                string TDVH = _Encriptacion.Encriptar(TotalDVH.ToString(), 1);
                DVV.DVV = TDVH;
                _DigitosVerticalesAD.UpdateDVVTabla(DVV);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public string Verificar_DVV()
        {
            try
            {
                string Errores = "";
                bool HayError = false;
                var Tablas = _DigitosVerticalesAD.TraerTablas();
                foreach (Modelo.Digito_Vertical tabla in Tablas)
                {
                    DataSet TablaDS = _DigitosVerticalesAD.TraerInfoTabla(tabla);
                    int columnas = TablaDS.Tables[0].Columns.Count;
                    int filacount = 0;
                    int TotalDVH = 0;
                    foreach (DataRow Fila in TablaDS.Tables[0].Rows)
                    {
                        filacount += 1;
                        string DVHTabla = Fila[columnas - 1].ToString();
                        int posicion = 0;
                        int ValorDVH = 0;

                        foreach (char c in DVHTabla)
                        {
                            posicion += 1;
                            ValorDVH += (Encoding.ASCII.GetBytes(c.ToString())[0] * posicion);
                        }

                        TotalDVH += ValorDVH;
                    }
                    string TDVH = _Encriptacion.Encriptar(TotalDVH.ToString(), 1);
                    if (TDVH != tabla.DVV)
                    {
                        Errores = Errores + "Tabla: " + tabla.Tabla;
                        HayError = true;
                    }
                }
                if (HayError)
                {
                    return Errores;
                }
                return "";
            }
            catch (Exception ex)
            {
                return "";
            }

        }

        public string CalcularDVH(string[] Datos)
        {
            try
            {
                string Concadena = "";
                int ValorDVH = 0;
                int posicion = 0;
                foreach (string i in Datos)
                {
                    Concadena = Concadena + i.ToString();
                }
                foreach (char c in Concadena)
                {
                    posicion += 1;
                    ValorDVH += (Encoding.ASCII.GetBytes(c.ToString())[0] * posicion);
                }
                return _Encriptacion.Encriptar(ValorDVH.ToString(), 1);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string Verificar_DVH()
        {
            try
            {
                string Errores = "";
                bool HayError = false;
                List<Modelo.Digito_Vertical> Tablas = _DigitosVerticalesAD.TraerTablas();
                foreach (Modelo.Digito_Vertical tabla in Tablas)
                {
                    DataSet TablaDS = _DigitosVerticalesAD.TraerInfoTabla(tabla);
                    int columnas = TablaDS.Tables[0].Columns.Count;
                    int filacount = 0;
                    string DVHTabla = "";
                    foreach (DataRow Fila in TablaDS.Tables[0].Rows)
                    {
                        filacount += 1;
                        DVHTabla = "";
                        DVHTabla = Fila[columnas - 1].ToString();
                        string Concadena = "";
                        int ValorDVH = 0;
                        for (int j = 1; j <= columnas - 2; j++)
                        {
                            Concadena = Concadena + Fila[j].ToString();
                        }
                        int posicion = 0;
                        foreach (char c in Concadena)
                        {
                            posicion += 1;
                            ValorDVH += (Encoding.ASCII.GetBytes(c.ToString())[0] * posicion);
                        }
                        string DVHE = _Encriptacion.Encriptar(ValorDVH.ToString(), 1);
                        if (DVHTabla != DVHE)
                        {
                            Errores = Errores + "Tabla: " + tabla.Tabla + ", Fila: " + filacount.ToString();
                            HayError = true;
                        }
                    }
                }
                if (HayError == true)
                {
                    return Errores;
                }
                return "";
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public bool Datos_Conexion(string[] datos)
        {
            for (int i = 0; i <= 1; i++)
            {
                if (datos[i].ToString().Contains("'"))
                {
                    return false;
                }
            }

            string[] DatosEnc = { _Encriptacion.Encriptar("Data Source=" + datos[0], 2),
                                  _Encriptacion.Encriptar("Initial Catalog=" + datos[1], 2),
                                  _Encriptacion.Encriptar("Integrated Security=True", 2) };

            if (_DatosConfig.Crear_TXTDefecto(DatosEnc))
            {
                return true;
            }

            return false;
        }

        public bool Armar_Conexion()
        {
            try
            {
                string[] Datos = { "", "", "" };
                string[] Vector = _DatosConfig.Obtener_Conexion();

                Datos[0] = _Encriptacion.Desencriptar(Vector[0]).ToString();
                Datos[1] = _Encriptacion.Desencriptar(Vector[1]).ToString();
                Datos[2] = _Encriptacion.Desencriptar(Vector[2]).ToString();

                if (_AccesoSQL.Armar_Conexion(Datos) != true)
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
    }
}
