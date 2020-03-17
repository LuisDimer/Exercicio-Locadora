using System;

namespace Locadora
{
    public class Filme
    {
        public string Id { get; private set; }
        public string Nome { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public Genero Genero { get; private set; }
        public double Preco { get; private set; }
        public TipoMidia TipoMidia { get; private set; }

        public Filme(string id, string nome, DateTime dataCadastro, Genero genero, double preco, TipoMidia tipoMidia)
        {
            Id = id;
            Nome = nome;
            DataCadastro = dataCadastro;
            Genero = genero;
            Preco = preco;
            TipoMidia = tipoMidia;
        }
    }
}