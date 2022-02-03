using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailApp
{
    class Program
    {
        public static void Main()
        {
            var client = new SmtpClient
            {
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("asfand.y.ali99@gmail.com", "Asfand0223!"),
                Host = "smtp.gmail.com"
            };
            var message = new MailMessage("asfand.y.ali99@gmail.com", "asfand.y.ali99@gmail.com", "Console App", "First ever email via console app.");
            client.Send(message);
        }
    }
}
