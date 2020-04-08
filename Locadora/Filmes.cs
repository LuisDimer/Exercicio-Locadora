using System;
using System.Collections.Generic;
using System.Linq;

namespace Locadora
{
    public class Filmes
    {
        public List<Filme> ListaFilmes { get; private set; }
        public List<Filme> ListaSemFilmesRemovidos { get; private set; }

        public Filmes()
        { 
            ListaFilmes = new List<Filme>();
            ListaSemFilmesRemovidos = new List<Filme>();
        }

        public void Adicionar(Filme filme)
        {
            ListaFilmes.Add(filme);
        }

        public void ListarFilmes()
        {
            foreach (var filme in ListaFilmes)
            {
                Console.WriteLine("===================================================");
                Console.WriteLine($"Nome: {filme.Nome}");
                Console.WriteLine($"Gênero: {filme.Genero}");
                Console.WriteLine($"Mídia: {filme.TipoMidia}");
                Console.WriteLine($"Preço: R${filme.Preco}");
                Console.WriteLine($"Cadastrado: {filme.DataCadastro}");
                Console.WriteLine($"ID: {filme.Id}");
            }
        }

        public void RemoverFilme(string nomeFilmeRemover)
        {
            foreach (var filme in ListaFilmes)
            {
                if (filme.Nome != nomeFilmeRemover)
                {
                    ListaSemFilmesRemovidos.Add(filme);
                }
            }

            ListaFilmes = ListaSemFilmesRemovidos;
            Console.WriteLine("");
            Console.WriteLine($"Filme deletado, aperte ENTER para continuar...");
            Console.ReadLine();
            Console.Clear();
        }

        public void AlterarCadastroFilme()
        {
            bool execucao = true;
            Console.WriteLine("Informe o nome do filme a ser alterado");
            Console.Write(">> ");
            string nomeFilmeSerAlterado = Console.ReadLine();
            Console.Clear();

                foreach (var filme in ListaFilmes)
                {
                    if (filme.Nome == nomeFilmeSerAlterado)
                    {
                        do
                        {
                            Console.WriteLine("===================================================");
                            Console.WriteLine($"Filme: {filme.Nome}");
                            Console.WriteLine($"Genero: {filme.Genero}");
                            Console.WriteLine($"Midia: {filme.TipoMidia}");
                            Console.WriteLine($"Preço: R${filme.Preco}");
                            Console.WriteLine($"Cadastro criado em: {filme.DataCadastro}");
                            Console.WriteLine($"ID: {filme.Id}");
                            Console.WriteLine("===================================================");
                            Console.WriteLine("");
                            Console.WriteLine("Digite o número do campo a ser alterado");
                            Console.WriteLine("1. Nome");
                            Console.WriteLine("2. Genero");
                            Console.WriteLine("3. Mídia");
                            Console.WriteLine("4. Preço");
                            Console.WriteLine("5. Sair para o MENU");
                            Console.Write("");
                            Console.Write(">> ");
                            string opcaoAlterarCadastro = Console.ReadLine();

                            switch (opcaoAlterarCadastro)
                            {
                                case "1":
                                    Console.Clear();
                                    Console.WriteLine("Digite o novo nome:");
                                    Console.Write(">> ");
                                    string nomeNovo = Console.ReadLine();
                                    filme.Nome = nomeNovo;
                                    Console.WriteLine("");
                                    Console.WriteLine($"Nome do Filme alterado para {nomeNovo}, aperte ENTER para sair...");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;

                                case "2":
                                    Console.Clear();
                                    Console.WriteLine("Digite o Genero desejado: Ação, Comédia, Ficção, Romance, Terror");
                                    Console.Write(">> ");
                                    string novoGenero = Console.ReadLine();
                                    Genero genero = (Genero)Enum.Parse(typeof(Genero), novoGenero);
                                    filme.Genero = genero;
                                    Console.WriteLine("");
                                    Console.WriteLine($"Genero alterado para {novoGenero}, aperte ENTER para sair...");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;

                                case "3":
                                    Console.Clear();
                                    Console.WriteLine("Digite a mídia desejada: BluRay; DVD; VHS");
                                    Console.Write(">> ");
                                    string novoTipoMidia = Console.ReadLine();
                                    TipoMidia tipoMidia = (TipoMidia)Enum.Parse(typeof(TipoMidia), novoTipoMidia);
                                    filme.TipoMidia = tipoMidia;
                                    Console.WriteLine("");
                                    Console.WriteLine($"Mídia alterada para {novoTipoMidia}, aperte ENTER para sair...");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;

                                case "4":
                                    Console.Clear();
                                    Console.WriteLine("Opção Preço selecionada, digite o novo valor");
                                    Console.Write(">> R$");
                                    string novoPreco = Console.ReadLine();
                                    double preco = double.Parse(novoPreco);
                                    filme.Preco = preco;
                                    Console.WriteLine("");
                                    Console.WriteLine($"Preço alterado para R${novoPreco} aperte ENTER para sair...");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;

                                case "5":
                                    Console.Clear();
                                    execucao = false;
                                    Console.Clear();
                                    break;

                                default:
                                    Console.WriteLine("");
                                    Console.WriteLine("Foi digitado incorretamente o número da opção, aperte ENTER para sair...");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                            }

                         } while (execucao == true);

                    }
                }
        }
    }
}