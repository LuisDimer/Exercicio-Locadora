using System;

namespace Locadora
{
    public class AdicionaFilme
    {
        public static void Adiciona()
        {
            string id = Guid.NewGuid().ToString();

            Console.WriteLine("Informe o nome do filme");
            string nome = Console.ReadLine();

            DateTime dataCadastro = DateTime.Now;

            Console.WriteLine("Informe o Genero do filme Ação; Comédia; Ficção; Romance; Terror");
            string generoEscolhido = Console.ReadLine();
            Genero genero = (Genero)Enum.Parse(typeof(Genero), generoEscolhido);

            Console.WriteLine("Informe o tipo de mídia: BluRay; DVD; VHS");
            string tipoMidiaEscolhida = Console.ReadLine();
            TipoMidia tipoMidia = (TipoMidia)Enum.Parse(typeof(TipoMidia), tipoMidiaEscolhida);

            Console.WriteLine("Informe o preço do filme");
            string inputPreco = Console.ReadLine();
            double preco = double.Parse(inputPreco);

            Filme filme = new Filme(id, nome, dataCadastro, genero, preco, tipoMidia);

            Console.WriteLine("");
            Console.WriteLine("Filme cadastrado");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Filme: {filme.Nome}");
            Console.WriteLine($"Data cadastro: {filme.DataCadastro}");
            Console.WriteLine($"Genero: {filme.Genero}");
            Console.WriteLine($"Preço: R${filme.Preco}");
            Console.WriteLine($"Midia: {filme.TipoMidia}");

            Console.WriteLine("");
            Console.WriteLine("Aperte ENTER para sair...");
            Console.ReadLine();
        }
    }
}
