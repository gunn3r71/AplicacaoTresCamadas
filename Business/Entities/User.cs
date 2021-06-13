using Database;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace Business.Entities
{
    public class User : Base
    {
        public User()
        {
        }

        public User(string nome, string telefone, string email) : base(nome, telefone, email)
        {
        }

        public override string ToString()
        {
            return $"Nome: {this.Nome}\n"
                  + $"Telefone: {this.Cpf}\n"
                  + $"Email: {this.Email}\n";
        }
    }
}
