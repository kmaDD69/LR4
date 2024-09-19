using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4.UsersClasses
{
    public class InfoGMail:InfoEmail
    {
        public InfoGMail(StringPair emailAdressTo, string subject, string body)
            :base(emailAdressTo, subject, body)
        {
            SmtpClientAdress = "smtp.gmail.com";
            EmailAdressFrom = new StringPair("is25shvetsovaev@artcollege.ru", "Катя Катерина");
            EmailPassword = "rcay yhtl mfxt cocb";
            Port = 587;
        }
    }
}
