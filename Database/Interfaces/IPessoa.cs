using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public interface IPessoa
    {
        void SetNome(string nome);
        void SetTelefone(string telefone);
        void SetEmail(string email);
        void Adicionar();
        List<IPessoa> Ler();
        string RetornaFormatado();
    }
}
