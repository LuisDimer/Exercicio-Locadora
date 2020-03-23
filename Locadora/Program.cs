using System;

namespace Locadora
{
    class Program
    {
        public static void Main(string[] args)
        {
            var filmes = new Filmes();
            var clientes = new Clientes();
            bool execucao = true;

            do
            {
                Console.WriteLine("======================= MENU ========================");
                Console.WriteLine("Digite o número da função desejada");
                Console.WriteLine("1. Cadastrar Filme");
                Console.WriteLine("2. Cadastrar Cliente");
                Console.WriteLine("3. Listar Filmes");
                Console.WriteLine("4. Listar Clientes");
                Console.WriteLine("5. Remover Filmes");
                Console.WriteLine("6. Alterar Filme");
                Console.WriteLine("7. SAIR");
                Console.WriteLine("");
                Console.Write(">> ");
                string funcao = Console.ReadLine();
                Console.Clear();

                switch (funcao)
                {
                    case "1":
                        string id = Guid.NewGuid().ToString();

                        Console.WriteLine("Informe o nome do filme");
                        Console.Write(">> ");
                        string nome = Console.ReadLine();
                        Console.Clear();

                        DateTime dataCadastro = DateTime.Now;

                        Console.WriteLine("Informe o Genero do filme Ação; Comédia; Ficção; Romance; Terror");
                        Console.Write(">> ");
                        string generoEscolhido = Console.ReadLine();
                        Genero genero = (Genero)Enum.Parse(typeof(Genero), generoEscolhido);
                        Console.Clear();

                        Console.WriteLine("Informe o tipo de mídia: BluRay; DVD; VHS");
                        Console.Write(">> ");
                        string tipoMidiaEscolhida = Console.ReadLine();
                        TipoMidia tipoMidia = (TipoMidia)Enum.Parse(typeof(TipoMidia), tipoMidiaEscolhida);
                        Console.Clear();

                        Console.WriteLine("Informe o preço do filme");
                        Console.Write(">> R$");
                        string inputPreco = Console.ReadLine();
                        double preco = double.Parse(inputPreco);
                        Console.Clear();

                        var filme = new Filme(id, nome, dataCadastro, genero, preco, tipoMidia);

                        filmes.Adicionar(filme);

                        Console.WriteLine("================== Filme Cadastrado ==================");
                        Console.WriteLine($"Nome: {filme.Nome}");
                        Console.WriteLine($"Gênero: {filme.Genero}");
                        Console.WriteLine($"Mídia: {filme.TipoMidia}");
                        Console.WriteLine($"Preço: R${filme.Preco}");
                        Console.WriteLine($"Cadastrado: {filme.DataCadastro}");
                        Console.WriteLine($"ID: {filme.Id}");
                        Console.WriteLine("");
                        Console.WriteLine("Cadastro finalizado, aperte ENTER para sair...");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "2":
                        string idCliente = Guid.NewGuid().ToString();

                        Console.WriteLine("Informe o nome do cliente");
                        Console.Write(">> ");
                        string nomeCliente = Console.ReadLine();

                        Console.WriteLine("");
                        Console.WriteLine("Informe o CPF do cliente");
                        Console.Write(">> ");
                        string cpfCliente = Console.ReadLine();

                        Console.WriteLine("");
                        Console.WriteLine("Informe a data de nascimento do cliente");
                        Console.Write(">> ");
                        string dataNascimentoCliente = Console.ReadLine();

                        DateTime dataCadastroCliente = DateTime.Now;

                        var cliente = new Cliente(idCliente, nomeCliente, cpfCliente, dataNascimentoCliente, dataCadastroCliente);
                        clientes.Adicionar(cliente);

                        Console.WriteLine("");
                        Console.WriteLine("======= Cliente Cadastrado ===========================");
                        Console.WriteLine($"Nome: {cliente.NomeCliente}");
                        Console.WriteLine($"CPF: {cliente.CpfCliente}");
                        Console.WriteLine($"Data de Nascimento: {cliente.DataNascimentoCliente}");
                        Console.WriteLine($"Cadastro criado em: {cliente.DataCadastroCliente}");
                        Console.WriteLine($"ID: {cliente.IdCliente}");
                        Console.WriteLine("");
                        Console.WriteLine("Cadatro finalizado, aperte ENTER para sair...");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "3":
                        filmes.ListarFilmes();
                        Console.WriteLine("===================================================");
                        Console.WriteLine("");
                        Console.WriteLine("Aperte ENTER para continuar...");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "4":
                        clientes.ListarClientes();
                        Console.WriteLine("===================================================");
                        Console.WriteLine("");
                        Console.WriteLine("Aperte ENTER para continuar...");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "5":
                        Console.WriteLine("Informe o nome do filme que deseja ser removido");
                        string nomeFilmeRemover = Console.ReadLine();
                        filmes.RemoverFilme(nomeFilmeRemover);
                        break;

                    case "6":
                        filmes.AlterarCadastroFilme();
                        break;

                    case "7":
                        execucao = false;
                        break;

                    default:
                        Console.WriteLine("Função inválida, aperte ENTER para retornar...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            } while (execucao == true);
        }
    }
}