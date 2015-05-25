using System.Collections.Generic;

namespace DAV.UniverseCleaning.Helpers
{
    public interface IMailServiceBll
    {
        void SendMail(string from, string subject, string body, bool isHtml, string email);
        void SendMail(string from, string subject, string body, bool isHtml, IEnumerable<string> emails);
    }
}