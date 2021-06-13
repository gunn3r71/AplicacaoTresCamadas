using System;

namespace Database
{
    public interface IPessoa
    {
        void SetNome(string nome);
        void SetCpf(string cpf);
        void SetEmail(string email);
        void Salvar();
    }
}
