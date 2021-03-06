﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Contacts
{
    public class Mail : Contact
    {
        public string mail { get; set; }

        public Mail(string _mail, string contactName)
        {
            ContactName = contactName;
            mail = _mail;
        }

        public int CompareTo(Mail mailContact)
        {
            if (mailContact == null) return 1;

            Mail otherMailContact = mailContact as Mail;
            if (otherMailContact != null)
                return this.mail.CompareTo(otherMailContact.mail);
            else
                throw new ArgumentException("Object is not a MailContact");
        }

        public override string ToString()
        {
            return string.Format("Contact - mailto: ({0}), name - {1}", mail, ContactName);
        }

        public XElement ToXml()
        {
            XElement xmlContact = new XElement("Contacts", new XElement("Mail",
                new XElement("Name", new XAttribute("Value", ContactName)),
                new XElement("mail", new XAttribute("Value", mail))));

            return xmlContact;
        }
    }
}
