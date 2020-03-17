using System;

namespace Locadora
{
    public class Cliente
    {
        public string Id { get; private set; }
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string DataNascimento { get; private set; }
        public DateTime DataCadastro { get; private set; }

        public Cliente(string Id, string nome, string cpf, string dataNascimento, DateTime dataCadastro)
        {
            Id = Id;
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            DataCadastro = dataCadastro;
        }
    }
}
