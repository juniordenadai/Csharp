using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Entities
{
    class Client
    {
        public string Nome { get; set; }
        public string email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client(string nome, string email, DateTime birthDate)
        {
            Nome = nome;
            this.email = email;
            BirthDate = birthDate;
        }
    }
}
