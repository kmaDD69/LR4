using LR4.UsersClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static LR4.UsersClasses.InfoEmail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace LR4.UsersClasses
{
    public abstract class InfoEmail
    {



        public InfoEmail(string smtpClientAdress,
        StringPair emailAdressFrom,
        string emailPassword,
        StringPair emailAdressTo,
        string subject,
        string body)
        {
            _smtpClientAdress = String.IsNullOrWhiteSpace(smtpClientAdress) ?
            throw new Exception("Нельзя вставлять пробелы или пустое значение!") :
            smtpClientAdress;
            _emailAdressFrom = emailAdressFrom ?? throw new ArgumentNullException(nameof(emailAdressFrom));
            _emailPassword = String.IsNullOrWhiteSpace(emailPassword) ?
            throw new Exception("Нельзя вставлять пробелы или пустое значение!") :
            emailPassword;
            _emailAdressTo = emailAdressTo ?? throw new ArgumentNullException(nameof(emailAdressTo));
            _subject = subject ?? throw new ArgumentNullException(nameof(subject));
            _body = body ?? throw new ArgumentNullException(nameof(body));
        }
        private string _smtpClientAdress;
        private StringPair _emailAdressFrom;
        private string _emailPassword;
        private StringPair _emailAdressTo;
        private string _subject;
        private string _body;
        private int _port;


        public string SmtpClientAdress
        {
            get { return _smtpClientAdress; }
            set
            {
                _smtpClientAdress = String.IsNullOrWhiteSpace(value) ?
                 throw new ArgumentNullException(nameof(_smtpClientAdress)) :
                value;
            }
        }

        public StringPair EmailAdressFrom
        {
            get { return _emailAdressFrom; }
            set
            {
                _emailAdressFrom = value ??
                throw new ArgumentNullException(nameof(_emailAdressFrom));
            }
        }

        public string EmailPassword
        {
            get { return _emailPassword; }
            set
            {
                _emailPassword = String.IsNullOrWhiteSpace(value) ?
                throw new ArgumentNullException(nameof(_emailPassword)) :
                value;
            }
        }

        public StringPair EmailAdressTo
        {
            get { return _emailAdressTo; }
            set
            {
                _emailAdressTo = value ??
                throw new ArgumentNullException(nameof(_emailAdressTo));
            }
        }

        public string Subject
        {
            get { return _subject; }
            set
            {
                _subject = String.IsNullOrWhiteSpace(value) ?
                throw new ArgumentNullException(nameof(_subject)) :
                value;
            }
        }

        public string Body
        {
            get { return _body; }
            set
            {
                _body = String.IsNullOrWhiteSpace(value) ?
                throw new ArgumentNullException(nameof(value)) :
                value;
            }
        }

        public int Port
        {
            get { return _port; }
            set { _port = value; }
        }

        protected InfoEmail(StringPair emailAdressTo, string subject, string body)
        {
            EmailAdressTo = emailAdressTo;
            Subject = subject;
            Body = body;
        }


    }
}
