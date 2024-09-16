﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSql.Model
{
    public class Contact
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public class AllContacts
        {
            public List<Contact> Contacts { get; set; }
        }
    }
}