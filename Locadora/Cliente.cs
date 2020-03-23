﻿using System;

namespace Locadora
{
    public class Cliente
    {
        public string IdCliente { get; private set; }
        public string NomeCliente { get; private set; }
        public string CpfCliente { get; private set; }
        public string DataNascimentoCliente { get; private set; }
        public DateTime DataCadastroCliente { get; private set; }

        public Cliente(string idCliente, string nomeCliente, string cpfCliente, string dataNascimentoCliente, DateTime dataCadastroCliente)
        {
            IdCliente = idCliente;
            NomeCliente = nomeCliente;
            CpfCliente = cpfCliente;
            DataNascimentoCliente = dataNascimentoCliente;
            DataCadastroCliente = dataCadastroCliente;
        }
    }
}
