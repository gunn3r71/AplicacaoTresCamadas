using Database;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace Business.Entities
{
    public class Usuario : Base
    {
        public Usuario()
        {
        }

        public Usuario(string nome, string email, string cpf) : base(nome, email, cpf)
        {
        }

        public override string ToString()
        {
            return $"Nome: {this.Nome}\n"
                  + $"Cpf: {this.Cpf}\n"
                  + $"Email: {this.Email}\n";
        }
    }
}
