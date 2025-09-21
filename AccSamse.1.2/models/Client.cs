using AccSamse._1._2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccSamse._1._2.Models
{
    internal class Client : Person
    {

        public Client()
        {
        }

        public Client(int id_person, string name,
            string last_Name, string email,
            string document, string phone, 
            string typeClient
            ): 
            base(id_person, name,
             last_Name, email,
             document, phone
            )
        {
        }

    }
}
