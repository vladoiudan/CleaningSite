using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;

namespace DAV.UniverseCleaning.Helpers
{
    public class SmtpMailServiceBll : IMailServiceBll
    {

        #region IMailService Members

        public void SendMail(string from, string subject, string body, bool isHtml, string email)
        {
            SendMailImmediate(from, subject, body, isHtml, email.ToEmailAddressesArray());
        }

        public void SendMail(string from, string subject, string body, bool isHtml, IEnumerable<string> emails)
        {
            SendMailImmediate(from, subject, body, isHtml, emails);
        }

        #endregion

        #region Methods

        private bool SendMailImmediate(string from, string subject, string body, bool isHtml, IEnumerable<string> receivers)
        {
            var receiverList = receivers != null
                ? receivers as IList<string> ?? receivers.ToList()
                : new List<string>();

            if (!receiverList.Any())
            {
                throw new ArgumentException("List of receivers is null or empty.", "receivers");
            }

            var isSentSuccessfully = true;
            using (var mail = new MailMessage())
            {
                if (!string.IsNullOrEmpty(from))
                {
                    mail.From = new MailAddress(from);
                }

                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = isHtml;

            
                foreach (var email in receiverList)
                {
                    mail.To.Add(new MailAddress(email));
                }

                if (mail.To.Count > 0)
                {
                    using (var client = new SmtpClient())
                    {
                        if (client.DeliveryMethod == SmtpDeliveryMethod.SpecifiedPickupDirectory
                            && string.IsNullOrEmpty(client.PickupDirectoryLocation))
                        {
                            SetRelativePickupDirectoryLocation(client);
                        }


                        try
                        {
                            client.Send(mail);
                        }
                        catch (Exception)
                        {
                            isSentSuccessfully = false;
                        }

                    }
                }
            }
            return isSentSuccessfully;
        }

        private static void SetRelativePickupDirectoryLocation(SmtpClient client)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"MailPickup");

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            client.PickupDirectoryLocation = path;
        }

        #endregion
    }
}