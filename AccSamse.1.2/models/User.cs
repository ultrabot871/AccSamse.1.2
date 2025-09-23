using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AccSamse._1._2.Models
{
    public class User : Person
    {
        private string role;
        private string password;
        private string state;

        public User(int id_person, string name, 
            string last_Name, string email, 
            string document, string phone,
            string role, string password, 
            string state
            ): 
            base( id_person,  name,
             last_Name,  email,
             document,  phone
            )
        {
            this.role = role;
            this.password = password;
            this.state = state;
        }
        public User() { }
        public string Role { get => role; set => role = value; }
        public string Password { get => password; set => password = value; }
        public string State { get => state; set => state = value; }
    }
}
