using System;
using System.Collections.Generic;
using System.Text;

namespace Servicios
{
    public class MailManager
{
    public void EnviarMail(string Para, string Asunto, string Mensaje)
    {
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

            mmsg.To.Add(Para);
            mmsg.Subject = Asunto;
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;

            mmsg.Body = Mensaje;
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true;
            mmsg.From = new System.Net.Mail.MailAddress("Plastuff.No.Reply@gmail.com");

            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

            cliente.Credentials = new System.Net.NetworkCredential("Plastuff.No.Reply@gmail.com", "Plastuff123");

            cliente.Port = 587;
            cliente.EnableSsl = true;

            cliente.Host = "smtp.gmail.com";

            try
            {
                cliente.Send(mmsg);
            }
            catch (Exception ex)
            {

                throw;
            }
    }
}
}
