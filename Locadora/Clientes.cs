using System;
using System.Collections.Generic;

namespace Locadora
{
    public class Clientes
    {
        public List<Cliente> ListaClientes { get; private set; }

        public Clientes()
        {
            ListaClientes = new List<Cliente>();
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
    }
}