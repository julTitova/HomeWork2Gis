﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Contacts
{
    public class TelephoneContact : Contact
    {
        public long ZoneCode {get; set;}
        public TelephoneContact(long zoneCode, string contactName)
        {
            ContactName = contactName;
            ZoneCode = zoneCode;
        }

        public override string ToString()
        {
            return string.Format("Contact - Number: {0}, name - {1}",  ZoneCode, ContactName);
        }

        public XElement ToXml()
        {
             XElement xmlContact = new XElement("Contacts", new XElement("PhoneContacts",
                 new XElement("Name", new XAttribute("Value", ContactName)),
                 new XElement("ZoneCode", new XAttribute("Value", ZoneCode))));

            return xmlContact;
        }
    }
}
