using System;

namespace Locadora
{
    public class AdicionaCliente
    {
        public static void Adiciona()
        {
            string id = Guid.NewGuid().ToString();

            Console.WriteLine("Informe o nome do cliente");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o CPF do cliente"); //Implementar validador de CPF
            string cpf = Console.ReadLine();

            Console.WriteLine("Informe a data de nascimento do cliente");
            string dataNascimento = Console.ReadLine();

            DateTime dataCadastro = DateTime.Now;

            Cliente cliente = new Cliente(id, nome, cpf, dataNascimento, dataCadastro);

            Console.WriteLine("");
            Console.WriteLine("Cliente cadastrado");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Nome: {cliente.Nome}");
            Console.WriteLine($"CPF: {cliente.Cpf}");
            Console.WriteLine($"Data de Nascimento: {cliente.DataNascimento}");
            Console.WriteLine($"Data de Cadastro: {cliente.DataCadastro}");

            Console.WriteLine("");
            Console.WriteLine("Aperte ENTER para sair...");
            Console.ReadLine();
        }
    }
}
