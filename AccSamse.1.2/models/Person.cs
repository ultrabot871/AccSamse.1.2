using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccSamse._1._2.Models
{
    internal class Person
    {
        private int id_person;
        private string name;
        private string last_Name;
        private string email;
        private string document;
        private string phone;

        public Person(int id_person, string name, string last_Name,
            string email, string document, string phone)
        {
            this.id_person = id_person;
            this.name = name;
            this.last_Name = last_Name;
            this.email = email;
            this.document = document;
            this.phone = phone;
        }

        public int Id_person { get => id_person; set => id_person = value; }
        public string Name { get => name; set => name = value; }
        public string Last_Name { get => last_Name; set => last_Name = value; }
        public string Email { get => email; set => email = value; }
        public string Document { get => document; set => document = value; }
        public string Phone { get => phone; set => phone = value; }
    }
}
