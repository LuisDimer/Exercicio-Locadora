using System;

namespace Locadora
{
    public class Filme
    {
        public string Id { get; private set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; private set; }
        public Genero Genero { get; set; }
        public double Preco { get; set; }
        public TipoMidia TipoMidia { get; set; }

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