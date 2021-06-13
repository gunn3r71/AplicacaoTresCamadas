using Database;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace Business.Entities
{
    class Usuario : Base
    {
        public Usuario()
        {
        }

        public Usuario(string nome, string telefone, string email) : base(nome, telefone, email)
        {
        }

        public override string ToString()
        {
            return $"Nome: {this.Nome}\n"
                  + $"Telefone: {this.Telefone}\n"
                  + $"Email: {this.Email}\n";
        }
    }
}
