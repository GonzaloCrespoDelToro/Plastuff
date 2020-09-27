using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Acceso_Datos
{
    public class AccesoConfig
    {
        string Ruta = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\config.txt";
        string Rutax = System.Environment.CurrentDirectory + @"\config.txt";

        public bool Buscar_TXT()
        {
            try
            {
                FileStream Archivo = new FileStream(Ruta, FileMode.Open);
                StreamReader Lector = new StreamReader(Archivo);
                Lector.Close();
                Archivo.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Crear_TXTDefecto(string[] datos)
        {
            try
            {
                FileStream Archivo = new FileStream(Ruta, FileMode.OpenOrCreate);
                StreamWriter Escritor = new StreamWriter(Archivo);
                //Escritor = File.AppendText(Ruta);
                string Reg = datos[0];
                Escritor.WriteLine(Reg);
                Reg = datos[1];
                Escritor.WriteLine(Reg);
                Reg = datos[2];
                Escritor.WriteLine(Reg);
                Escritor.Close();
                Archivo.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public string[] Obtener_Conexion()
        {
            FileStream Archivo = new FileStream(Ruta, FileMode.Open);
            StreamReader Lector = new StreamReader(Archivo);
            string Reg;
            string[] Vector = new string[4];
            int i = 0;
            while (Lector.Peek() != -1)
            {
                if (i < 4)
                {
                    Reg = Lector.ReadLine();
                    Vector[i] = Reg;
                    i += 1;
                }
                else
                {
                    break;
                }
            }
            Lector.Close();
            Archivo.Close();
            return Vector;
        }

        public string ValidarTXT()
        {
            try
            {
                FileStream Archivo = new FileStream(Ruta, FileMode.Open);
                StreamReader Lector = new StreamReader(Archivo);
                string Reg = "";
                while (Lector.Peek() != -1)
                {
                    if (Reg == "")
                    {
                        Reg = Lector.ReadLine();
                    }
                    else
                    {
                        Reg += ";" + Lector.ReadLine();
                    }
                }
                Lector.Close();
                Archivo.Close();
                return Reg;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
