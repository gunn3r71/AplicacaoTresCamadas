
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
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
            string stringConexao = "server=localhost;database=SistemaTresCamadas;uid=root;uid=dev; password=dev_app";

            using (var conn = new MySqlConnection(stringConexao))
            {
                string query = $"INSERT INTO {this.GetType().Name}s(Nome,Email,Cpf) Values('{this.Nome}','{this.Email}','{this.Cpf}')";
                var command = new MySqlCommand(query,conn);
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
        }

        public void SetCpf(string cpf) => this.Cpf = cpf;

        public void SetEmail(string email) => this.Email = email;
            
        public void SetNome(string nome) => this.Nome = nome;
    }
}
