using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils.Drawing.Helpers;

namespace eguidanceV2.modules
{
    internal class SendMail
    {
        //private object msgBody;

        public void SendEmail(string subject, string msgBody, String sEmailAddress, String sWho)
        {
            MailMessage msg; 
           SmtpClient newclient;

            newclient = new SmtpClient();
            msg = new MailMessage();


            

             MailAddress a = new MailAddress(sEmailAddress, sWho);
            msg.To.Add(a);
            msg.From = new System.Net.Mail.MailAddress("");

            msg.ReplyTo = new System.Net.Mail.MailAddress("");

            msg.Subject = "Web Inquiry";

            msg.Body = msgBody.ToString();

            newclient.Send(msg);
        }
    }
}
