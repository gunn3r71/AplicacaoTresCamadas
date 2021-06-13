using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public abstract class Base : IPessoa
    {
        public Base()
        {
        }

        public Base(string nome, string email, string cpf)
        {
            this.Nome = nome;
            this.Email = email;
            this.Cpf = cpf;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }

        public virtual void Salvar()
        {
            throw new NotImplementedException();
        }

        public void SetCpf(string cpf) => this.Cpf = cpf;

        public void SetEmail(string email) => this.Email = email;
            
        public void SetNome(string nome) => this.Nome = nome;
    }
}
