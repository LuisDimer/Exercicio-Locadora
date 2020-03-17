//Adicionar - FEITO
//Pesquisar* Op - 3
//Alterar - 1
//Remover - 2


using System;

namespace Locadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Funções");
            Console.WriteLine("1. Cadastrar Filme");
            Console.WriteLine("2. Cadastrar Cliente");

            string funcao = Console.ReadLine();

            switch(funcao)
            {
                case "1":
                    AdicionaFilme.Adiciona();
                    break;

                case "2":
                    AdicionaCliente.Adiciona();
                    break;

                default:
                    Console.WriteLine("Função inválida, aperte ENTER para sair...");
                    Console.ReadLine();
                    break;
            }
        }
    }
}