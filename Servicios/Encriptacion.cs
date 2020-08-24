using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Servicios
{
    public class Encriptacion
    {
        private string GetSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        private string EncriptarR(string dato)
        {
            try
            {
                byte[] iv = new byte[16];
                byte[] array;

                using (Aes aes = Aes.Create())
                {
                    aes.Key = Encoding.UTF8.GetBytes("b14ca5898a4e4133bbce2ea2315a1916");
                    aes.IV = iv;

                    ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                            {
                                streamWriter.Write(dato);
                            }

                            array = memoryStream.ToArray();
                        }
                    }
                    return Convert.ToBase64String(array);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string Desencriptar(string cipherText)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes("b14ca5898a4e4133bbce2ea2315a1916");
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }

        //Metodo de encriptacion (1 = SHA256 o 2 = Convencional)
        public string Encriptar(string dato, int metodo)
        {
            string datoEncrip = "";
            try
            {
                if (metodo == 1)
                {
                    datoEncrip = GetSHA256(dato);
                }
                else if (metodo == 2)
                {
                    datoEncrip = EncriptarR(dato);
                }
                return datoEncrip;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
