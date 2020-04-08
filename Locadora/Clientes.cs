using System;
using System.Collections.Generic;

namespace Locadora
{
    public class Clientes
    {
        public List<Cliente> ListaClientes { get; private set; }
        public List<Cliente> ListaClientesRemovidos { get; private set; }

        public Clientes()
        {
            ListaClientes = new List<Cliente>();
            ListaClientesRemovidos = new List<Cliente>();
        }

        public void Adicionar(Cliente cliente)
        {
            ListaClientes.Add(cliente);
        }

        public void ListarClientes()
        {

            foreach (var cliente in ListaClientes)
            {
                Console.WriteLine("===================================================");
                Console.WriteLine($"Nome: {cliente.NomeCliente}");
                Console.WriteLine($"CPF: {cliente.CpfCliente}");
                Console.WriteLine($"Data de Nascimento: {cliente.DataNascimentoCliente}");
                Console.WriteLine($"Cadastro criado em: {cliente.DataCadastroCliente}");
                Console.WriteLine($"ID: {cliente.IdCliente}");
            }
        }

        public void RemoverCliente(string nomeClienteRemover)
        {
            foreach (var cliente in ListaClientes)
            {
                if (cliente.NomeCliente != nomeClienteRemover)
                {
                    ListaClientesRemovidos.Add(cliente);
                }
            }

            ListaClientes = ListaClientesRemovidos;
            Console.WriteLine("");
            Console.WriteLine($"Cliente deletado, aperte ENTER para continuar...");
            Console.ReadLine();
            Console.Clear();
        }

        public void AlterarCadastroCliente()
        {
            bool execucao = true;
            Console.WriteLine("Informe o nome do Cliente a ser alterado");
            Console.Write(">> ");
            string nomeClienteSerAlterado = Console.ReadLine();
            Console.Clear();

            foreach (var cliente in ListaClientes)
            {
                if (cliente.NomeCliente == nomeClienteSerAlterado)
                {
                    do
                    {
                        Console.WriteLine("===================================================");
                        Console.WriteLine($"Nome: {cliente.NomeCliente}");
                        Console.WriteLine($"CPF: {cliente.CpfCliente}");
                        Console.WriteLine($"Data de Nascimento: {cliente.DataNascimentoCliente}");
                        Console.WriteLine($"Cadastro criado em: {cliente.DataCadastroCliente}");
                        Console.WriteLine($"ID: {cliente.IdCliente}");
                        Console.WriteLine("===================================================");
                        Console.WriteLine("");
                        Console.WriteLine("Digite o número do campo a ser alterado");
                        Console.WriteLine("1. Nome");
                        Console.WriteLine("2. CPF");
                        Console.WriteLine("3. Data de Nascimento");
                        Console.WriteLine("4. Sair para o MENU");
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
                                cliente.NomeCliente = nomeNovo;
                                Console.WriteLine("");
                                Console.WriteLine($"Nome do Cliente alterado para {nomeNovo}, aperte ENTER para sair...");
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case "2":
                                Console.Clear();
                                Console.WriteLine("Digite o novo CPF");
                                Console.Write(">> ");
                                string novoCpf = Console.ReadLine();
                                cliente.CpfCliente = novoCpf;
                                Console.WriteLine("");
                                Console.WriteLine($"CPF alterado para {novoCpf}, aperte ENTER para sair...");
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case "3":
                                Console.Clear();
                                Console.WriteLine("Digite a Data de Nascimento");
                                Console.Write(">> ");
                                string novaDataNasccimento = Console.ReadLine();
                                cliente.DataNascimentoCliente = novaDataNasccimento;
                                Console.WriteLine("");
                                Console.WriteLine($"Data de Nascimento alterada para {novaDataNasccimento}, aperte ENTER para sair...");
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case "4":
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